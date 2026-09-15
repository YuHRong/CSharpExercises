using System;
using static System.Console;
using System.Diagnostics;
using System.Reflection.Metadata;

Exception? exception = null;

const string menu = """

	  Quick Draw

	  Face your opponent and wait for the signal. Once the
	  signal is given, shoot your opponent by pressing [space]
	  before they shoot you. It's all about your reaction time.

	  Choose Your Opponent:
	  [1] Easy....1000 milliseconds
	  [2] Medium...500 milliseconds
	  [3] Hard.....250 milliseconds
	  [4] Harder...125 milliseconds
	  [escape] give up
	""";

const string wait = """

	  Quick Draw
	                                                        
	                                                        
	                                                        
	              _O                          O_            
	             |/|_          wait          _|\|           
	             /\                            /\           
	            /  |                          |  \          
	  ------------------------------------------------------
	""";

const string fire = """

	  Quick Draw
	                                                        
	                         ********                       
	                         * FIRE *                       
	              _O         ********         O_            
	             |/|_                        _|\|           
	             /\          spacebar          /\           
	            /  |                          |  \          
	  ------------------------------------------------------
	""";

const string loseTooSlow = """

	  Quick Draw
	                                                        
	                                                        
	                                                        
	                                        > ╗__O          
	           //            Too Slow           / \         
	          O/__/\         You Lose          /\           
	               \                          |  \          
	  ------------------------------------------------------
	""";

const string loseTooFast = """

	  Quick Draw
	                                                        
	                                                        
	                                                        
	                         Too Fast       > ╗__O          
	           //           You Missed          / \         
	          O/__/\         You Lose          /\           
	               \                          |  \          
	  ------------------------------------------------------
	""";

const string win = """

	  Quick Draw
	                                                        
	                                                        
	                                                        
	            O__╔ <                                      
	           / \                               \\         
	             /\          You Win          /\__\O        
	            /  |                          /             
	  ------------------------------------------------------
	""";

try
{
  while (true)
  {
    Clear();

    WriteLine(menu);

    TimeSpan? requiredReactionTime = null;
    while (requiredReactionTime is null)
    {
      CursorVisible = false;
      switch (ReadKey().Key)
      {
        case ConsoleKey.D1 or ConsoleKey.NumPad1:
          requiredReactionTime = TimeSpan.FromMilliseconds(1000);
          break;
        case ConsoleKey.D2 or ConsoleKey.NumPad2:
          requiredReactionTime = TimeSpan.FromMilliseconds(0500);
          break;
        case ConsoleKey.D3 or ConsoleKey.NumPad3:
          requiredReactionTime = TimeSpan.FromMilliseconds(0250);
          break;
        case ConsoleKey.D4 or ConsoleKey.NumPad4:
          requiredReactionTime = TimeSpan.FromMilliseconds(0125);
          break;
        case ConsoleKey.Escape:
          return;
      }
    }
    Clear();

    TimeSpan signal = TimeSpan.FromMilliseconds(Random.Shared.Next(5000, 25000));    // 5 到 25 秒的等待时间

    WriteLine(wait);

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Restart();
    bool tooFast = false;

    while (stopwatch.Elapsed < signal && !tooFast)
    {
      if (KeyAvailable && ReadKey(true).Key is ConsoleKey.Spacebar)
      {    // 如果空格点快了
        tooFast = true;
      }
    }
    Clear();

    CursorVisible = false;

    WriteLine(fire);
    stopwatch.Restart();
    bool tooSlow = true;
    TimeSpan reactionTime = default;

    while (!tooFast && stopwatch.Elapsed < requiredReactionTime && tooSlow)
    {
      if (KeyAvailable && ReadKey(true).Key is ConsoleKey.Spacebar)
      {
        tooSlow = false;
        reactionTime = stopwatch.Elapsed;
      }
    }
    Clear();

    WriteLine(
tooFast ? loseTooFast :
tooSlow ? loseTooSlow :
$"{win}{Environment.NewLine} Reaction time: {reactionTime.TotalMilliseconds} milliseconds"
    );

    WriteLine("  Play again [enter] or quit [escape]?");

    CursorVisible = false;

  GetEnterOrEscape:
    switch (ReadKey(true).Key)
    {
      case ConsoleKey.Enter: break;
      case ConsoleKey.Escape: return;
      default: goto GetEnterOrEscape;
    }
  }
}
catch (Exception e)
{
  exception = e;
  throw;
}
finally
{
  Clear();
  CursorVisible = true;
  WriteLine(exception?.ToString() ?? "Quick Draw was closed.");
}
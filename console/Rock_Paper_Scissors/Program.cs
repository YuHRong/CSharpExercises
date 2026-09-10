using System.Collections;
using static System.Console;
using static Move;

int wens = 0;    // 赢
int losses = 0;    // 输
int draws = 0;    // 平局

while (true)
{
  Clear();    // 清除控制台消息
  WriteLine("石头剪刀布小游戏。");
GitInput:    // 定义goto 返回标签
  WriteLine("请输入 (r 或 rock) 选择石头，输入 （p 或 paper) 选择布，输入 (s 或 scissors)选择剪刀，输入（e 或 exit)退出程序。");
  Move playerMove;    // 定义玩家出拳类型
  switch ((ReadLine() ?? "".Trim().ToLower()))
  {
    case "r" or "rock": playerMove = Rock; break;
    case "s" or "scissors": playerMove = Scissors; break;
    case "p" or "paper": playerMove = Paper; break;
    case "e" or "exit": return;
    default: WriteLine("输入错误，请重新输入！"); goto GitInput;
  }

  // 电脑出拳
  Move computerMove = (Move)Random.Shared.Next(0, 3);
  WriteLine($"你选择的是： {playerMove}，电脑选择的是： {computerMove}");
  switch (playerMove, computerMove)    // 使用 switch 元组进行输赢判断
  {
    case (Rock, Paper) or (Paper, Scissors) or (Scissors, Rock):
      WriteLine("你输了一局。");
      losses++;
      break;
    case (Rock, Scissors) or (Paper, Rock) or (Scissors, Paper):
      WriteLine("你赢了一局。。");
      wens++;
      break;
    default:
      WriteLine("平局。");
      draws++;
      break;
  }

  // 打印输赢消息
  WriteLine($"{wens} 赢， {losses} 付， {draws} 平局。");
  WriteLine("回车在玩一局！");
  ReadLine();
}

enum Move
{
  Rock = 0,
  Scissors = 1,
  Paper = 2,
}
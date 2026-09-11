using static System.Console;

int playerPoints = 0;    // 玩家本人胜利次数
int rivalPoints = 0;    // 对手胜利次数
int draws = 0;    // 平局

WriteLine("骰子游戏，");
WriteLine();
WriteLine("你和你的对手摇动 10 次，");
WriteLine("谁的点数大谁赢。");
WriteLine("祝你好运。");
WriteLine();
WriteLine("回车继续。");
ReadLine();

for (int i = 0; i < 10; i++)
{
 WriteLine($"第 {i + 1} 轮");
 WriteLine();

 int rivalRandom = Random.Shared.Next(1, 7);
 WriteLine($"对手的点数是： {rivalRandom}");
 int playerRandom = Random.Shared.Next(1, 7);
 WriteLine($"你的点数是： {playerRandom}");
 if (rivalRandom > playerRandom)
 {
  WriteLine("你输了！");
  rivalPoints++;
 }
 else if (rivalRandom < playerRandom)
 {
  WriteLine("你赢了！");
  playerPoints++;
 }
 else
 {
  WriteLine("本局为平局。");
  draws++;
 }
 WriteLine();
 WriteLine("回车继续！");
 ReadLine();
}

if (rivalPoints > playerPoints)
{
 WriteLine($"对方胜利 {rivalPoints} 次，你的胜利 {playerPoints} 次，平局 {draws} 次。");
 WriteLine("很遗憾，你输了。");
}
else if (rivalPoints < playerPoints)
{
 WriteLine($"对方胜利 {rivalPoints} 次，你的胜利 {playerPoints} 次，平局 {draws} 次。");
 WriteLine("恭喜你，你赢了！");
}
else
{
 WriteLine($"对方胜利 {rivalPoints} 次，你的胜利 {playerPoints} 次，平局 {draws} 次。");
 WriteLine("没有赢家！");
}

WriteLine("回车结束骰子游戏。");
ReadLine();
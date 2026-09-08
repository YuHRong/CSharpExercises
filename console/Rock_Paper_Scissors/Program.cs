using static System.Console;    // 引用 System.Console 类的静态成员
using static Move;    // 引用 Move 枚举的静态成员

int wens = 0;    // 玩家赢的次数
int losses = 0;    // 玩家输的次数
int draws = 0;    // 平局的次数

while (true)
{
 Clear();    // 清空控制台消息
WriteLine("石头、剪刀、布游戏");    // 游戏标题
GetInput:    // 定义 goto 标签，便于在输入无效时重新获取输入
 WriteLine("请输入 r 或 Rock 选择石头，p 或 Paper 选择布，s 或 Scissors 选择剪刀，q 或 Quit 退出游戏");
 Move playerMove;    // 定义玩家的出拳类型
 switch ((ReadLine() ?? "").Trim().ToLower())
 {    // 获取玩家输入并转换为小写，去除前后空格
  case "r" or "rock":
   playerMove = Rock;
   break;
  case "p" or "paper":
   playerMove = Paper;
   break;
  case "s" or "scissors":
   playerMove = Scissors;
   break;
  case "q" or "quit":
   return;
  default:
   WriteLine("输入无效，请重新输入");
   goto GetInput;    // 输入错误跳转到 GetInput 标签重新获取输入
 }

 // 电脑随机出拳
 Move computerMove = (Move)Random.Shared.Next(0, 3);
 WriteLine($"电脑选择了 {computerMove}");
 switch (playerMove, computerMove)    // 使用 switch 表达式判断玩家和电脑的出拳结果
 {
  case (Rock, Paper) or (Paper, Scissors) or (Scissors, Rock):
   WriteLine("你输了");
   losses++;
   break;
  case (Rock, Scissors) or (Paper, Rock) or (Scissors, Paper):
   WriteLine("你赢了");
   wens++;
   break;
  default:
   WriteLine("平局");
   draws++;
   break;
 }
 WriteLine($"胜利次数：{wens}，失败次数：{losses}，平局次数：{draws}");
 WriteLine("按回车继续游戏，按 q 或 Quit 退出游戏");
 ReadKey();
}

enum Move
{
 Rock = 0,
 Paper = 1,
 Scissors = 2,
}
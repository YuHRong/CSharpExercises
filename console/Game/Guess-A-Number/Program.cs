int value = Random.Shared.Next(1, 101);

while (true)
{
 Console.Write("在 1 到 100 之间猜一个数字");
 bool valid = int.TryParse((Console.ReadLine() ?? "").Trim(), out int input);
 if (!valid)
  Console.WriteLine("请输入一个有效的数字！");
 else if (input == value)
  break;
 else
  Console.WriteLine($"错误， {(input < value ? "太小了" : "太大了")}，请再试一次！");
}

Console.WriteLine($"恭喜你，猜对了！答案是 {value}。");
Console.WriteLine("按任意键退出...");
Console.ReadKey(true);
{

}
# 程序分析

## 目录
- [程序分析](#程序分析)
  - [目录](#目录)
  - [程序在这里](#程序在这里)
    - [全局变量](#全局变量)
    - [程序执行](#程序执行)
      - [if 语句](#if-语句)
    - [循环结束后执行](#循环结束后执行)

---

## [程序在这里](Program.cs)

### 全局变量
```c#
int value = Random.Shared.Next(1, 101);
```

使用 `Random.Shared.Next(1, 101)`申明一个1 到 100 的随机数，存储在`int`类型 `value` 变量中。这个变量在程序启动时被初始化，并在整个程序执行期间都可访问。

### 程序执行
```c#
while (true)
 {
 Console.Write("在 1 到 100 之间猜一个数字");
```
程序循环入口，使用`while`循环，`true`为真，程序进入无线循环。

并使用`Console.Write()`打印提示信息。

```c#
 bool valid = int.TryParse((Console.ReadLine() ?? "").Trim(), out int input);
 ```

声明一个布尔变量 `valid` 用于存储转换是否成功的结果。`Console.ReadLine()` 获取用户的输入字符串。`?? ""` 是`空合并运算符`，它确保即使 `Console.ReadLine()` 返回 `null`，也不会导致后续操作出现异常，而是使用一个空字符串。`.Trim()` 方法用于移除输入字符串两端的`空白字符`。最后，`int.TryParse()` 尝试将处理后的字符串转换为 `int` 整型变量，如果转换成功，`valid` 为 `true`，转换后的数字存储在 `out int input` 变量中。如果失败，`valid` 为 `false`。

#### if 语句
```c#
 if (!valid)
  Console.WriteLine("请输入一个有效的数字！");
 else if (input == value)
  break;
 else
  Console.WriteLine($"错误， {(input < value ? "太小了" : "太大了")}，请再试一次！");
}
```

```c#
 if (!valid)
  Console.WriteLine("请输入一个有效的数字！");
```
使用非`!`逻辑运算符判断，如果输入的不是数字，提示重新输入。因为`if`语句没有`return`或`break`语句，程序回到`while`开始重新执行` Console.Write("在 1 到 100 之间猜一个数字");`提示信息并获取输入。

```c#
 else if (input == value)
  break;
```
如果输入的值等于`value`使用`break`结束循环，执行循环后面的程序。
```c#
 else
  Console.WriteLine($"错误， {(input < value ? "太小了" : "太大了")}，请再试一次！");
```
获取输入的数字并与`value`对比，使用`三元运算符`(input < value ? "太小了" : 太大了")`进行判断。

### 循环结束后执行
```c#
Console.WriteLine($"恭喜你，猜对了！答案是 {value}。");
Console.WriteLine("按任意键退出...");
Console.ReadKey(true);
```
打印提示信息，并使用`Console.ReadKey(true)`等下用户按下任意键结束程序。这里的`true`隐藏输入光标。

---
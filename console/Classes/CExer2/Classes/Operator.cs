
namespace CExer2.Classes;

public class Operator
{
 Calculator calculator = new Calculator();

 public double num2Count(char op, double n1, double n2)
 {
  double result = 0.0;
  switch (op)
  {
   case '+':
    result = calculator.加法(n1, n2);
    break;
   case '-':
    result = calculator.减法(n1, n2);
    break;
   case '*':
    result = calculator.乘法(n1, n2);
    break;
   case '/':
    try
    {
     result = calculator.除法(n1, n2);
    }
    catch (ArgumentException ex)
    {
     throw new InvalidOperationException($"计算错误: {ex.Message}", ex);
    }
    break;
   default:
    throw new ArgumentException("无效的运算符", nameof(op));
  }

  return result;
 }

 public double num3Count(char op, double n1, double n2, double n3)
 {
  double result = 0.0;

  switch (op)
  {
   case '+':
    result = calculator.加法(n1, n2, n3);
    break;
   case '-':
    result = calculator.减法(n1, n2, n3);
    break;
   case '*':
    result = calculator.乘法(n1, n2, n3);
    break;
   case '/':
    try
    {
     result = calculator.除法(n1, n2, n3);
    }
    catch (ArgumentException ex)
    {
     throw new InvalidOperationException($"计算错误: \n{ex.Message}", ex);
    }
    break;
   default:
    throw new ArgumentException("无效的运算符", nameof(op));
  }

  return result;
 }
}

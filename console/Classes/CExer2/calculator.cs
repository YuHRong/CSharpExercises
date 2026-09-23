
namespace CExer2.Classes;

public class Calculator
{
 private double _Num1;
 private double _num2;
 private double _num3;

 public Calculator(double num1, double num2, double num3)
 {
  _Num1 = num1;
  _num2 = num2;
  _num3 = num3;
 }
 public Calculator()
 {
  _Num1 = 0.0;
  _num2 = 0.0;
  _num3 = 0.0;
 }

 public double Num1
 {
  get => _Num1;
  set => _Num1 = value;
 }

 public double Num2
 {
  get => _num2;
  set => _num2 = value;
 }

 public double Num3
 {
  get => _num3;
  set => _num3 = value;
 }

 // 加法计算方法
 public double 加法(double n1, double n2)
 {
  return n1 + n2;
 }
 public double 加法(double n1, double n2, double n3)
 {
  return n1 + n2 + n3;
 }

 // 减法计算方法
 public double 减法(double n1, double n2)
 {
  return n1 - n2;
 }
 public double 减法(double n1, double n2, double n3)
 {
  return n1 - n2 - n3;
 }

 // 乘法计算方法
 public double 乘法(double n1, double n2)
 {
  return n1 * n2;
 }
 public double 乘法(double n1, double n2, double n3)
 {
  return n1 * n2 * n3;
 }

 // 除法计算方法
 public double 除法(double n1, double n2)
 {
  if (n2 == 0)
  {
   Console.WriteLine("被除数不能为 0");
   throw new ArgumentException("被除数不能为 0", nameof(n2));  // 抛出 ArgumentException
  }

  return n1 / n2;
 }
 public double 除法(double n1, double n2, double n3)
 {
  if (n2 == 0 || n3 == 0)
  {
   Console.WriteLine("被除数不能为 0");
   throw new ArgumentException("被除数不能为 0", nameof(n2));
   throw new ArgumentException("被除数不能为 0", nameof(n3));
  }

  return n1 / n2 / n3;
 }
}

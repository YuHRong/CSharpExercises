using CExer1;

Person p1 = new("小明", "王")
{
 Age = 25
};

string fName;
string lName;
int yAges;
p1.Display(out fName, out lName, out yAges);

Console.WriteLine($"姓名： {lName}{fName}, 年龄： {yAges}");
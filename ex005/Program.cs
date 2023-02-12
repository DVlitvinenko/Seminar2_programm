// 16. Напишите программу, которая принимает на вход два 
//числа и проверяет,
// является ли одно число квадратом другого.


Console.Clear();
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if(n2 == n1*n1 || n1 == n2*n2)
  Console.WriteLine("yes");
else
    Console.WriteLine("no");

//Напишите программу, которая будет принимать на вход 
//два числа и выводить, является ли второе число кратным 
//первому. Если число 2 не кратно числу 1, то программа 
//выводит остаток от деления.


Console.Clear();
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if(n2 % n1 == 0)
{
  Console.WriteLine("Число кратно");
}
else
{
  Console.WriteLine($"No, {n2%n1}");
}

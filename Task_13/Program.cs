// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write ("Введи трехзначное число" ); 
int x = Convert.ToInt32 (Console.ReadLine ()); 
if (x<100)
{
  Console.WriteLine ("Третьей цифры нет"); 
}

else
{
    while (x>999)
    {
        x=x/10;
    }
x=x%10;
}
Console.WriteLine (x);

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int DeleteNumber (int number)
// {
//     int ed = number%100;
//     int os = ed/10;
//     return os;
// }

// Console.WriteLine ("Введите ТРЕХЗНАЧНОЕ число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = DeleteNumber(num);
// Console.WriteLine(result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//  int DeleteNumber (int number)
// {
//   if (number > 100)
//   {
//     Console.WriteLine ((number/100) % 10);
//     }
//   else
//    Console.WriteLine ("В числе нет третьей цифры"); 
// }

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = DeleteNumber (num);
// Console.WriteLine (result);

// Console.Write("Введите число");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);

// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void DayWeek (int Num) 
{
if (Num > 5)
  {
  Console.WriteLine("это выходной");
  }
 
else 
  {
  Console.WriteLine("это рабочий день");
  }

}
  
Console.Write("Введи цифру, обозначающую день недели: 1-Пн, 2-Вт, 3-Ср, 4-Чт, 5-Пт, 6-Сб, 7-Вс");
int dayNum = Convert.ToInt32(Console.ReadLine());
DayWeek(dayNum);
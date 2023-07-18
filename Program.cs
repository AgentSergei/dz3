

/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. \n Например 14212 -> нет");
            string num = Console.ReadLine();
            string rev = string.Concat(num.Reverse());
            Console.WriteLine(num == rev ? "true" : "false");





/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.\n Например 5 -> 1, 8, 27, 64, 125");
int b = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<(b+1);i++)
            Console.WriteLine(i*i*i);
            


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. \n Например A (3,6,8); B (2,1,-7), -> 15.84");

double [] x = new double [6];
double d, distance = 0.0;
Console.WriteLine("x1 y1 z1 x2 y2 z3:");
var line = Console.ReadLine().Split();
for (int i = 0; i < 3; i++)
      { d = Convert.ToDouble(line[i + 3]) - Convert.ToDouble(line[i]);
        distance += d * d; 
       }

Console.WriteLine("r = " + Math.Truncate(100 * Math.Sqrt(distance)) / 100);

﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите знвачение N");
// int N = Convert.ToInt32(Console.ReadLine());
// AllNaturalNumber(N);
//  void AllNaturalNumber (int N)
// {
//     if (N > 0) // условие окончание рекурсии
//     {
//         AllNaturalNumber(N - 1); // на вход рекурсии нельзя давать тоже число что в методе 
        
//         Console.Write(N + " ");     
//     }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumEvenNumber(numberM, numberN));

// int SumEvenNumber(int numberM, int numberN)
// {
//     if (numberM == numberN)
//     {
//         return numberM;
//     }
//     else if (numberM > numberN)
//     {
//         return numberM + SumEvenNumber(numberM - 1, numberN);
//     }
//     else
//     {
//         return numberM + SumEvenNumber(numberM + 1, numberN);
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(AkkermanFunction(numberM, numberN));

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 & n == 0)
//     {
//         return AkkermanFunction(m-1, 1);
//     }
//     else if (m > 0 & n > 0)
//      {
//         return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
//     }

//     return 0;
// }
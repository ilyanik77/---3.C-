﻿// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void cube( int N ) {
    for ( int i = 1; i < N; i++) 
        {
        Console.Write($"{Math.Pow(i, 3)},");
        }
    Console.Write($"{Math.Pow(N, 3)}.");    
}
cube(N);










// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

//Решение №1.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число: ");
        string? number = Console.ReadLine();

        void palindrome(string number)
        {
            if (number[0] == number[4] & number[1] == number[3])
            {
                Console.WriteLine($"Число {number} является палиндромом");
            }
            else
                Console.WriteLine($"Число {number} не является палиндромом");
        }

        palindrome("number");
    }
}








//Console.WriteLine(N.Reverse().ToArray());
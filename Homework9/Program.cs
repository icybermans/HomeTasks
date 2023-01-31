// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
/*void ShowNumbers(int num){
    Console.Write(num + " ");
    if(num > 1) ShowNumbers(num - 1);
}
Console.Write("Input a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);*/

// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
/*int FindSumOfNumbers(int m, int n){
    if(m < n) return m + FindSumOfNumbers(m+1, n);
    if(m > n) return m + FindSumOfNumbers(m-1, n);
    else return m;
}

Console.WriteLine(FindSumOfNumbers(7, 5));*/

// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.

// Akker(m, n) = :
// n + 1, if m = 0
// Akker(m-1, 1), if m > 0 and n = 0
// Akker(m-1, Akker(m, n-1)), if m > 0 and n > 0

int Akker(int m, int n){
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Akker(m-1, 1);
    else return Akker(m-1, Akker(m, n-1));
}

Console.WriteLine(Akker(1,1));
// при Akker(4, 1) уже перегрузка 
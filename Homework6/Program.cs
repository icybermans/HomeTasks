// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int FindCountOfPosNumbers(int m){
    int count = 0;
    for(int i = 0; i < m; i++){
        Console.Write($"Input {i+1} number: ");
        if(Convert.ToInt32(Console.ReadLine())> 0) count++;
    }
    return count;
}

Console.Write("Input a count of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Count of positive numbers is {FindCountOfPosNumbers(m)}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
void CoorIntersectionPoint(double k1, double b1, double k2, double b2){
    double x = 0;
    double y = 0;
    if(k1 == k2 && b1 == b2) Console.Write("Прямые совпадают. Точек пересения бесконечно много.");
    else if(k1 == k2 && b1 != b2) Console.WriteLine("Прямые паралельны. Точек пересения нет");
    else{
        Console.WriteLine("Прямые пересекаются");
        x = Math.Round((b2-b1)/(k1-k2), 1);
        y = Math.Round(k1*x + b1, 1);
        Console.WriteLine($"Абсцисса точки пересения: {x}, ордината: {y}");
    }
}

Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

CoorIntersectionPoint(k1, b1, k2, b2);




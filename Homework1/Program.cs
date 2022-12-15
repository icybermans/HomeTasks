//HomeTask1

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2) Console.WriteLine($"Число {number1} большее, а число {number2} меньшее");
else if(number1 == number2) Console.WriteLine($"Числа {number1} и {number2} равны");
else Console.WriteLine($"Число {number2} большее, а число {number1} меньшее");*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Пришло время отсыкать наибольшее среди 3х чисел :)");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.WriteLine($"Наибольшее число среди 3х введенных равно {max}");*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0) Console.WriteLine("Введеное число четное");
else Console.WriteLine("Введеное число нечетное");*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int cur_number = 0;
while(cur_number <= number){
    if(cur_number%2 == 0) Console.WriteLine(cur_number);
    cur_number += 2;
}*/


Console.WriteLine("КОНЕЦ :)");
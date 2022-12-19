//HomeTask2

// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*int Number(int number){
    int des = (number/10)%10;
    return des;
}

Console.Write("Введите трехзначное число (от 100 до 999): ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999){
    Console.WriteLine($"Вторая цифра введенного числа равна: {Number(num)}");
}
else Console.WriteLine("Введите трехзначное число!");*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber(int number){
    int initNumber = number;
    int count = 0;
    while(number > 0){
        number /= 10;
        count += 1;
    }
    if(count >= 3) {
        int divBase = Convert.ToInt32(Math.Pow(10, count - 3));
        int thirdNumber = initNumber/divBase%10;
        return thirdNumber;
    }
    else return -1;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(ThirdNumber(num) >=0 ) Console.WriteLine($"Третья цифра числа {num} равна {ThirdNumber(num)}");
else Console.WriteLine("Третьей цифры нет!");
*/
// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*bool IsWeekend(int number){
    if(number == 6 || number == 7) return true;
    else return false;
}
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(IsWeekend(number) == true) Console.WriteLine($"Да, {number}й день недели - это выходной :)");
else Console.WriteLine($"Нет, {number}й день недели НЕ выходной ");*/
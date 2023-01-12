// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Pow(int a, int b){
    //int pow = a;
    //for(int i = 1; i < b; i++){
    //    pow *= a;

    int pow = 1;
    for(int i = 1; i <= b; i++) {
        pow *= a;
    }
    return pow;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Pow(a, b);
Console.WriteLine($"Number {a} in degree {b} равно {result}");
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int SumDigits(int num){
    int sum = 0;
    while(num != 0){
        sum += num%10;
        num /= 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(num);
Console.WriteLine($"Sum of digits of number {num} is {result}");*/

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
int[] FillArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        Console.Write($"Input {i+1}th element of array (or element with index {i}): ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
}
Console.Write("Input array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = FillArray(size);
PrintArray(newArray);
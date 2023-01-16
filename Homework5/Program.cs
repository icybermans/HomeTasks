// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int CountElem(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
        if(arr[i]%2 == 0) count++;
    return count;
}
Console.Write("Enter a array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
PrintArray(newArray);
int count = CountElem(newArray);
Console.WriteLine($"Count of even numbers in this array is {count}");*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях
/*int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int SumOfElemInOddPosition(int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        if(i%2 == 1) sum += array[i];
    }
    return sum;
}

Console.Write("Enter a array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
PrintArray(newArray);
int sum = SumOfElemInOddPosition(newArray);
Console.WriteLine($"Sum of elements in odd positions is {sum}"); */

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
double[] CreateRandomDoubleArray(int size){
    double[] array = new double[size];
    int arrInt = 0;
    double arrDouble = 0.0;
    for(int i = 0; i < size; i++){
        arrInt = new Random().Next(1, 10);
        arrDouble = new Random().NextDouble();
        array[i] = Math.Round(arrInt + arrDouble, 2);
    }
    return array;
}

void PrintArray(double[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    Console.WriteLine();
}

double DiffOfMaxAndMin(double[] arr){
    double max = arr[0];
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    return max - min;
}
Console.Write("Enter a array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(size);
PrintArray(newArray);
double diff = DiffOfMaxAndMin(newArray);
Console.WriteLine($"Difference between max and min elements is {diff}");
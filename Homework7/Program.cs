// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Create2dRandomDoubleArray(int m, int n, int minValue, int maxValue){
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(Math.Round(arr[i, j], 1) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] newArray = Create2dRandomDoubleArray(m, n, minValue, maxValue);
PrintArray(newArray);

*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2dRandomIntArray(int row, int column){
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void PrintArray(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// метод прописан, исходя из предположения, что индексы элемента на 1 меньше размерностей массива
int FindElementByPositionInArray(int[,] arr, int m, int n){
    if(m < arr.GetLength(0) && n < arr.GetLength(1)) return arr[m,n];
    else return -1000;
}

Console.Write("Input a rows number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a columns number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dRandomIntArray(row, column);
PrintArray(newArray);

Console.Write("Input a row index: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column index: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

int result = FindElementByPositionInArray(newArray, rowIndex, columnIndex);
if(result >= 0) Console.WriteLine($"Element with indeces ({rowIndex},{columnIndex}) is {result}");
else Console.WriteLine($"Element with indeces ({rowIndex},{columnIndex}) doesn't exist");

*/
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

int[,] Create2dRandomIntArray(int row, int column){
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void Print2dArray(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + "\t");
    Console.WriteLine();
    
}

double[] FindAverageInColumns(int[,] array){
    double[] averageArray = new double[array.GetLength(1)];
    double sum;
    for(int i = 0; i < array.GetLength(1); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(0); j++){
            sum += array[j, i];
        }
        averageArray[i] = Math.Round( (sum/array.GetLength(0)), 1);
    }
    return averageArray;
}

Console.Write("Input a rows number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a columns number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dRandomIntArray(row, column);
Print2dArray(newArray);

double[] averageArray = FindAverageInColumns(newArray);
PrintArray(averageArray);

// Домашняя работа №3 

//-------------------------ЗАДАЧА 1----------------------------------------
/* Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.*/

// способ №1
/*
string Number(string num){
    int number = Convert.ToInt32(num);
    string mod_num = "";
    while(true){
        if(number == 0) break;
        mod_num += number%10;
        number /= 10;
    }
    return mod_num;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();

if(number == Number(number)) Console.WriteLine("Это число - палиндром!");
else Console.WriteLine("Это число НЕ является палиндромом!");*/

// способ №2
/*
int GetCountDigits(int number){
    int count = 0;
    while(true){
        if(number == 0) break;
        number /= 10;
        count++;
    }
    return count;
}

bool Checking(int number, int count){
    bool flag = true;
    int[] array = new int[count];
    int index = 0;

    while(index < count){
        array[index] = number%10;
        number /= 10;
        index++;
    }
    
    int pos = 0;
    while(pos < array.Length){
        if(array[pos] != array[array.Length - 1 - pos]) {
            flag = false;
            break;
        }
        pos++;
    }
    return flag;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = GetCountDigits(num);
Console.WriteLine(count);

if(Checking(num, count) == true) Console.WriteLine("Это число - палиндром!");
else Console.WriteLine("Это число НЕ является палиндромом!");*/

//-------------------------ЗАДАЧА 2----------------------------------------
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2){
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return Math.Round(dist, 2);
}

Console.WriteLine("Введите координаты 1й точки");
Console.Write("Координата х 1й точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата y 1й точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата z 1й точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты 2й точки");
Console.Write("Координата х 2й точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата y 2й точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата z 2й точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double d = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {d}");*/

//---------------------------ЗАДАЧА 3-----------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void GetCubes(int number){
    int n = 1;
    while(n <= number){
        Console.Write($"{n*n*n} ");
        n++;
    }
}

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n <= 0) Console.WriteLine("Вы ввели НЕ натуральное число!");
else GetCubes(n);*/
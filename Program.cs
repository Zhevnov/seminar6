//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colums];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colums; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] newArray = CreateRandom2Array();
Show2Array(newArray);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.
/*
int[,] CreatArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = i + j;
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreatArray(rows, colums);
Show2Array(newArray);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
    return array;
}

int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colums];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colums; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] newArray = CreateRandom2Array();

Show2Array(newArray);
ChangeArray(newArray);
Show2Array(newArray);
*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int GetSumDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        result += array[i, i];
}
int[,] newArray = CreateRandom2Array();
Show2Array(newArray);
Console.WriteLine(GetSumDiagonal(newArray));
*/
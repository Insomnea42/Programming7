// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


//Раздел вспомогательных методов
void FillAndPrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 43);
            Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

bool CheckingElement(int[,] matr, int m, int n)
{
    if (m <= matr.GetLength(0))
    {
        if (n <= matr.GetLength(1)) return true;
        else return false;
    }
    else return false;
}

//Текст кода
Console.WriteLine("Введите высоту матарицы: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите длину строки матрицы: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Укажите номер строки: ");
int str = int.Parse(Console.ReadLine());

Console.WriteLine("Укажите номер колонки: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillAndPrintArray(array);

if (CheckingElement(array, str, column)) Console.Write("На заданном пересечении элемент: " + array[str - 1, column - 1]);
else Console.Write("На заданном пересечении элемента нет");

Console.WriteLine();
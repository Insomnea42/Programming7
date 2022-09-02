// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

//Раздел вспомогательных методов
void FillAndPrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
            Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();

    }
}

void SumColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        //float aver;
        //aver = sum / matr.GetLength(0);
        Console.Write((double)sum / matr.GetLength(0) + "; ");
    }
}

//Текст кода
Console.WriteLine("Введите высоту матарицы: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите длину строки матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillAndPrintArray(array);
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
SumColumn(array);
Console.WriteLine();


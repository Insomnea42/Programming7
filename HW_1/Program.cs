// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Раздел вспомогательных методов
void FillAndPrintArray(double[,] matr)
{
    double a;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            a = new Random().Next(1, 10);
            a = a / 0.422;
            matr[i, j] = Math.Round(a, 1);
            Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();

    }
}

//Текст кода
Console.WriteLine("Введите высоту матарицы: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите длину строки матрицы: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

FillAndPrintArray(array);


// Задача 1. Показать двумерный массив размером m×n заполненный вещественными числами

void FillArrayRandomNumbers(double[,] mas)
{
 for (int m = 0; m < mas.GetLength(0); m++)
    {
 for (int n = 0; n < mas.GetLength(1); n++)
        {
 mas[m, n] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] mas)
{
 for (int m = 0; m < mas.GetLength(0); m++)
    {
        for (int n = 0; n < mas.GetLength(1); n++)
        {
            Console.Write(mas[m, n] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());
double [,] mas = new double[m, n];
FillArrayRandomNumbers(mas);
PrintArray(mas);
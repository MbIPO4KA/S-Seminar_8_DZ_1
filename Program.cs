/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
//=========================================================================================



int rows = 4;
int cols = 4;

// 1. Заполним таблицу.
// Создадим пустую матрицу

int[,] rezultMatrix = GetMatrix(rows,cols,0,10);

/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненнвй двумерный массив целых чисел</returns>

int[,] GetMatrix(int rows, int cols, int min, int max)
{
    // Чтобы создать двумерный массив мы создаём некую матрицу
    int[,] matrix = new int[rows, cols];    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
//===========================================================
/// <summary>
/// Метод печатает матрицу, переданную на вход
/// </summary>
/// <param name="inputMatrix"> Входная матрица</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0);i ++)
    {
            for (int j = 0; j < inputMatrix.GetLength(1);j ++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// 2. Печать матрицы
Console.WriteLine();
Console.WriteLine("Заданный массив : ");
PrintMatrix(rezultMatrix);

//===========================================================

// И остался метод, который меняет местами наши числа



/// <summary>
///Метод, который упорядочит по убыванию  элементы
/// </summary>
/// <param name="matrix">Двумерный массив</param>
/// <returns>Матрица готовая к употреблению</returns>


int[,] ChangeArray(int[,] matrix)
{
   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) // и вот когда уже есть результаты по столбцам
        {
             for (int k = 0; k < cols - 1; k++) 
        {
            if (matrix[i, k] < matrix[i, k + 1]) // сравниваем первое и второе числа в строчке с индексом i
            {                                    // и если первое МЕНЬШЕ, то

                int temp = int.MaxValue; // вводим временную переменную
                temp = matrix[i, k]; // во временную переменную кладём первое значение
                matrix[i, k] = matrix[i, k + 1]; // назначаем первому числлу значение БОЛЬШЕГО числа
                matrix[i, k + 1] = temp; // а в ячейку (условно) 2 кладём значение МЕНЬШЕГО числа
            }
        }
        }
    }
    return matrix ;
}
Console.WriteLine();
Console.WriteLine(" В итоге получается вот такой массив: ");
PrintMatrix(ChangeArray(rezultMatrix));
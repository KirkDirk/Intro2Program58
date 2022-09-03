// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray2DimRandom(int row, int column, int maxEl)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, maxEl);
        }
    }
    return array;
}
void PrintArray2Dim(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int valueMaxElArray = new Random().Next(4, 10);
int rowArray = new Random().Next(4, valueMaxElArray);
int columnArray = new Random().Next(4, valueMaxElArray);
int[,] firstMatrix = CreateArray2DimRandom(rowArray, columnArray, valueMaxElArray);
int[,] secondMatrix = CreateArray2DimRandom(rowArray, columnArray, valueMaxElArray);

Console.WriteLine($"Первая матрица {rowArray}x{columnArray}, значения от 1 до {valueMaxElArray}:");
PrintArray2Dim(firstMatrix);
Console.WriteLine($"Вторая матрица {rowArray}x{columnArray}, значения от 1 до {valueMaxElArray}:");
PrintArray2Dim(secondMatrix);
if (rowArray != columnArray) Console.WriteLine("Матрицы несочетаемы");
else
{
    int[,] multiplicationMatrix = new int[rowArray, columnArray];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            for (int a = 0; a < rowArray; a++)
            {
                multiplicationMatrix[i, j] += firstMatrix[i, a] * secondMatrix[a, j];
            }
        }

    }
    Console.WriteLine("Результат умножения матриц:");
    PrintArray2Dim(multiplicationMatrix);
}
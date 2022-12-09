// Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.

// Выглядит ужасно и работает пока только с квадратными массивами. 


Console.Clear();
Console.WriteLine("Задача62");
Console.WriteLine();
Console.Write("Введите размерность квадратного двумерного массива: ");
int parametr = Convert.ToInt32(Console.ReadLine());

int[,] array62 = new int[parametr, parametr];

CreateSpiralArray4x4(array62, parametr, 0, 1); // Здесь 0 и 1 не совсем красиво, ни привязаны ни к чему. 
Print2DArrayAddNull(array62);


void CreateSpiralArray4x4(int[,] array, int size, int startPos, int startValue)
{

    if (startValue < array.GetLength(0) * array.GetLength(1))
    {
        int currentValue = startValue, row = startPos, column = startPos;

        for (column = startPos; column < size - 1; column++) array[row, column] = currentValue++;

        column = size - 1;

        for (row = startPos; row < size - 1; row++) array[row, column] = currentValue++;

        for (column = size - 1; column > startPos; column--) array[row, column] = currentValue++;

        for (row = size - 1; row > column; row--) array[row, column] = currentValue++;

        row++; column++;

        CreateSpiralArray4x4(array62, size - 1, startPos + 1, currentValue);
    }

    if (array.GetLength(0) % 2 != 0) array[(array.GetLength(0) - 1) / 2, (array.GetLength(1) - 1) / 2] = size *= size;
}


void Print2DArrayAddNull(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0");
                Console.Write($"{array[i, j]} ");
            }

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}
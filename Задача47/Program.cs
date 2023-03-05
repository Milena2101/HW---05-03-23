/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

double [,] array = new double [3, 4];
Random random = new Random();
for ( int m = 0; m < array.GetLength(0); m++)
{
    for ( int n = 0; n < array.GetLength(1); n++)
    {
        array[m, n] = new Random().Next(-99,99) / 10.0;
    }
}

for ( int m = 0; m < array.GetLength(0); m++)
{
    for ( int n = 0; n < array.GetLength(1); n++)
    {
        Console.Write( array[m, n] + " ");
    }
}
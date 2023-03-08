/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив: 
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
*/

Console.Write("Rows: ");
int rows = Convert.ToInt32(Console.ReadLine()) -1;
Console.Write("Colums: ");
int colums = Convert.ToInt32(Console.ReadLine()) -1;
int i = 4;
int y = 3;
Random random = new Random();
int [,] max = new int [i,y];
Console.WriteLine("Array: ");
for (int g = 0; g < max.GetLength(0); g++)
    {
        for (int d = 0; d < max.GetLength(1); d++)
        {
            max[g,d] = random.Next(1,10);
            Console.Write(" {0} ", max[g,d]);
        }
        Console.WriteLine();
    }
    if(rows < 0 | rows > max.GetLength(0) -1 | colums < 0 | colums > max.GetLength(1) -1)
    {
    Console.WriteLine("Такого элемента нет!");
    }
    else Console.WriteLine("Значение элемента {0}", max[rows,colums]);
﻿int row = GetNumber("Введите количество строк массива: "),

    column = GetNumber("Введите количество столбцов массива: ");



int[,] array = new int [row, column];

array = FillArray(array);

PrintTwoDimensionalArray(array);

array = DescendingSort(array);

PrintTwoDimensionalArray(array);


int GetNumber (string userString)

{

    Console.Write(userString);

    return Convert.ToInt32(Console.ReadLine());

}

void PrintTwoDimensionalArray (int[,] array)

{

    Console.WriteLine();

    for (int m = 0; m < array.GetLength(0); m++)

    {

        for (int n = 0; n < array.GetLength(1); n++)

        {

            Console.Write(array[m, n] + " ");

        }

        Console.WriteLine();

    }

    Console.WriteLine();

}

int[,] FillArray (int[,] array)

{

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)

        {

            array [i, j] = random.Next(0, 10); // NextDouble() [0.0; 1.0] * (max - min) + min;

        }

    }

    return array;

}

int[,] DescendingSort (int[,] array)

{

    int buff = 0;

    for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)

        {

            for (int n = 0; n < array.GetLength(1) - 1 - j; n++)

            {

                if (array[i, n] < array[i, n + 1])

                    {

                        buff = array[i, n + 1];

                        array[i, n + 1] = array[i, n];

                        array[i, n] = buff;

                    }

            }

                



        }

    }
    
    return array;

}



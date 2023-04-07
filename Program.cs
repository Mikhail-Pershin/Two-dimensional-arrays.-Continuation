// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2


// Console.Write("Введите количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);

// // ----------------Заполнение массива--------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//   int[,] res = new int[m, n];

//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       res[i, j] = new Random().Next(minValue, maxValue + 1);
//     }
//   }
//   return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]}  ");
//     }
//     Console.WriteLine();
//   }
// }

// void SortArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int t = 0; t < array.GetLength(1) - 1; t++)
//       {
//         if (array[i, t] < array[i, t + 1])
//         {
//           int temp = array[i, t + 1];
//           array[i, t + 1] = array[i, t];
//           array[i, t] = temp;
//         }
//       }
//     }
//   }
// }


// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.Write("Введите количество строк в первом матрице: ");
// int rowsA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов в первом матрице: ");
// int columnsA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество строк во второй матрице (это количество столбцов в первой матрице): ");
// int rowsB = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов во втором матрице (это количество строк в первой матрице): ");
// int columnsB = int.Parse(Console.ReadLine()!);

// int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
// int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(arrayA);                             
// Console.WriteLine();
// PrintArray(arrayB);
// Console.WriteLine();
// Console.WriteLine($"Произведение двух матриц: ");
// PrintArray(MultiplyMatrix(arrayA,arrayB));
// Console.WriteLine();

// // ----------------Заполнение массива--------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//   int[,] res = new int[m, n];

//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       res[i, j] = new Random().Next(minValue, maxValue + 1);
//     }
//   }
//   return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]}  ");
//     }
//     Console.WriteLine();
//   }
// }


// int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
// {
//   int[,] newArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//   for (int i = 0; i < newArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//       for (int k = 0; k < arrayA.GetLength(1); k++)
//       {
//         newArray[i, j] += arrayA[i, k] * arrayB[k, j];
//       }

//     }
//   }
//   return newArray;
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество таблиц в массиве: ");
int tablesNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк в массиве: ");
int rowsNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columnsNumber = int.Parse(Console.ReadLine()!);

int[,,] array3D = GetArray(tablesNumber, columnsNumber, rowsNumber, 0, 100);
Console.WriteLine($"Трехмерный массив: ");
PrintArray(array3D);
Console.WriteLine();

// ----------------Заполнение массива--------------------
int[,,] GetArray(int m, int n, int t, int minValue, int maxValue)
{
  int[,,] result = new int[m, n, t];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {

      for (int k = 0; k < t; k++)
      {
        result[i, j, k] = new Random().Next(minValue, maxValue + 1);
        int element = result[i, j, k];
        int newelement = 0;
        if (newelement == element)
          break;
        if (newelement != element)
          element = newelement;
      }
    }
  }
  return result;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine("Table №" + (i + 1));
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i, j, k]}");
        Console.Write("({0},{1},{2})   ", i, j, k);
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
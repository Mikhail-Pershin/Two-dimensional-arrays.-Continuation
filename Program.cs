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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк в первом матрице: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом матрице: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк во второй матрице (это количество столбцов в первой матрице): ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во втором матрице (это количество строк в первой матрице): ");
int columnsB = int.Parse(Console.ReadLine()!);

int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);
PrintArray(arrayA);                             
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine($"Произведение двух матриц: ");
PrintArray(MultiplyMatrix(arrayA,arrayB));
Console.WriteLine();

// ----------------Заполнение массива--------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] res = new int[m, n];

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      res[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
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


int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
  int[,] newArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        newArray[i, j] += arrayA[i, k] * arrayB[k, j];
      }

    }
  }
  return newArray;
}

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
//3 7 22 2 78] -> 76
double[]arr = new double[4, 7, 8, 1, 9];
double max = 0;
if (arr[0] > max) max = arr[0];
if (arr[1] > max) max = arr[1];
if (arr[2] > max) max = arr[2];
if (arr[3] > max) max = arr[3];
if (arr[4] > max) max = arr[4];

Console.WriteLine(max);

// for(double i = 0; i < array.Length; i++)
// {
//     max = array[i] 
// }


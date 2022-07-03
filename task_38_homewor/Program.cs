// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементом массива.
// //3 7 22 2 78] -> 76
double[] array = new double [4];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]}, ");
    }
 
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
    double sum = max - min;
 Console.WriteLine($"Разность между максимальным и минимальным = {sum}");
        

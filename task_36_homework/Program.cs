// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[]arr = new int[5];
Console.WriteLine("Исходный массив");
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($"{arr[i]}, ");
    if (i % 2 > 0)
    {
    sum = sum + arr [i];
    }
    // else sum = sum + 0;
    
}
Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
  
// string[] strArr = new string[] { "привет", "медвед", "как", "твои", "дела" };
// for (int i = 0; i < strArr.Length; i++)
// {
//     if (i % 2 == 0) 
//         Console.Write(strArr[i] + " ");
// }
// Console.ReadKey();
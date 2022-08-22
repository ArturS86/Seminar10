// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];
Random rand = new Random();
Console.Write("[");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 100);
}
Console.Write(string.Join(", ", arr));
Console.WriteLine("]");

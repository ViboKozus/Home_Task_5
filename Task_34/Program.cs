#pragma warning disable
Console.Clear ();
Console.WriteLine ("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Введите количество ячеек в массиве N = ");

int [] Array;
int N;
int Number = 0;
int.TryParse (Console.ReadLine()!, out N);
Array = new int [N];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);
    Console.WriteLine($"array[{i}] = {Array[i]}\n");
}

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0);
    Number++;
}

Console.WriteLine ($"количество чётных чисел в массиве -> {Number}");



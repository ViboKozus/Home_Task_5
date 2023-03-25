#pragma warning disable
Console.Clear ();
Console.WriteLine ("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите количество ячеек в массиве N = ");


int [] Array;
int N;
int NegSum = 0;
int.TryParse (Console.ReadLine()!, out N);
Array = new int [N];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);
    Console.WriteLine($"array[{i}] = {Array[i]}\n");
    if (i % 2 != 0)
    NegSum = NegSum + Array[i];
}

Console.WriteLine ($"Cумму элементов, стоящих на нечётных позициях. -> {NegSum}");







#pragma warning disable
Console.Clear ();
Console.WriteLine ("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

int q, w, e, r, t;
int max;
int min;
int[] Array;
Array = new int [5];
Console.Write("Введите значение [0] значения элемента = ");
int.TryParse (Console.ReadLine()!, out q);
Array[0] = q;
Console.Write("Введите значение [1] значения элемента = ");
int.TryParse (Console.ReadLine()!, out w);
Array[1] = w;
Console.Write("Введите значение [2] значения элемента = ");
int.TryParse (Console.ReadLine()!, out e);
Array[2] = e;
Console.Write("Введите значение [3] значения элемента = ");
int.TryParse (Console.ReadLine()!, out r);
Array[3] = r;
Console.Write("Введите значение [4] значения элемента = ");
int.TryParse (Console.ReadLine()!, out t);
Array[4] = t;

int diff = 0;
max = Array[0];
min = Array[0];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max)
    max = Array[i];
    else
    {
    min = Array[i];
    }
    diff = max - min;
}
Console.WriteLine($"разницу между максимальным = {max} и минимальным  = {min} элементов массива = {diff}");
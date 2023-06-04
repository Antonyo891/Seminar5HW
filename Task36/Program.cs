// See https://aka.ms/new-console-template for more information
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GetRanArr(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(min, max + 1);
    return result;
}
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int SumOdd(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2) result += array[i];
    return result;
}
Console.Clear();
int size = Enter("Введите размер массива");
int min = Enter("Введите мин значение элемента");
int max = Enter("Введите максим значение элемента");
int[] array = GetRanArr(size, min, max);
System.Console.WriteLine($"{String.Join(" ", array)} сумма элементов на нечетных позициях равна => {SumOdd(array)}");


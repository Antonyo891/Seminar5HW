// See https://aka.ms/new-console-template for more information
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
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
int CointEven(int[] array)
{
    int result = 0;
    foreach (int el in array) result += el % 2 == 0 ? 1 : 0;
    return result;
}
int size = Enter("Введите количество элементов в массиве");
int[] array = GetRanArr(size, 100, 1000);
Console.WriteLine($"{String.Join(" ", array)} четных чисел ==> {CointEven(array)}");

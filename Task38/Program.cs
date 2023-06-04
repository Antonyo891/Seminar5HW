// See https://aka.ms/new-console-template for more information
/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double [] GetRanArrDouble(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++) result[i] = new Random().NextDouble()*100;
    return result;
}
double DifMaxMin(double[] array)
{
    double result = 0, max=array[0], min=array[0];
        foreach (double el in array) if (el>max) max = el;
        else if(el<min) min = el;
       // System.Console.WriteLine($"Max = {max}     min = {min}");
        result = max - min; 
    return result;
}
void PrintAr(double [] array)
{
    for (int i =0; i<array.Length; i++) System.Console.Write($" {array[i]:f2} ");
    System.Console.WriteLine();
}
Console.Clear();
int size = Enter("Введите количество чисел в массиве");
double[] array = GetRanArrDouble(size);
PrintAr(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifMaxMin(array):f2}");

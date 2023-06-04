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
double [] InAr (string array)
{
    string [] Nums = array.Split(" ");
    double [] NumDoub = new double[Nums.Length];
    for (int i = 0; i<Nums.Length; i++) NumDoub[i]=double.Parse(Nums[i]);
    return NumDoub;
}
double DifMaxMin(double[] array)
{
    double result = 0, max=array[0], min=array[0];
        foreach (double el in array) if (el>max) max = el;
        else if(el<min) min = el;
        result = max - min; 
    return result;
}
void PrintAr(double [] array)
{
    for (int i =0; i<array.Length; i++) System.Console.Write($" {array[i]:f2} ");
    System.Console.WriteLine();
}
Console.Clear();
System.Console.WriteLine("Введите массив чисел через пробел");
string Str = Console.ReadLine();
double[] array = InAr(Str);
PrintAr(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifMaxMin(array):f2}");
double [] array2 = GetRanArrDouble(10);
PrintAr(array2);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifMaxMin(array2):f2}");

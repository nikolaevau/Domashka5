// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [10];
Random rand = new Random();
for (int i=0; i < array.Length; i++)

array [i] = rand.Next(1,10);

double max = array[0];
double min = array[0];

for (int i=0; i < array.Length; i++)
{
if (max < array[i])
{
max = array[i];
}
if (min > array[i])
{
min = array[i];
}
}
double diff = max - min;

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"max = {max}, min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");
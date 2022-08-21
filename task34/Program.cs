// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] array = new int [10];

Random rand = new Random();

int sum = 0;


for (int i=0; i < array.Length; i++)
{
array[i] = rand.Next(100,1000);

if (array[i] % 2 ! ==0)
{
sum += 1;
}
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Колличество чётных числе в массиве = {sum}");

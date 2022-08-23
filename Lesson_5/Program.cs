/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int countEvenNumbers = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) countEvenNumbers ++;
}
Console.Write(countEvenNumbers);


// Функции

// Функция заполнения массива случайными трехзначными числами
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

// Функция вывода массива в терминал
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

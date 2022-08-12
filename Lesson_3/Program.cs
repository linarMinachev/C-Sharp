/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int number = ReadInt("Введите пятизначное число: ");
int len = number.ToString().Length;

if (len != 5)
{
    Console.WriteLine($"Число {number} не является пятизначным!");
    return;
}
// Все что выше верно - Работает код
else
{
    int start = 1;
    len = len / 2;
    for (int i = 0; i == len; i++)
    {
        int end = number % 10;
        start = (start * 10);
        if(start == end)
        {
            i++;
        }
        else
        {
            Console.WriteLine($"{number} - Не палиндром");
        }
        // toTern = "result" + "result";
        Console.WriteLine($"{number} - Палиндром");
    }

// int c = 1;
//         for (int i = 0; i == len; i--)
//         {
//             c = c * 10;
//         }

//         int x = (number / c) % 10;
//         int y = 

}


// // Вариант 2. (через строку) - вариант с проверкой на количество символов. 
// // ПЛЮСЫ: *Может проверять не только число*

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
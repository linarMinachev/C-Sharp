/*

Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

void WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            return;
        }

            Console.Write("День, под номером " + a + " - Рабочий");
    } 
}

// int dayNumber = ReadInt("Введите число от 1 до 7: ");
// Console.WriteLine(WorkHoliday(dayNumber));

// bool WorkHoliday(int a)
// {
//     if (a > 0 && a < 8)
//     {
//         if (a == 7 || a == 6)
//         {
//             Console.Write("День, под номером " + a + " - Выходной");
//         }
//         else
//         {
//             Console.Write("День, под номером " + a + " - Рабочий");
//         }
//     } 
// }

// int a = ReadInt("Введите число от 1 до 7: ");

// if (a > 0 && a < 8)
// {
//     if (a == 7 || a == 6)
//     {
//         Console.WriteLine("День, под номером " + a + " - Выходной");
//     }
//     else
//     {
//         Console.WriteLine("День, под номером " + a + " - Рабочий");
//     }
// }
// else
// {
//     Console.Write("Ну что ты за человек? Попросили же от 1 до 7");
// }






// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


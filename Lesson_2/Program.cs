/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;

Console.Write(MakeArray(number, count));

int MakeArray(int a, int b)
{
    if (b > 4)
    {
        int result = result / 10;
        b--;
    }
    else
    {
        while (b < 3)
        {
            Console.WriteLine("третьей цифры нет");
            break;
        }
    }
    return result;
}


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


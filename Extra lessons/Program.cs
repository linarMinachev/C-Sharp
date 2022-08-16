/*
Задача 4. (branch Task_3)
Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому).

Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля
*/

Help();

// string someMsg = ReadInput("Введите кодовое слово: ");
// string acsessCode = "exit";

// while (someMsg != acsessCode)
// {
//     someMsg = ReadInput("Введите кодовое слово: ");
// }


// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

// Функция: Вывод команды для отображения списка команд
void Help()
{
    Console.WriteLine("для вывода списка команд, напишите 'help'");
}


// Функция: Вывод команд для работы с программой
void Commands(string help)
{
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль");
    Console.WriteLine("WriteName – вывести имя после ввода пароля");
    Console.WriteLine("Help – вывести список команд");
    Console.WriteLine("Exit – выход");
}
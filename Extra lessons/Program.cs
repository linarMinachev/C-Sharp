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

string userName = null;
string userPassword = null;

string fromUser = ReadInput("Введите команду: ");

while (fromUser != "exit")
{
    switch (fromUser)
    {
        case "help":
            Commands();
            break;
        case "setname":
            userName = ReadInput("Введите имя: ");
            Console.WriteLine("Пользователь создан!");
            Console.WriteLine();
            fromUser = ReadInput("Введите команду: ");
            break;
        case "setpassword":
            userPassword = ReadInput("Создайте пароль: ");
            Console.WriteLine("Пароль создан!");
            Console.WriteLine();
            fromUser = ReadInput("Введите команду: ");
            break;
        case "showdata":
            string checkPass = ReadInput("Введите пароль: ");
            Console.WriteLine();
            if (checkPass == userPassword)
            {
                if (userName == null)
                {
                    Console.WriteLine("Вы не задали имя");
                    Console.WriteLine("Чтобы задать имя, напишите команду - 'SetName'");
                    Console.WriteLine();
                    fromUser = ReadInput("Введите команду: ");
                }
                else
                {
                    Console.WriteLine($"UserName - {userName}");
                    Console.WriteLine($"UserPassword - {userPassword}");
                    Console.WriteLine();
                    fromUser = ReadInput("Введите команду: ");
                }
            }
            else
            {
                Console.WriteLine("Пароль не верный или пользователь отсутствует");
                Console.WriteLine();
                fromUser = ReadInput("Введите команду: ");
            }
            break;
        default:
            Console.WriteLine($"{fromUser} - Такой команды нет");
            Commands();
            break;
    }
}
Console.WriteLine("Программа завершена!");


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
    return Console.ReadLine().ToLower();
}

// Функция: Вывод команды для отображения списка команд
void Help()
{
    Console.WriteLine("Для вывода списка команд, напишите 'help'");
}


// Функция: Вывод команд для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("СПИСОК КОМАНД:");
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль");
    Console.WriteLine("ShowData – Вывести имя и пароль. (Нужно подтверждение паролем)");
    Console.WriteLine("Help – вывести список команд");
    Console.WriteLine("Exit – выход");
    Console.WriteLine();
    fromUser = ReadInput("Введите команду: ");
}
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


while (fromUser == "exit")
{

}
switch (fromUser)
{
    case "help":
        Commands();
        break;
    case "setName":
        userName = ReadInput("Введите имя: ");
        fromUser = ReadInput("Введите команду: ");
        break;
    case "setPassword":
        userPassword = ReadInput("Создайте пароль: ");
        fromUser = ReadInput("Введите команду: ");
        break;
    case "writeName":
        string checkPass = ReadInput("Введите пароль: ");
        if (checkPass == null)
        {
            if (userName == null)
            {
                Console.WriteLine("Вы не задали имя");
                fromUser = ReadInput("Введите команду: ");
            }
            else
            {
                Console.WriteLine(userName);
                fromUser = ReadInput("Введите команду: ");
            }
        }
        else
        {
            Console.WriteLine("Пароль не верный");
            fromUser = ReadInput("Введите команду: ");
        }
        break;
    case "exit":
        // string userName = ReadInput("Введите имя: ");
        break;


}


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
    Console.WriteLine("Для вывода списка команд, напишите 'help'");
}


// Функция: Вывод команд для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("SetName – Установить имя");
    Console.WriteLine("SetPassword – Установить пароль");
    Console.WriteLine("WriteName – вывести имя после ввода пароля");
    Console.WriteLine("Help – вывести список команд");
    Console.WriteLine("Exit – выход");
    Console.WriteLine();
    fromUser = ReadInput("Введите команду: ");
}
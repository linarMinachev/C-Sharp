<<<<<<< HEAD
﻿/*
    Задача 1. (branch Task_1)
    В переменной string есть секретное сообщение, во второй есть пароль.
    Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.
*/

string secretMessage = "Секретное сообщение";
string password = "PassWord";
int attempts = 3;

Console.WriteLine($"Колличество попыток {attempts}");
string checkPass = ReadInput("Введите пароль: ");


for (int i = 1; i <= attempts; i++)
{
    if (checkPass == password)
    {
        Console.WriteLine($"Пароль верный! {secretMessage}");
        break;
    }
    else if (i == attempts)
    {
        Console.WriteLine("Колличество попыток израсходованно");
        break;
    }
    else
    {
        Console.WriteLine($"Пароль неверный! Осталось попыток: {attempts - i} ");
        checkPass = ReadInput("Введите пароль: ");
    }
}


// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
=======
﻿// Задача 1. (branch Task_1)
// В переменной string есть секретное сообщение, во второй есть пароль.
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

// Задача 2. (branch Task_2)
// Есть программа с бесконечным циклом.
// Когда пользователь вводит exit программа заканчивается

// Задача 4. (branch Task_3)
// Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому).
// Например:
// SetName – Установить имя
// Help – вывести список команд
// SetPassword – Установить пароль
// Exit – выход
// WriteName – вывести имя после ввода пароля
>>>>>>> 396df0b98a5f02d9c5d11bb06d322213b105728c

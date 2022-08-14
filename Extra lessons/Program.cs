/*
    Задача 2.
    Есть программа с бесконечным циклом.
    Когда пользователь вводит exit программа заканчивается
*/

string someMsg = ReadInput("Введите кодовое слово: ");
string acsessCode = "exit";

while (someMsg != acsessCode)
{
    someMsg = ReadInput("Введите кодовое слово: ");
}


// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
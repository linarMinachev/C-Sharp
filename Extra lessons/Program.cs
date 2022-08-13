// Задача 1. (branch Task_1)
// В переменной string есть секретное сообщение, во второй есть пароль.
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string secretMessage = "Секретное сообщение";
string password = "PassWord";

string checkPass = ReadInput("Введите пароль: ");

int i = 1;
int attempts = 3;

while (i < attempts)
{
    if (checkPass == password)
    {
        Console.WriteLine($"Пароль верный! {secretMessage}");
        break;
    }
    else
    {
        Console.WriteLine($"Пароль неверный! Осталось попыток: {attempts - i}");
        checkPass = ReadInput("Введите пароль: ");
        i++;
    }
    Console.WriteLine("Колличество попыток израсходованно");
}



// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToString(Console.ReadLine());
}
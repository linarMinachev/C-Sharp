// // int randomNumber = GetRandomNumber(10, 99);
// // Console.WriteLine(randomNumber);

// // int firstDigit = randomNumber / 10;
// // int secondtDigit = randomNumber % 10;

// // int maxDigit = Max(firstDigit, secondtDigit);
// // Console.WriteLine(maxDigit);

// // int GetRandomNumber(int min, int max)
// // {
// //     return new Random().Next(min, max + 1);
// // }

// int Max(int a, int b)
// {
//     int max = 0;
//     if(a > b)
//     {
//         max = a;
//     }
//     else{
//         max = b;
//     }
//     return max;
// }

Console.WriteLine("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);


// if ()
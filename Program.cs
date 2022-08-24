// Задача 10
// Console.WriteLine("Введите трёхзначное число");
// int num = int.Parse(Console.ReadLine());
// int firstNum = num / 100;
// Console.WriteLine((num - firstNum * 100) / 10);

// Задача 13
// Console.WriteLine("Введитеь число");
// int num = int.Parse(Console.ReadLine());
// int firstNum, secondNum;
// if (num < 100 & num > -100) {Console.WriteLine("третьего числа нет");}
// else
// {
//     int divider = 1000000000;
//     while (true){
//         firstNum = num / divider;
//         if (firstNum != 0) {break;}
//         divider = divider / 10;
//     }
//     secondNum = (num - firstNum * divider) / (divider/10);
//     Console.WriteLine((num - firstNum * divider - secondNum * (divider / 10)) / (divider / 100));
// }

// Задача 15
Console.WriteLine("Введитеь цифру дня недели");
int num = int.Parse(Console.ReadLine());
if (num == 6 | num == 7) {Console.WriteLine("да");}
else {Console.WriteLine("Нет");}
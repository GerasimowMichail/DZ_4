// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Read(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"введенное число {num}");
    return num;
}
int num = Read("Введите число");

//определяем длину числа
int Len(int num)
{
    int i = 1;
    while ((num / 10) > 0)
    {
        num = num / 10;
        i++;
    }
    int lenNum = i;
    return lenNum;
}
Console.WriteLine($"Количество цифр в числе {Len(num)}");

int lenNum = Len(num);
//превращаем  в массив и считаем сумму
int Sum(int lenNum, int num)
{
    int[] arr = new int[lenNum];
    int sum = 0;
    for (int i = 0; i < lenNum; i++)
    {
        arr[i] = num % 10;
        num = num / 10;
        sum = sum + arr[i];
    }
    return sum;
}
Console.WriteLine();
Console.Write($"Сумма цифр в числе {num} = ");
Console.WriteLine(Sum(lenNum, num));




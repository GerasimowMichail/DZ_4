// Задача 25: Напишите цикл, который принимает на вход два 
// 7числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите Число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Число B: ");
int B = Convert.ToInt32(Console.ReadLine());


int arg = 1;
int i = 0;
int Degree(int arg1, int arg2)
{
    while (i < arg2)
    {
        arg = arg * arg1;
        i++;
    }

    return arg;
}

int res = Degree(A, B);

Console.WriteLine($"А в степени В = {res}");

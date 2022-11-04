// Задача 25: Напишите цикл, который принимает на вход два 
// 7числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите Число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число B: ");

int B = Convert.ToInt32(Console.ReadLine());

int arg1=A;
int arg2=B;
int arg=1;
int i=0;
// int Degree(int arg1, int arg2)
// {
    while (i<=arg2)
    {
    arg = arg * arg1;
    i++;
    }

    Console.WriteLine(arg1);
    // return arg1;
// }

// int res = Degree(A, B);
// Console.WriteLine(res);

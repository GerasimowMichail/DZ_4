// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// с клавиатуры и выводит массив на экран.

int [] Read(string message)
{
Console.WriteLine(message);
int [] arr=new int[8];
for (int i=0; i<8; i++ )
{
    arr[i]=Convert.ToInt32(Console.ReadLine());     
}
return arr;
}
int [] mes=Read("Введите 8 элементов");


int [] Print(int [] mes)
{
Console.Write("Введенный массив: ");
for (int i=0; i<8; i++)
{
      Console.Write($"{mes[i]}"+" ");
}
return mes;
}
Print(mes);

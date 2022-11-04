// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
Console.WriteLine("Введите 8 чисел");
int [] arr=new int[8];
for (int i=0; i<8; i++ )
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
     
}
Console.Write("Введенный массив: ");
for (int i=0; i<8; i++)
{
      Console.Write($"{arr[i]}"+" ");
}
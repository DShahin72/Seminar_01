// Составить программу, которая на вход принимает число N и выдает все целые числа от -N до N

System.Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = -N; i <= N; i++)
{
    System.Console.Write(i + " ");
}
// На входе трехзначное число, на выходе - последняя цифра

System.Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>99 && N<1000)
{
    System.Console.WriteLine(N%10);
}
else
{
    System.Console.WriteLine("Вы ввели нетрехзначное число!");
}
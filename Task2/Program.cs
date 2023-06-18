// Является ли первое введенное число квадратом второго
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b*b)
{
    System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    System.Console.WriteLine($"Число {a} не является квадратом числа {b}");
}
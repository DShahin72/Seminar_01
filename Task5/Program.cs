// На входе трехзначное число, на выходе - последняя цифра

System.Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(N%10);
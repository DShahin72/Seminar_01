// Вывести день недели по заданному числу
System.Console.Write("Введите номер дня недели от 1 до 7: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

if (daynumber == 1) 
{
    System.Console.WriteLine("Это понедельник!");
}

else if (daynumber == 2) 
{
    System.Console.WriteLine("Это вторник!");
}
    
else if (daynumber == 3) 
{
    System.Console.WriteLine("Это среда!");
}

else if (daynumber == 4)
{
    System.Console.WriteLine("Это четверг!");
}

else if (daynumber == 5)
{
    System.Console.WriteLine("Это пятница!");
}

else if (daynumber == 6)
{
    System.Console.WriteLine("Это суббота!");
}

else if (daynumber == 7)
{
    System.Console.WriteLine("Это воскресенье!");
}

else
{
    System.Console.WriteLine("Вы ввели неверное число");
}
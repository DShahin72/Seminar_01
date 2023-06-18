// Вывести день недели по заданному числу (второй способ)
System.Console.Write("Введите номер дня недели от 1 до 7: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

switch (daynumber)
{
    case 1:
    {
        System.Console.WriteLine("Это понедельник!");
        break;
    }

    case 2:
    {
        System.Console.WriteLine("Это вторник!");
        break;
    }
    case 3:
    {
        System.Console.WriteLine("Это среда!");
        break;
    }

    case 4:
    {
        System.Console.WriteLine("Это четверг!");
        break;
    }
    case 5:
    {
        System.Console.WriteLine("Это пятница!");
        break;
    }
    case 6:
    {
        System.Console.WriteLine("Это суббота!");
        break;
    }
    case 7:
    {
        System.Console.WriteLine("Это воскресенье!");
        break;
    }
    
    default:
    {
        System.Console.WriteLine("Вы ввели неверный номер");
        break;
    }
}
/*
//Напишите программу, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B (Math.Pow НЕ использовать)


void Task1 (int a, int b) 
{
    int num = 1;
    for (int i = 0; i < b; i++)
    {
        num = a * num;
    }
    Console.WriteLine("Итог "+num);
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

Task1(a, b);
*/
/*
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Task2 (int a)
{
    int num = 0;
   if (a >= 0)  
   {
        while (a > 0)
        
            {
                int i = a % 10;
                num = num + i;
                a = a / 10;
            }
    Console.WriteLine("Сумма чисел :"+num);
    }
    else
    {
        Console.WriteLine("Не работаю с отрицательными числами");
    }
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Task2(a);
*/
/*
//Напишите программу, которая создает массив заданного пользователем размера,
//заполняет массив элементами от 1 до 99 и выводит их на экран.

void Task3 (int n)
{
    int [] mas = new int [n];
    for (int i = 0; i < n; i++) 
    {
        int a = 0;
        Console.WriteLine("Введите "+i+" элемент: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0 & a < 100)
        {
            mas [i] = a;
        }
        else {
            Console.WriteLine("Число не входит в промежуток от 1 до 99");
        }
    }
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(mas [i]);
    }
}

Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

Task3(n);
*/
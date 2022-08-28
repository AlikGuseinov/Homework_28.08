Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Максимальное число " + a);
    Console.WriteLine("Минимальное число " + b);
}    
if(b > a)
{    
    Console.WriteLine("Максимальное число " +a);
    Console.WriteLine("Минимальное число " + b);
}
if(b == a)
    Console.Write("Вы ввели одинмаковые числа, попробуйте ещё раз) ");

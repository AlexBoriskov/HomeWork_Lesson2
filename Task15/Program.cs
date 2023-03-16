Console.Write ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>0 && n<6)
{
    Console.WriteLine ("Рабочие дни");
}
else if (n==6 || n==7) 
{
    Console.WriteLine ("Выходные");
}
else
{
    Console.WriteLine ("Некорректное число");
}
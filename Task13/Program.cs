Console.Write ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100)
{
    Console.WriteLine ("Данное число не имеет 3 цифру!");
}
else
{
    int g = (n/100)%10;
    Console.WriteLine ("Третья цифра в числе = " + g);
}
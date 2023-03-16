Console.Write ("Введите 3-х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>=100 && n<=999)
{
    int g = (n/10)%10;
    Console.Write ("Вторая цифра 3-х значного числа: " + g );
}
else
{
    Console.WriteLine ("Введеное число не 3-х значное");
}
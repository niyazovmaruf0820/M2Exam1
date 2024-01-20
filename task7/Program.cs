int SumDigit(int a)
{
    if (a == 0)
    return 0;
    else
    {
        return a % 10 + SumDigit(a / 10);
    }
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigit(a));

int SumOfDigits(int a)
{
    int s = 0;
    for (int i = a; i > 0; i /= 10)
    {
        s += i % 10; 
    }
    return s;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The sum of the digits of the number {a} is : {SumOfDigits(a)}");

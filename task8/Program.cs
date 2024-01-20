string Repetition(string a, int b)
{
    if (b == 1)
    return a;
    else 
    {
        return a + Repetition(a , b - 1);
    }
}
string a = Console.ReadLine();
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Repetition(a, b));
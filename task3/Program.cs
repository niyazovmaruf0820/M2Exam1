string IsPalindrome(int a)
{
    int s = 0;
    for (int i = a; i > 0; i /= 10)
    {
        s = s * 10 + i % 10;
    }
    if (a == s) return "YES";
    else return "NO";
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(IsPalindrome(a));
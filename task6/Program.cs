void Swap(ref int a, ref int b)
{
    int c = 0;
    c = a;
    a = b;
    b = c;
}
System.Console.WriteLine("x : ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("y : ");
int b = Convert.ToInt32(Console.ReadLine());
Swap(ref a, ref b);
System.Console.WriteLine("x = " + a);
System.Console.WriteLine("y = " + b);
void IncrementArrayElements(ref int[] arr, ref int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += n;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int n = Convert.ToInt32(Console.ReadLine());
IncrementArrayElements(ref arr,ref n);
System.Console.Write("[");
for (int i = 0; i < a; i++)
{
    System.Console.Write(arr[i] + " ");
}
System.Console.Write("]");
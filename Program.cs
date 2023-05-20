// See https://aka.ms/new-console-template for more information
int m, sum = 0;
Console.WriteLine("Hello User!");
Console.Write("Please Enter a Number : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 0)
{
    m = n % 10;
    sum = sum + m;
    n = n / 10;
}
Console.WriteLine("Sum of the digits of the given number is : " + sum);

int Factorial(int n)
{
    int result = 1;
    if(n == 0)
    {
        return result;
    }
    else
    {
        return result = n * Factorial(n-1);
    }
}

int number = 5;
Console.WriteLine(Factorial(number));
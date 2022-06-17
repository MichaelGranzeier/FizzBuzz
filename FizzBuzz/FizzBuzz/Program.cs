// FizzBuzz

Console.WriteLine("FizzBuss");


int count = 1;

while (count <= 100)
{
    int rem = count % 3;
    int remTwo = count % 5;

    if (rem == 0 && remTwo == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (rem == 0 && remTwo != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (remTwo == 0 && rem != 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(count);
    }

    count++;
}
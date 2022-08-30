using FindPrimes;
string goAgain = string.Empty;

do
{
    Dictionary<int, int> primes = new Dictionary<int, int>();
    int count = 0;

    Console.WriteLine("Enter a number to go up to! ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter which number prime you want to see! ");
    int primeNum = int.Parse(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        if (PrimeNumber.IsPrime(i))
        {
            count++;
            primes.Add(count, i);
        }
    }

    Console.WriteLine(primes[primeNum]);

    Console.Write("\nDo you want to go again? (y/n): ");
    goAgain = Console.ReadLine().ToLower();
} while (goAgain[0] == 'y');

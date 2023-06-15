for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
        continue; // Ignora a iteração atual se o número for par
    
    Console.WriteLine(i);
}
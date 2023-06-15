int[] numbers = new int[10]; 
int contador = 0;  

Console.WriteLine("Digite 10 números abaixo:");  

for (int i = 0; i < numbers.Length; i++) 
{   
  numbers[i] = int.Parse(Console.ReadLine()); 
}  

foreach (int number in numbers) 
{   
  if (number % 2 != 0)   
  {     
    Console.Write($"{number}, ");    
    contador++;   
  }
}  

Console.WriteLine($"Total de números ímpares: {contador}");
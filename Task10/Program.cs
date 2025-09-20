List<int> numbers = new List<int>();
Random rand = new Random();
for (int i = 0; i < 10; i++)
        {
            int randomNumber = rand.Next(1, 20); 
            numbers.Add(randomNumber);
        }
Console.WriteLine("Random numbers in the list:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
           
       }
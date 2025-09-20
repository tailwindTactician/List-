List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
List<int> evenNumber = numbers.FindAll(a => a % 2 == 0);
System.Console.WriteLine("The filtered number are: ");
foreach (int number in evenNumber)
{
    System.Console.WriteLine(number);
}
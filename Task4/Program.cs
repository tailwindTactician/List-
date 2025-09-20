List<double> numbers = new List<double> { 3.2, 2.7, 6.9, 1.2 };
double sum = 0;
foreach (double number in numbers)
{
    sum += number;
}
double a = sum / numbers.Count;
Console.WriteLine("The average value of all the elements in the list is: " + a);
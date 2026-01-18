// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
foreach (var number in numbers.Where(n => n % 2 == 0))
{
    Console.WriteLine(number);
}

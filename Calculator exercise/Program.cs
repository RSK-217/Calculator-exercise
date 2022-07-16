
List<string> numbers = new() { "1", "2", "3" };

List<int> newNumbers = numbers.ConvertAll<int>(Convert.ToInt32);

foreach (int number in newNumbers)
{
    Console.WriteLine(number);
}

//int product = 1;

//foreach(int number in newNumbers)
//{
//    product *= number;
//}

//Console.WriteLine(product);

Console.WriteLine("Would you like to multiply or square the numbers?");

string option;

option = Console.ReadLine();

if (option == "multiply")
{
    foreach (int number in newNumbers)
    {
        int result = number * number;
        Console.WriteLine(result);
    }
}
else if (option == "square")
{
    foreach (int number in newNumbers)
    {
        int result2 = number * 2;
        Console.WriteLine(result2);
    }
}
else
{
    Console.WriteLine("That is not a valid option");

}

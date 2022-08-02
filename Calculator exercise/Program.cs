List<string> numbers = new() { "4", "2", "1" };

List<double> newNumbers = numbers.ConvertAll<double>(Convert.ToDouble);

Console.WriteLine(String.Join(", ", newNumbers));

Console.WriteLine();

Console.WriteLine("Which operation would you like to perform?");

Console.WriteLine(@"* (multiply)
/ (divide)
+ (add)
- (subtract)
^2 (square)
avg (average)");

Console.WriteLine();

string option;

option = Console.ReadLine();

int result = 0;

switch (option)
{
    case "*":
        result = (int)(newNumbers[0] * newNumbers[1] * newNumbers[2]);
        Console.WriteLine(result);
        break;
    case "/":
        result = (int)(newNumbers[0] / newNumbers[1] / newNumbers[2]);
        Console.WriteLine(result);
        break;
    case "+":
        result = (int)(newNumbers[0] + newNumbers[1] + newNumbers[2]);
        Console.WriteLine(result);
        break;
    case "-":
        result = (int)(newNumbers[0] - newNumbers[1] - newNumbers[2]);
        Console.WriteLine(result);
        break;
    case "avg":
        result = (int)(newNumbers[0] + newNumbers[1] + newNumbers[2] / newNumbers.Count);
        Console.WriteLine(result);
        break;
    case "^2":
        foreach (int number in newNumbers) { result = number * 2; Console.WriteLine(result); }
        break;
    default:
        Console.WriteLine("Not a valid option");
        break;

}

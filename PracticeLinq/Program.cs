using System.Linq;

List<string> myList = new List<string>() { "God Of War", "Diablo", "Counter Strike"};




var newVar = myList.OrderByDescending(s => s.Length).ToArray();

foreach (var item in newVar)
{
    Console.WriteLine(item);
}
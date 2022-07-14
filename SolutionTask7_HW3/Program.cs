Console.WriteLine("Введите число.");
string? inputLkneOne = Console.ReadLine();

if (inputLkneOne != null )
{
    int inputNumberOne = int.Parse(inputLkneOne);
      
    if (inputNumberOne % 2 == 0)
    Console.WriteLine("Число четное");
    
    else
    Console.WriteLine("Число нечетное");
}
    





string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();
string? inputLkneThree = Console.ReadLine();

if (inputLkneOne != null && inputLkneTwo != null && inputLkneThree != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);
    int inputNumberThree = int.Parse(inputLkneThree);


    if (inputNumberOne > inputNumberTwo)
    {
        if (inputNumberOne > inputNumberThree)
            Console.WriteLine(inputNumberOne);

        else
            Console.WriteLine(inputNumberThree);
    }
    else
    {
        if (inputNumberTwo > inputNumberThree)
            Console.WriteLine(inputNumberTwo);

        else
            Console.WriteLine(inputNumberThree);
    }
}



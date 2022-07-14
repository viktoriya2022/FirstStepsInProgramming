// string? inputLkneOne = Console.ReadLine();

// if(inputLkneOne != null)
// {
//    int inputNumber = int.Parse(inputLkneOne);
//    int startNumber =  2;
//    string lineOutput = "";
//    while (startNumber < inputNumber)
//    {
//     lineOutput = lineOutput + startNumber +", ";
//     startNumber = startNumber + 2;
//    }
    
//    Console.WriteLine(lineOutput);
// }


string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{
   int inputNumber = int.Parse(inputLkneOne);
   int startNumber =  2;
   string lineOutput = "";
   while (startNumber <= inputNumber - 2)
   {
    lineOutput = lineOutput + startNumber +", ";
    startNumber = startNumber + 2;
   }
   lineOutput = lineOutput + startNumber;
   Console.WriteLine(lineOutput);
}
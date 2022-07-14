string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{
   int inputNumber = int.Parse(inputLkneOne);
   int startNumber =  2;
   string lineOutput = "";
   while (startNumber < inputNumber)
   {
    lineOutput = lineOutput + startNumber +", ";
    startNumber = startNumber + 2;
   }
    
   Console.WriteLine(lineOutput);
}

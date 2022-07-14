// string? inputLkneOne = Console.ReadLine();

// if(inputLkneOne != null)
// {
//    int inputNumber = int.Parse(inputLkneOne);
//    int startNumber =  (inputNumber * -1);
//    string lineOutput = "";
//    while (startNumber < inputNumber)
//    {
//     lineOutput = lineOutput + startNumber +", ";
//     startNumber++;
//    }
//     lineOutput = lineOutput + inputNumber;
//    Console.WriteLine(lineOutput);
// }
string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{
   int inputNumber = int.Parse(inputLkneOne);
   int startNumber =  1;
   string lineOutput = "0";
   while (startNumber <= inputNumber)
   {
    lineOutput = startNumber*(-1)+", " +lineOutput+", "+ startNumber;
    startNumber++;
   }
  
   Console.WriteLine(lineOutput);
}
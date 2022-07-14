string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo !=null)
{
  int inputNumberOne = int.Parse(inputLkneOne);
  int inputNumberTwo = int.Parse(inputLkneTwo);
 if(inputNumberOne > inputNumberTwo)
       {
           Console.WriteLine(inputNumberOne);
       }
 else
       {
           Console.WriteLine(inputNumberTwo);
       }
}

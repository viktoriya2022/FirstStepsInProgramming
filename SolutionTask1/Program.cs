string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo !=null)
{
  int inputNumberOne = int.Parse(inputLkneOne);
  int inputNumberTwo = int.Parse(inputLkneTwo);
//  if(inputNumberOne == inputNumberTwo * inputNumberTwo)
 //       {
 //           Console.WriteLine("Yes");
 //       }
 //      else
 //       {
 //           Console.WriteLine("No");
//        }
//}
    if(inputNumberTwo == Math.Sqrt(inputNumberOne))
        {
            Console.WriteLine("Yes");
        }
       else
        {
            Console.WriteLine("No");
        }
}        

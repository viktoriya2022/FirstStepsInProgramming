Console.WriteLine("Enter number");
//Считываем строковую переменную
string? inputLkneOne = Console.ReadLine(); 
//преобразуем в массив
char[] inputLkneTwo = inputLkneOne.ToCharArray(); 

if (inputLkneOne != null)
{
    if (inputLkneTwo.Length >= 3)
    {
        //выводим третью цифру
        Console.WriteLine("the third digit is " + inputLkneTwo[2]); 
    }
    else
    {
        Console.WriteLine("No third digit");
    }
}

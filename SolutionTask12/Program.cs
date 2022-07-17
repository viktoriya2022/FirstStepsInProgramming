// //Николай
// string? inputLkneOne = Console.ReadLine();
// string? inputLkneTwo = Console.ReadLine();

// if(inputLkneOne != null && inputLkneTwo != null){
// int inputNumberOne = int.Parse(inputLkneOne);
// int inputNumberTwo = int.Parse(inputLkneTwo);

// int div = inputNumberOne%inputNumberTwo;

// if(div == 0)
// {
// Console.WriteLine("yes");
// }
// else
// {
// Console.WriteLine(div);
// }

// }


//Артем Малистов: 
// Console.Write("Enter first number: ");
// string? firstLine = Console.ReadLine();
// Console.Write("Enter second number: ");
// string? secondLine = Console.ReadLine();
// int first = int.Parse(firstLine);
// int second = int.Parse(secondLine);

// if (second%first == 0)
// {
// Console.WriteLine("Кратное");
// }
// else
// {
// Console.WriteLine("Не кратное, " + second%first);
// }

//Ирина Олондарь: 
Console.WriteLine("введите первое число:");
string? firstNumber = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null) {
int firstOutNumber = int.Parse(firstNumber);
int secondOutNumber = int.Parse(secondNumber);
int c = secondOutNumber%firstOutNumber;
string iext = "";

if (c == 0) {
iext = "да, второе число кратно первому";
Console.WriteLine(iext);
} else {
iext = "нет, второе число не кратно первому, остаток: " + c;
Console.WriteLine(iext);
}
}
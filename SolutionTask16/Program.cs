//Никина
Console.Clear();

Console.WriteLine("Введите первое число:");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputSecond = Console.ReadLine();

if ((inputFirst != null) && (inputSecond != null))
{
int inputNumberFirst = int.Parse(inputFirst);
int inputNumberSecond = int.Parse(inputSecond);
int a = inputNumberFirst * inputNumberFirst;
int b = inputNumberSecond * inputNumberSecond;
if ((a == inputNumberSecond) || (b == inputNumberFirst))
{
Console.WriteLine("Да!");
}
else
{
Console.WriteLine("Нет!");
}

}

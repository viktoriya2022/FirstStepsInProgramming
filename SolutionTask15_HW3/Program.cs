Console.WriteLine("Введите число от одного до семи.");

int inputLkneOne = int.Parse(Console.ReadLine());

if (inputLkneOne != null)
{
    if (inputLkneOne == 6 || inputLkneOne == 7)
    {
        Console.WriteLine("Ура! Выходной!");
    }
    else
    {
        if (inputLkneOne > 7)
        {
            Console.WriteLine("Введено число больше семи.");
        }
        else
        {
            Console.WriteLine("Это рабочий день.");
        }
    }
}


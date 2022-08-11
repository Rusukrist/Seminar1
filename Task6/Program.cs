Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int remain = Number % 2;
if (remain == 0)
{    Console.WriteLine(" Число " + Number + " является чётным?");
    Console.WriteLine("Да, число " + Number + " является  чётным!");
}
else
{    Console.WriteLine(" Число " + Number + " является чётным?");
    Console.WriteLine("Нет, число " + Number + " не является чётным!");
}

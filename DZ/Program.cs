int FirstDigit()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    int des = rand % 100 / 10;
       return des;
}

int seredina = FirstDigit();
Console.WriteLine("Srednyy cifra =" + seredina);
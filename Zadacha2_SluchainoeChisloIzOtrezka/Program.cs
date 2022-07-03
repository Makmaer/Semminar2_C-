
int FindBiggerDigit()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    int sot = rand / 10;
    int dec = rand %100 / 10;
    int ed = rand % 100 %10;
    int result = sot - dec + ed;
    return result;
}

int maxNum = FindBiggerDigit();
Console.WriteLine("Itog" + maxNum);
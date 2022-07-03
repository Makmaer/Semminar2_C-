
int FindBiggerDigit()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    int dec = rand / 10;
    int ed = rand % 10;
    if(dec > ed) return dec;
    else return ed;
}

int maxNum = FindBiggerDigit();
Console.WriteLine("Bolshaya cifra =" + maxNum);
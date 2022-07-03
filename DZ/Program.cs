/*int FirstDigit()  //Выводим среднюю цифру числа
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    int des = rand % 100 / 10;
       return des;
}

int seredina = FirstDigit();
Console.WriteLine("Srednyy cifra =" + seredina);*/

int TretyCifra(int n)  // Выводим третью цифру произвольного числа
{
    int digitCount = (int)Math.Log10(n) + 1;
    int a = digitCount-3;
    int b = Convert.ToInt32(Math.Pow(10, a));
    int c = n / b;

    int rezult = c % 10;                 
return rezult;
}
Console.Write("Введите число не более 10 знаков  " );
int num = Convert.ToInt32(Console.ReadLine());
if(num<100) {Console.Write("Цифр меньше трех!  " );}
else Console.WriteLine("Третья цифра в числе =" + TretyCifra(num));

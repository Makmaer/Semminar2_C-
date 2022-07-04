

// ЗАДАЧА 10
/*int FirstDigit()  //Выводим среднюю цифру числа
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    int des = rand % 100 / 10;
       return des;
}

int seredina = FirstDigit();
Console.WriteLine("Srednyy cifra =" + seredina);*/



// ЗАДАЧА 13
/*int TretyCifra(int n)  // Выводим третью цифру произвольного числа
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
else Console.WriteLine("Третья цифра в числе =" + TretyCifra(num)); */


// ЗАДАЧА 15
void TretyCifra(int n)  // По введенной цифре, соответствующей дню недели, определяем выходной день илил нет.
{
    
        if(n == 1 || n == 2 || n == 3 || n == 4 || n == 5 )
    {Console.Write("Это рабочий день  " );}
    else if(n == 6 || n == 7 )
    {Console.Write("Это выходной день  " );}
    else {Console.Write("Нет дня недели, соответствующего данной цифре  " );}
                 
}

Console.WriteLine("1 - Понедельник  " );
Console.WriteLine("2 - Вторник  " );
Console.WriteLine("3 - Среда  " );
Console.WriteLine("4 - Четверг  " );
Console.WriteLine("5 - Пятница  " );
Console.WriteLine("6 - Суббота  " );
Console.WriteLine("7 - Воскресение  " );
Console.WriteLine("0 - ВЫХОД  " );
Console.Write("Введите цифру от 1 до 7, соответствующую дню недели:  " ); 
int num = Convert.ToInt32(Console.ReadLine());
TretyCifra(num);

void FindBigger(int n1, int n2)
{
    if (n2 % n1 == 0)
{
    Console.WriteLine("Wtoroe kratno pervomu ");
}
else {
    int ost = n2 % n1;
    Console.WriteLine("Ostatok ot delenia " + " " + ost );

}
    }
int namb1=3;
int namb2=63;

FindBigger(namb1, namb2);

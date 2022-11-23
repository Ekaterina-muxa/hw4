
void main (int num)
{
    
    int sot = num % 100;
    if (sot > 10)
    {
       Console.WriteLine("третьей цифры нет");
      // int ed = num % 10;
      // Console.WriteLine(ed);
    }
    else
     {
       int ed = num % 10;
       Console.WriteLine(ed);
       // Console.WriteLine("третьей цифры нет");
    }
}
main (385);

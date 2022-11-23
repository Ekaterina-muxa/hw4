int FindNum(int num)
{
    int sot = num % 100;
    int ost = sot / 10;
    
    return ost;
}
int random = new Random().Next(100,1000);
int newNumber = FindNum(random);
Console.WriteLine($"new version of {random} is {newNumber}");



//Task 19
void CheckForPali()
{
    Console.WriteLine("Hello, eneter palindrome number");
    int number = int.Parse(Console.ReadLine());
    if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
        {
         Console.WriteLine("Number is palindrome");  
        }
    else{
        Console.WriteLine("Number is not palindrome");
    }
}


//Task 21
void CorFind()
{
   Console.WriteLine("Find distance between two points in 3d realm");
Console.WriteLine("Enter coordinate x of point A");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate y of point A");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate z of point A");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate x of point B");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate y of point B");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate z of point B");
double z2 = double.Parse(Console.ReadLine());
double distance = 0;
distance = Math.Round(Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(y2-y1,2))+(Math.Pow(z2-z1,2))),2);
Console.WriteLine($"Distance between points A and B is {distance}");
}

//Task 23

void CubeNumber()
{
Console.WriteLine("Enter number till wich triplets will be given");
    int num = int.Parse(Console.ReadLine());
    int startnum = 1;
    double finalnumber = 0;
    while (startnum<num+1)
    {
    finalnumber = Math.Pow(startnum,3);
    Console.WriteLine(finalnumber);
    startnum ++;
    }
}
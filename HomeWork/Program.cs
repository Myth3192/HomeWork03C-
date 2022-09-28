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


//Task
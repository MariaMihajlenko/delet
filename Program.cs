using System;
class LengthDemo {

public static void Main()
 {   
Console.WriteLine("Введите трехзначное число:  ");
int numbers = Convert.ToInt32(Console.ReadLine());
char[]arr = numbers.ToString().ToCharArray();
var n = arr[1];
Console.WriteLine(n);

    }
}


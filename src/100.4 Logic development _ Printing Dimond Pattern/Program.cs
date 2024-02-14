/*
     . . .  بِسْمِ ٱللَّٰهِ  . . .
     In The Name Of Allah   
     author    :   Muhammad
     created   :   30/12/2022 01:14:17 AM

if n = 3 :

    *
   * *
  * * *
   * *
    *
    
---------------------------------*/

//var n = int.Parse(Console.ReadLine()!); 

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= n - i; j++)
//        Console.Write(" ");
//    for (int j = 1; j <= i; j++)
//        Console.Write("* ");

//    Console.WriteLine();
//}
//for (int i = 1; i <= n - 1; i++)
//{
//    for (int j = 1; j <= i; j++)
//        Console.Write(" ");
//    for (int j = 1; j <= n - i; j++)
//        Console.Write("* ");

//    Console.WriteLine();
//}






/*

if n = 3 :

  *
 ***
*****
 ***
  *

-----------------------*/
var n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i * 2 - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


for (int i = 1; i <= n-1; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= ((n-1)*2)-((i*2)-1) ; j++)
    {
        Console.Write("*"); 
    } 
    Console.WriteLine();
}

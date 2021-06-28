using System;

class MainClass {
  public static void Main (string[] args) {

    //calculation variables
    int x;
    int y = 0;

    //input statement request for a number
    Console.WriteLine("Enter a number");
    int n = Convert.ToInt32(Console.ReadLine());

    //for loop statement to calculate factors    
    for(x=1; x <= n; x++)

      //calculating remainder in increments of 1
      if (n % x ==  0)
      {
      y++;
      }
      //calculating results of two possible factors
      if (y == 2)
      {
      Console.WriteLine("The number is Prime");         
      }

      else
      {
      Console.WriteLine("The number is not Prime");
      }
    
  }
}
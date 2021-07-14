using System;

class MainClass {

public static int IntegerPower(int num1, int num2) 
  {
    
    int value1 = 1;
    int x=0;
    int flag =0;
    //value1 = Math.Pow(num1, num2);
    while(x < num2){
    value1 *= num1;
      x++;
    }
    return value1;
  }
  

  public static void Main (string[] args) {
    int num1 = 0;
   int num2 = 0;
  int result;


    Console.WriteLine ("enter base number");
    var x  = Console.ReadLine();
    num1 = Convert.ToInt32(x);
    Console.WriteLine("enter exponent");
    var y = Console.ReadLine();
    num2  = Convert.ToInt32(y);
    result = IntegerPower(num1, num2);
    Console.WriteLine(result);
  }
}
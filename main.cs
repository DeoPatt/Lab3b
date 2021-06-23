using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine("Enter salesperson name");
   var name = Console.ReadLine();
  Console.WriteLine("Enter sales amount");
  double salesAmount = Convert.ToDouble(Console.ReadLine());

 var salescommission = 200 + (0.09 * salesAmount);
 Console.WriteLine("Sales commission for " + name + " is $" + salescommission);
 string Performance = "";
 if (salesAmount >= 15000 )
 {

  Performance = "Outstanding";
 }
 else if (salesAmount >= 10000 && salesAmount <= 14999)
 {
   
   
  Performance = "Execellent";
 }
 else if (salesAmount >= 5000 && salesAmount <= 9999)
 {
   
   Performance = "Good";
 }
else if (salesAmount >= 3000 && salesAmount <= 4999)
  {
   
    Performance = "Average";
  }
  else if (salesAmount <= 0 && salesAmount >= 2999)
  {
    
    Performance = "Poor";
  } 
 Console.WriteLine("Performance is " + Performance);

 }
  }

  
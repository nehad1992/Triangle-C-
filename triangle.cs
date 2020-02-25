using System;
using System.Collections.Generic;

public class Triangle
{
  public int side1;
  public int side2;
  public int side3;

  
}
public class Program
{
  public static void Main(){
    Triangle myTrinagle = new Triangle();
    Console.WriteLine("Enter side one of triangle");
    myTrinagle.side1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side two of triangle");
    myTrinagle.side2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side three of triangle");
    myTrinagle.side3 = int.Parse(Console.ReadLine());
    int side1 = myTrinagle.side1;
    int side2 = myTrinagle.side2;
    int side3 = myTrinagle.side3;

    if((side1>=(side2+side3)) || (side2>=(side1+side3)) || (side3>=(side1+side2))){
      Console.WriteLine("Not a triangle");
    }else if( side1 == side2 && side1 == side3){
      Console.WriteLine("Equilateral Triangle");
    }else if(side1 == side2 || side1 == side3 || side2 ==side3 ){
      Console.WriteLine("Isosceles Triangle");
    } else if(side1!=side2 && side1!=side3 && side2!=side3){
      Console.WriteLine("Scalene Triangle");
    }
  }
}
using System;

namespace RactangleApplication{
    public class Rectangle{

        public double length;
        public double width;


        public Rectangle(){
           
        }

        public void AccceptDetails(){
            length=4.5;
            width=4.5;

        }

        public double GetArea()
        {
            return length*width;
        }
        public double Total()
        {
           return length+width;
        }  
          public static double RTotal(double length, double width)
        {
            return length * width;
        }   
        
          public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
         Console.WriteLine("Area:{0}",Total());
         Console.WriteLine("Area:{0}",RTotal(10,5.5));
      }
    }
}
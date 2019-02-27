using System;
namespace AbstractionMedium
{
  public abstract class CalculateArea
    {
        public void  Area(int length,int breadth) {

                area = length * breadth;
                Console.WriteLine(area);
            
        }
        private int area;
    
    }

}

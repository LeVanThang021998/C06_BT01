using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_BT01
{
    class Rectangle
    {               
         private double length;
         private double width;
            
         public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setlength( double length)
        {
            this.length = length;
        }
        public double getlength()
        {
            return length;
        }
        public double setwidth()
        {
            return width;
        }  
        public double getwidth()
        {
            return width;
        }

        public double findarea()
        {
            return length * width;
        }
        public double findperimter()
        {
            return (length+width) * 2;
        }                                
    }
    class program
    {    
    static void Main(string[] args)
        {
        Rectangle r1;
        Rectangle r2;
        r1 = new Rectangle();
        Console.Write("Cho biết chiều dài: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Cho biết chiều rộng: ");
        double width = double.Parse(Console.ReadLine());
        r1 = new Rectangle(length, width);
        Console.WriteLine("-----Thông tin hình chữ nhật r1-----");
        Console.WriteLine("Chieu dai: {0}\n chieu rong: {1}\n Dien tích: {2}\n Chu vi: {3}",
                r1.getlength(), r1.getwidth(), r1.findarea(), r1.findperimter());

        r2 = new Rectangle(length, width);
        Console.WriteLine("-----Thông tin hình chữ nhật r2-----");
        Console.WriteLine("Chieu dai: {0}\n chieu rong: {1}\n Dien tích: {2}\n Chu vi: {3}",
                r2.getlength(), r2.getwidth(), r2.findarea(), r2.findperimter());
            Console.ReadLine();


        }
    }
}

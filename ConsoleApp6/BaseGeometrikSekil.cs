using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class BaseGeometrikSekil
    {
        public int width { get; set; }
        public int height { get; set; }

        public virtual int AreaCalculate()
        {
            int sonuc = width * height;
            return sonuc;
            Console.WriteLine("Area is : "+sonuc);
        }
       
    }
    public class Square : BaseGeometrikSekil
    {
        public override int AreaCalculate()
        {
            return width * height;
        }
    }
    public class Rectangle : BaseGeometrikSekil
    {
        public override int AreaCalculate()
        {
            return width * height;
        }

    }
    public class RightTriangle : BaseGeometrikSekil
    {
        public override int AreaCalculate()
        {
            return (width * height) / 2;
        }
    }
}


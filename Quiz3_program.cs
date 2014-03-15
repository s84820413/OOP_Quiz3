Quiz3_program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();

            while (true)
            {
                Console.WriteLine("請輸入第一點的X座標");
                tri.Point1_X = double.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第一點的Y座標");
                tri.Point1_Y = double.Parse(Console.ReadLine());

                Console.WriteLine("請輸入第二點的X座標");
                tri.Point2_X = double.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第二點的Y座標");
                tri.Point2_Y = double.Parse(Console.ReadLine());

                Console.WriteLine("請輸入第三點的X座標");
                tri.Point3_X = double.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第三點的Y座標");
                tri.Point3_Y = double.Parse(Console.ReadLine());

                if (itri.isValid())
                {
                    Console.WriteLine("這三點不能組成三角形");
                    Console.WriteLine("請重新輸入!!");
                    continue;
                }

                Console.WriteLine("三角形周長為{0}", tri.Perimeter());
                Console.WriteLine("三角形面積為{0}", tri.Area());
                Console.WriteLine("三角形外接圓半徑為{0}", tri.RadiusOfCircumcircle());

                if (tri.isRight())
                    Console.WriteLine("是直角三角形");
                else
                    Console.WriteLine("不是直角三角形");


                Console.WriteLine("是否繼續?");
                char select = Convert.ToChar(Console.ReadLine());
                if (('y' != select) && ('Y') != select)//忘記如何修改
                {
                    break;
                }
            }
            Console.WriteLine("程式結束!!");
            Console.Read();

        }
    }
}


using System;

namespace midd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter length: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle(l, w);

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Case 1 get length");
                Console.WriteLine("Case 2 set length");
                Console.WriteLine("Case 3 get width");
                Console.WriteLine("Case 4 set length");
                Console.WriteLine("Case 5 get parameter");
                Console.WriteLine("Case 6 get area");
                Console.WriteLine("Case 7 exit");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine("Length = "+r.GetLength());
                        break;
                    case 2:
                        Console.WriteLine("Enter new length:");
                        r.SetLength(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Width = "+r.GetWidth());
                        break;
                    case 4:
                        Console.WriteLine("Enter new width");
                        r.SetWidth(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("Perimeter = "+r.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area = "+r.GetArea());
                        break;
                    case 7:
                        return;
                    default:
                        break;
                }

            }
        }
    }
}

using System;

namespace BoxContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is BoxContainer");
            var box = new Box(10);
            Console.WriteLine($"We have the box. Its volume is {box.Volume()}");
            var cylinder = new Cylinder(10, 2);
            Console.WriteLine($"We have the cylinder. Its volume is {cylinder.Volume()}");
            var pyramid = new Pyramid(20, 2);
            Console.WriteLine($"We have the pyramid. Its volume is {pyramid.Volume()}");
            var ball = new Ball(2);
            Console.WriteLine($"We have the ball. Its volume is {ball.Volume()}");


            while(true)
            {
                int index;
                Console.WriteLine("Choose the figure to add into the box: 1 - cylinder, 2 - pyramid, 3 - ball");
                while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > 3)
                {
                    Console.WriteLine("Choose the figure to add into the box: 1 - cylinder, 2 - pyramid, 3 - ball");
                }
                bool available = true;
                switch (index)
                {
                    case 1:
                        available = box.Add(cylinder);
                        break;
                    case 2:
                        available = box.Add(pyramid);
                        break;
                    case 3:
                        available = box.Add(ball);
                        break;
                }

                if (available)
                    Console.WriteLine($"Figure is added sucssefully. Remained volume of the box is {box.RemainedVolume}");
                else
                    Console.WriteLine($"Figure NOT added. Remained volume of the box is {box.RemainedVolume}");
            }

        }
    }
}

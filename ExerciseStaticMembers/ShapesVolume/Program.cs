using System;

namespace ShapesVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    string[] result = input.Split(" ");
                    switch (result[0])
                    {
                        case "TrianglePrism":
                            VolumeCalculator.TriangularPrismVolume(new TriangularPrism(Convert.ToDouble(result[1]), Convert.ToDouble(result[2]), Convert.ToDouble(result[3])));
                            break;
                        case "Cylinder":
                            VolumeCalculator.CylinderVolume(new Cylinder(Convert.ToDouble(result[1]), Convert.ToDouble(result[2])));
                            break;
                        case "Cube":
                            VolumeCalculator.CubeVolume(new Cube(Convert.ToDouble(result[1])));
                            break;
                    }
                }
            }
        }
    }

    class TriangularPrism
    {
        double baseSide;
        double height;
        double length;
        public double BaseSide { get => baseSide; }
        public double Height { get => height; }
        public double Length { get => length;}

        public TriangularPrism(double baseSide, double height, double length)
        {
            this.baseSide = baseSide;
            this.height = height;
            this.length = length;
        }
    }

    class Cube
    {
        double sideLength;
        public double SideLength { get => sideLength;}

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }
    }

    class Cylinder
    {
        double radius;
        double height;
        public double Height { get => height;}
        public double Radius { get => radius;}

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
    }

    class VolumeCalculator
    {
        public static void TriangularPrismVolume(TriangularPrism triangularPrism)
        {
            double volume = (triangularPrism.Height * triangularPrism.Length * triangularPrism.BaseSide) / 2;
            Console.WriteLine(volume.ToString("n3"));
        }

        public static void CubeVolume(Cube cube)
        {
            double volume = Math.Pow(cube.SideLength, 3);
            Console.WriteLine(volume.ToString("n3"));
        }

        public static void CylinderVolume(Cylinder cylinder)
        {
            double volume = Math.Pow(cylinder.Radius, 2) * 3.14159 * cylinder.Height;
            Console.WriteLine(volume.ToString("n3"));
        }
    }
}

/*
Shapes Volume
Define class TriangularPrism that has base side, height from base side and length. 
Define class Cube that has side length and class Cylinder that has radius and height. 
Define class VolumeCalculator that holds static methods for calculating the volume of these three figures. 
The input will be read from the console until command “End” is received and will be in some of these formats:
• TriangularPrism <base side> <height> <length>
• Cube <side length>
• Cylinder <radius> <height>
The volume in the output must be rounded 3 digits after the floating point.
*/
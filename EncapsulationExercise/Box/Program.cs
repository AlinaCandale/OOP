using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            BOX box = new BOX(2, 7, 12);
            box.GetVolume();
            box.GetSurfaceArea();
            box.GetLaterarSurfaceArea();
        }
    }

    class BOX
    {
        double length;
        double width;
        double height;

        public BOX(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length 
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length can't be negative");
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width can't be negative");
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height can't be negative");
                }
            }
        }
        public double GetSurfaceArea()
        {
           return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public void GetLaterarSurfaceArea()
        {
            Console.WriteLine(2 * length * height + 2 * width * height);
        }
        public void GetVolume()
        {
            Console.WriteLine(length * width * height);
        }
    }
}

/*
Box
You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters, that are mandatory.

All three size need to be > 0
Add a method named GetSurfaceArea that computes the surface area using the formula: 
2 * length * width + 2 * length * height + 2 * width * height;
Add a method named GetLaterarSurfaceArea that computes and displays the surface area using the formula:
2 * length * height + 2 * width * height;
Add a method named GetVolume that computes and displays the volume using the formula: length * width * height; 

Requirements: Encapsulate end validate the members.
*/

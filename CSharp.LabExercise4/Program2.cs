//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp.LabExercise4
//{
//    interface IShape
//    {

//        public decimal Area { get; set; }
//        public string ShapeName { get; set; }

//        public void ComputeArea(decimal side);

//        public void ComputeArea(decimal length, decimal width);
//        public void DisplayArea();
//    }

//    class Circle : IShape
//    {
//        public decimal Area { get; set; }
//        public string ShapeName
//        {
//            get => "Circle";
//            set { }
//        }

//        public void ComputeArea(decimal diameter)
//        {
//            this.Area = diameter * Convert.ToDecimal(Math.PI);
//        }
//        public void ComputeArea(decimal diameter, decimal value) { }
//        public void DisplayArea()
//        {
//            Console.WriteLine("{0} area: {1}", this.ShapeName, this.Area);
//        }
//    }
//    class Square : IShape
//    {
//        public decimal Area { get; set; }
//        public string ShapeName
//        {
//            get => "Square";
//            set { }
//        }

//        public void ComputeArea(decimal side)
//        {
//            this.Area = side * side;
//        }
//        public void ComputeArea(decimal length, decimal width) { }

//        public void DisplayArea()
//        {
//            Console.WriteLine("{0} area: {1}", this.ShapeName, this.Area);
//        }
//    }
//    class Rectangle : IShape
//    {
//        public decimal Area { get; set; }
//        public string ShapeName
//        {
//            get => "Rectangle";
//            set { }
//        }

//        public void ComputeArea(decimal length) { }
//        public void ComputeArea(decimal length, decimal width)
//        {
//            this.Area = length * width;
//        }

//        public void DisplayArea()
//        {
//            Console.WriteLine("{0} area: {1}", this.ShapeName, this.Area);
//        }
//    }
//    class Program
//    {
//        public static void Number1()
//        {
//            IShape circle = new Circle();
//            circle.ComputeArea(10);
//            circle.DisplayArea();

//            IShape square = new Square();
//            square.ComputeArea(5);
//            square.DisplayArea();

//            IShape rectangle = new Rectangle();
//            rectangle.ComputeArea(5, 2);
//            rectangle.DisplayArea();
//        }
//        public static void Number2()
//        {

//        }
//        public static void Main(string[] args)
//        {
//            //Number1();
//            Number2();
//        }
//    }
//}

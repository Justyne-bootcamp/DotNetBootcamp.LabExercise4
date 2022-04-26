using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        public decimal Area { get; set; }
        public string ShapeName { get; set; }
        public void ComputeArea(params decimal[] measurements);
    }
    
    class Circle : IShape
    {
        public decimal Area { get; set; }
        public string ShapeName
        {
            get => "Circle";
            set { }
        }
        public void ComputeArea(params decimal[] measurements)
        {
            decimal radius = measurements[0];
            this.Area = (radius * radius) * Convert.ToDecimal(Math.PI);
        }
    }
    class Square : IShape
    {
        public decimal Area { get; set; }
        public string ShapeName
        {
            get => "Square";
            set { }
        }
        public void ComputeArea(params decimal[] measurements)
        {
            decimal side = measurements[0];
            this.Area = side * side;
        }
    }
    class Rectangle : IShape
    {
        public decimal Area { get; set; }
        public string ShapeName
        {
            get => "Rectangle";
            set { }
        }
        public void ComputeArea(params decimal[] measurements)
        {
            decimal length = measurements[0];
            decimal width = measurements[1];
            this.Area = length * width;
        }
    }
    class ShapeAreaCalculator
    {
        public void ComputeArea(IShape shape, params decimal[] measurements)
        {
            shape.ComputeArea(measurements);
        }    
    }

    class ShapeAreaRenderer
    {
        public void DisplayArea(IShape shape)
        {
            Console.WriteLine("{0} Area: {1}", shape.ShapeName, shape.Area);
        }
    }
    

    interface IOperation
    {
        public decimal Compute(decimal value1, decimal value2);
    }
    class Addition: IOperation
    {
        public decimal Compute(decimal value1, decimal value2)
        {
            return value1 + value2;
        }
    }
    class Substruction: IOperation
    {
        public decimal Compute(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
    }
    class Multiplication: IOperation
    {
        public decimal Compute(decimal value1, decimal value2)
        {
            return value1 * value2;
        }
    }
    class Division: IOperation
    {
        public decimal Compute(decimal value1, decimal value2)
        {
            return value1 / value2;
        }
    }
    class Calculator
    {
        public decimal Compute(IOperation operation, decimal value1, decimal value2)
        {
            return operation.Compute(value1, value2);
        }
    }
    class Program
    {
        public static void Number1()
        {
            Console.WriteLine("Welcome to the ShapeAreaCalculator\n");

            IShape circle = new Circle();
            ShapeAreaCalculator shapeAreaCalculator = new ShapeAreaCalculator();
            shapeAreaCalculator.ComputeArea(circle, new decimal[] {10});
            ShapeAreaRenderer shapeAreaRenderer = new ShapeAreaRenderer();
            shapeAreaRenderer.DisplayArea(circle);

            IShape square = new Square();
            shapeAreaCalculator.ComputeArea(square, new decimal[] { 10 });
            shapeAreaRenderer.DisplayArea(square);

            IShape rectangle = new Rectangle();
            shapeAreaCalculator.ComputeArea(rectangle, new decimal[] { 10, 5 });
            shapeAreaRenderer.DisplayArea(rectangle);
        }
        public static void Number2()
        {
            Console.WriteLine("Welcome to the Calculator\n");

            Calculator calculator = new Calculator();

            IOperation addition = new Addition();
            decimal sum = calculator.Compute(addition, 5M, 2M);

            IOperation substruction = new Substruction();
            decimal difference = calculator.Compute(substruction, 5M, 2M);

            IOperation multiplication = new Multiplication();
            decimal product = calculator.Compute(multiplication, 5M, 2M);

            IOperation division = new Division();
            decimal quotient = calculator.Compute(division, 10M, 2M);
            
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Difference: {0}", difference);
            Console.WriteLine("Product: {0}", product);
            Console.WriteLine("Quotient: {0}", quotient);
        }
        public static void Main(string[] args)
        {
            Number1();
            //Number2();
        }
    }
}

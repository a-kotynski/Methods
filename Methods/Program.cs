using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484612#content
namespace Methods
{
    public class Point
    {
        // Signature of a Method
        // * Name: Move()
        // * Number and Type of parameters: int x, int y

        public void Move(int x, int y)
        {

        }

        // Overloading Methods
        // * having a method with the same name, but different signatures
        public void Move(int x, int y, int z) { }
        public void Move(Point newLocation) { }
        public void Move(Point newLocation, int speed) { }
    }
    public class Calculator
    {
        // A method with varying number of parameters

        // proper way:
        public int Add(int[] numbers) { }
        // var result = calculator.Add(new int[] { 1, 2, 3, 4 }); // inefficient

        // The Params Modifier
        public int Add(params int[] numbers) { }
        // var result = calculator.Add(1, 2, 3, 4);


        // other, inefficient way:
        public int Add(int n1, int n2) { }
        public int Add(int n1, int n2, int n3) { }
        public int Add(int n1, int n2, int n3, int n4) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
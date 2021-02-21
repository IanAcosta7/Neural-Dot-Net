using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralDotNet.NeuralNetwork;

namespace NeuralDotNetTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiLayerPerceptron net = new MultiLayerPerceptron();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

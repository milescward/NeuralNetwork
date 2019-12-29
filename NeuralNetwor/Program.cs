using System;
using NeuralNetwork;

namespace NeuralNetwor
{
    class Program
    {
        static void Main(string[] args)
        {
            Network model = new Network();
            model.Layers.Add(new Layer(2, 0.1, "INPUT"));
            model.Layers.Add(new Layer(1, 0.1, "OUTPUT"));

            model.Build();
            Console.WriteLine("----Before Training------------");
            model.Print();

            Console.WriteLine();

            NeuralData X = new NeuralData(4);
            X.Add(0, 0);
            X.Add(0, 1);
            X.Add(1, 0);
            X.Add(1, 1);

            NeuralData Y = new NeuralData(4);
            Y.Add(0);
            Y.Add(0);
            Y.Add(0);
            Y.Add(1);

            model.Train(X, Y, iterations: 10, learningRate: 0.1);
            Console.WriteLine();
            Console.WriteLine("----After Training------------");
            model.Print();
        }
    }
}

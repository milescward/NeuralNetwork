using System;
using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public Layer(int count, double initialWeight, string name = "")
        {
            Neurons = new List<Neuron>();
            for (int i = 0; i < count; i++)
            {
                Neurons.Add(new Neuron());
            }

            this.Weight = initialWeight;

            this.Name = name;
        }

        public void Forward()
        {
            foreach (var neuron in Neurons)
            {
                neuron.Fire();
            }
        }

        public void Optimize(double learningRate, double delta)
        {
            foreach (var neuron in Neurons)
            {
                neuron.Compute(learningRate, delta);
            }
        }

        public void Log()
        {
            Console.WriteLine("{0}, Weight: {1}", Name, Weight);
        }
    }
}

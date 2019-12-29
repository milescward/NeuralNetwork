using System;
using System.Collections.Generic;
using NeuralNetwor;

namespace NeuralNetwork
{
    public class Neuron
    {
        public List<Dendrite> Dendrites { get; set; }
        public Pulse OutputPulse { get; set; }
        public double Weight { get; set; }

        public Neuron()
        {
            this.Dendrites = new List<Dendrite>();
            this.OutputPulse = new Pulse();
        }

        public void Fire()
        {
            OutputPulse.Value = Sum();
            OutputPulse.Value = Activation(OutputPulse.Value);
        }

        public void Compute(double learningRate, double delta)
        {
            Weight += learningRate * delta;
            foreach (var terminal in Dendrites)
            {
                terminal.SynapticWeight = Weight;
            }
        }

        private double Activation(double input)
        {
            double threshold = 1;
            return input >= threshold ? 0 : threshold;
        }

        private double Sum()
        {
            double computeValue = 0.0f;
            foreach (var d in Dendrites)
            {
                computeValue += d.InputPulse.Value * d.SynapticWeight;
            }

            return computeValue;
        }
    }
}

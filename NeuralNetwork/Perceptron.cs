using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NeuralDotNet.NeuralNetwork
{
    class Perceptron
    {
        #region Properties
        private readonly List<Synapse> _synapses;

        public List<Synapse> Synapses
        {
            get { return _synapses; }
        }
        #endregion
        #region Methods
        public Perceptron(int synapses)
        {
            _synapses = new List<Synapse>();

            InitializeSynapses(synapses);
        }

        /// <summary>
        /// Predicts an output given a set of inputs.
        /// </summary>
        /// <param name="inputs">Array of inputs of type <c>double</c></param>
        /// <returns>
        /// The <c>double</c> type result of the prediction.
        /// </returns>
        public double Predict(double[] inputs)
        {
            double output = 0;

            if (inputs.Length == _synapses.Count)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    output += inputs[i] * _synapses[i].Weight;
                }
            }
            else
            {
                throw new Exception("A different amount of inputs than synapses was provided.");
            }

            return output;
        }

        private void InitializeSynapses(int synapses)
        {
            while (synapses > 0)
            {
                // Weight initialization with a random number
                _synapses.Add(new Synapse());
                synapses--;
            }
        }
        #endregion
    }
}

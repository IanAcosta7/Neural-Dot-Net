using System;
using System.Collections.Generic;
using System.Linq;
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

        private double _output;

        public double Output
        {
            get { return _output; }
        }
        #endregion
        #region Methods
        public Perceptron(int synapses)
        {
            _synapses = new List<Synapse>();
            _output = 0;

            InitializeSynapses(synapses);
        }

        private void InitializeSynapses(int synapses)
        {
            while (synapses > 0)
            {
                // Weight initialization with a random number
                _synapses.Add(new Synapse(new Random().NextDouble()));
                synapses--;
            }
        }
        #endregion
    }
}

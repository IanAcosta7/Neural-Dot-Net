using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralDotNet.NeuralNetwork
{
    class Synapse
    {
        #region Properties
        private double input;

        public double Input
        {
            get { return input; }
            set { input = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
        }

        #endregion
        #region Methods
        public Synapse(double _weight) => weight = _weight;
        #endregion
    }
}

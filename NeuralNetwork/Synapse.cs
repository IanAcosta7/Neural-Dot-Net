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
        private double _input;

        public double Input
        {
            get { return _input; }
            set { _input = value; }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        #endregion
        #region Methods
        public Synapse(double weight) => this._weight = weight;
        #endregion
    }
}

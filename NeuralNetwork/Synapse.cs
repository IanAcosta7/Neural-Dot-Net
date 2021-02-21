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
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        #endregion
        #region Methods
        public Synapse()
        {
            this._weight = new Random().NextDouble();
        }
        #endregion
    }
}

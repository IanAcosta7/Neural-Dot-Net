using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralDotNet
{
    public class Net
    {
        #region Properties
        private double[] inputs;

        public double[] Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }

        private double[] outputs;

        public double[] Outputs
        {
            get { return outputs; }
        }
        #endregion
        #region Methods
        public Net()
        {
            Console.WriteLine("NET");
        }
        #endregion
    }
}

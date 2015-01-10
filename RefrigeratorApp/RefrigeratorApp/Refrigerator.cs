using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maxWeight = Double.MinValue;
        private double currentWeight; 
        private double remainingWeight;
        private int noOfItems;
        private double weightPerItem;

        public double CurrentWeight
        {
            get { return currentWeight; }
        }

        public double RemainingWeight
        {
            get { return remainingWeight; }
        }

        public double MaxWeight
        {
            get { return maxWeight; }
            set
            {
                if (value < 0)
                    throw new NegetiveMaxWeightException();
                if (maxWeight == Double.MinValue)
                    maxWeight = value;
                else
                    throw new OverwritingMaxWeightException();
            }
        }
        private double TotalWeight
        {
            get { return noOfItems * weightPerItem; }
        }

        public void AddItems(int noOfItems, double weightPerItem)
        {
            this.noOfItems = noOfItems;
            this.weightPerItem = weightPerItem;
            SetCurrentAndRemainingWeight();
        }
        private void SetCurrentAndRemainingWeight()
        {
            if (MaxWeight > Double.MinValue)
            {
                if (MaxWeight - CurrentWeight >= TotalWeight)
                {
                    currentWeight += TotalWeight;
                    remainingWeight = MaxWeight - CurrentWeight;
                }
                else
                    throw new OverflowToMaxWeightException();
            }
            else
                throw new MaxWeightNotSetException();
        }
    }
    public class OverflowToMaxWeightException : Exception
    {
        public OverflowToMaxWeightException()
            : base("Item's Weight exceeds maximum weight of the Refrigerator.")
        {
        }
    }
    public class OverwritingMaxWeightException : Exception
    {
        public OverwritingMaxWeightException()
            : base("Maximum Weight has been already set. You can not overwrite it.")
        {
        }
    }
    public class MaxWeightNotSetException : Exception
    {
        public MaxWeightNotSetException()
            : base("Maximum Weight has not set yet.")
        {
        }
    }
    public class NegetiveMaxWeightException : Exception
    {
        public NegetiveMaxWeightException()
            : base("Maximum Weight can not be Negetive.")
        {
        }
    }
    
}

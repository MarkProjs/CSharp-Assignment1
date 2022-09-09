using System;
using System.Linq;

namespace PianoSimulation
{
    public class CircularArray:IRingBuffer {   
        private double[] buffer;
        private int Counter = 0;

        public CircularArray(int arrLength) {
            buffer = new double[arrLength];
        }
        public int Length {
            get { return buffer.Length;}
               
            
        }

        public double Shift(double value) {
            double FirstVal = buffer[Counter];
            buffer[Counter] = value;
            if (Counter == buffer.Length -1) {
                Counter = 0;
            }
            else {
                Counter += 1;
            }
            return FirstVal;
        }

        public double this[int index] {
            get {return buffer[index];}
        }

        public void Fill(double[] array) {
            double[] tempArr = new double[array.Length];
            for(int i = 0; i < array.Length ; i++) {
                tempArr[i] = array[i];
            }

            buffer = tempArr;
        }
        
    }
}
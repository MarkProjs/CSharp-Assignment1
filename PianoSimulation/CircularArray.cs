using System;
using System.Linq;

namespace PianoSimulation
{
    public class CircularArray:IRingBuffer {   
        private double[] buffer;

        public CircularArray(int arrLength) {
            buffer = new double[arrLength];
        }
        public int Length {
            get {
                return buffer.Length;
            }
        }

        public double Shift(double value) {
            double elem = buffer[0];
            buffer = buffer.Skip(1).ToArray();
            buffer = buffer.Append(value).ToArray();
            return elem;
        }

        public double this[int index] {
            get {return buffer[index];}
            set {buffer[index] = value;}
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PianoSimulation
{
    public class PianoWire:IMusicalString
    {
        private CircularArray CircArr;
        private double _NoteFreq;
        private int _NumSamples;

        public PianoWire(double NoteFreq, int SampleRate) {
            _NoteFreq = NoteFreq;
            _NumSamples = Convert.ToInt32(SampleRate/NoteFreq);
            CircArr = new CircularArray(_NumSamples);

        }

        public double NoteFrequency{
            get {
                return _NoteFreq;
            }

        }

        public int NumberOfSamples {
            get {
                return _NumSamples;
            }
        }

        public void Strike() {
            Random rand = new Random();
            double MIN_VALUE = -0.5;
            double MAX_VALUE = 0.5;
            double[] tempArr = new double[CircArr.Length];
            for (int i = 0; i < tempArr.Length;i++) {
                tempArr[i] = rand.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
            }
            CircArr.Fill(tempArr);
            
        }

        public double Sample(double decay=0.996) {
            double newValue = ((CircArr[0] + CircArr[1]) / 2) * decay;
            return CircArr.Shift(newValue);
        }
    }
}
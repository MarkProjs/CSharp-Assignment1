using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PianoSimulation
{
    public class Piano:IPiano {
        private List<IMusicalString> _pianoWires;
        private string _keys;
        public Piano(string keys = "q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ",  int samplingRate = 44100) {
            _keys = keys;
        }

        public void StrikeKey(char key) {

        }

        public double Play() {
            double play = 0.0;
            return play;
        }

        public List<string> GetPianoKeys() {
            List<string> pianoKeys = new List<string>();

            return pianoKeys;
        }

        public string Keys {
            get {
                return _keys;
            }
        }
    }
}
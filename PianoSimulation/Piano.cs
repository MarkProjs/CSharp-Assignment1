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
            for (int i = 0; i < keys.Length;i++) {
                _pianoWires.Add(new PianoWire((Math.Pow(2,(i-24)/12.0))*440,samplingRate));
            }
        }

        public void StrikeKey(char key) {
            int index = _keys.IndexOf(key);
            _pianoWires[index].Strike();
        }

        public double Play() {
            double sumSample = 0.0;
            for (int i = 0;i < _pianoWires.Count;i++) {
                sumSample += _pianoWires[i].Sample();
            }
            return sumSample;
        }

        public List<string> GetPianoKeys() {
            List<string> pianoKeys = new List<string>();
            pianoKeys.Add(_keys);

            return pianoKeys;
        }

        public string Keys {
            get {
                return _keys;
            }
        }
    }
}
using System;
using PianoSimulation;

namespace KeyboardPiano
{
    class Program
    {
        static void Main(string[] args)
        {
            PianoWire pw = new PianoWire(0.5, 2);
            pw.Strike();
        }
    }
}

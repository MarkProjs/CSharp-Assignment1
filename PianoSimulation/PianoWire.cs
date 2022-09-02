using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PianoSimulation
{
    public class PianoWire:IMusicalString
    {
        CircularArray CircArr;
        double NoteFreq;
        double SampleRate;
    }
}
namespace PianoSimulation
{
    public class CircularArray:IRingBuffer
    {   private double[] arr;
        public int Length() {
            get => arr.Length;
        }
        
    }
}
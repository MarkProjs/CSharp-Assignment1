namespace PianoSimulation
{
    public class CircularArray:IRingBuffer {   
        private double[] arr;

        public CircularArray(int arrLength) {
            arr = new Double[arrLength];
        }
        public int Length() {
            get {arr.Length;}
        }

        public double Shift(double value) {

        }

        public double this[int index] {
            get;
        }

        public void Fill(double[] array) {

        }
        
    }
}
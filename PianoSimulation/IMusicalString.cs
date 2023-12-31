﻿namespace PianoSimulation
{
    public interface IMusicalString
    {
        /// <summary>
        /// The frequency of the note generated by the string
        /// </summary>
        public double NoteFrequency {get;}

        /// <summary>
        /// Number of samples generated by the string simluation
        /// </summary>
        public int NumberOfSamples {get;}

        /// <summary>
        /// This method simulates striking the wire by replacing all of the values
        /// in the ring buffer with random values from the range -0.5 to 0.5. 
        /// </summary>
        void Strike();

        /// <summary>
        /// This method adds a new value to the rear, which is the average of the two
        /// first values multiplied by the decay factor. It removes the value  
        /// currently at the front, and  returns it.
        /// </summary>
        /// <param name="decay">Factor</param>
        /// <returns>First value in queue, between -0.5 and 0.5</returns>
        double Sample(double decay=0.996);
    }
}
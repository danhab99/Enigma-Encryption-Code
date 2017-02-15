namespace EnigmaMachine.Enigma.Constituents.Interfaces
{
    public interface iter_Translator<T> : Translator<T>
    {
        /// <summary>
        /// The synchronous offset for this device
        /// </summary>
        int offset { get; set; }
        

        iter_Translator<T> next { get; set; }

        /// <summary>
        /// Operates the current device
        /// </summary>
        /// <param name="input">The object to operate on</param>
        /// <param name="invert">Whether or not to flip the procedure</param>
        /// <param name="async_offset">Defines an offset for asynchronous processing, dose not incriment private offset</param>
        /// <returns>The encrypted object</returns>
        T Use(T input, bool invert, int async_offset);
    }
}

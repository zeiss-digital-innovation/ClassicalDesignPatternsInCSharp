namespace ClassicalDesignPatternsInCSharp.Singleton
{
    /// <summary>
    ///     Encapsulates the implementation of the Singleton design pattern as described by the Gang of For (GoF).
    /// </summary>
    /// <remarks>
    ///     The solution provided by the <see cref="SimpleSingleton" /> class has the disadvantage of being not thread-safe.
    /// </remarks>
    public class SimpleSingleton
    {
        private static SimpleSingleton instance;

        /// <summary>
        ///     Prevents a default instance of the <see cref="SimpleSingleton" /> class from being created.
        /// </summary>
        private SimpleSingleton()
        {
        }

        /// <summary>
        ///     Gets the singleton instance of the <see cref="SimpleSingleton" /> class.
        /// </summary>
        public static SimpleSingleton Instance => instance ?? (instance = new SimpleSingleton());
    }
}
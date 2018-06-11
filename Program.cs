using ClassicalDesignPatternsInCSharp.Singleton;

namespace ClassicalDesignPatternsInCSharp
{
    public class Program
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            // Singleton
            var simpleSingleton = SimpleSingleton.Instance;
        }
    }
}
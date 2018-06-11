namespace ClassicalDesignPatternsInCSharp
{
    using Factories;
    using Singleton;

    public class Program
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            // Singleton
            var simpleSingleton = SimpleSingleton.Instance;

            // Factory Method
            Building sweetHome = new CastleFactory().GetBuilding();
        }
    }
}
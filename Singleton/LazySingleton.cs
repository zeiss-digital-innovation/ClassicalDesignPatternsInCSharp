using System;

namespace ClassicalDesignPatternsInCSharp.Singleton
{
    /// <summary>
    ///     Encapsulates the implementation of the Singleton design pattern as described by the Gang of For (GoF).
    /// </summary>
    /// <remarks>
    ///     The described solution is thread-safe due to the fact that <see cref="Lazy{T}" /> is thread-safe.
    /// </remarks>
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        ///     Prevents a default instance of the <see cref="LazySingleton" /> class from being created.
        /// </summary>
        private LazySingleton()
        {
        }

        /// <summary>
        ///     Gets the singleton instance of the <see cref="LazySingleton" /> class.
        /// </summary>
        public static LazySingleton Singleton => instance.Value;
    }
}
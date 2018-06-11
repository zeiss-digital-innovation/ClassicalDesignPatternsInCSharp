namespace ClassicalDesignPatternsInCSharp.Factories
{
    /// <summary>
    ///     The abstract representation of a building. It provides common methods that can be used for every building (cabin,
    ///     castle, etc.)
    /// </summary>
    public abstract class Building
    {
        /// <summary>
        ///     You enter the building.
        /// </summary>
        public abstract void Enter();

        /// <summary>
        ///     You leave the building.
        /// </summary>
        public abstract void Leave();
    }

    /// <summary>
    ///     Abstract factory used to create <see cref="Building" /> instances.
    /// </summary>
    public abstract class BuildingFactory
    {
        /// <summary>
        ///     When overwritten in derived classes, creates concrete <see cref="Building" /> instances.
        /// </summary>
        /// <returns>
        ///     Returns a new <see cref="Building" /> instance.
        /// </returns>
        public abstract Building GetBuilding();
    }

    /// <inheritdoc />
    /// <summary>
    ///     Encapsulates a superior building where princes can life.
    /// </summary>
    /// <seealso cref="Building" />
    public class Castle : Building
    {
        /// <inheritdoc />
        public override void Enter()
        {
        }

        /// <inheritdoc />
        public override void Leave()
        {
        }
    }

    /// <summary>
    ///     Encapsulates a <see cref="BuildingFactory" /> for creating <see cref="Castle" /> instances.
    /// </summary>
    /// <seealso cref="BuildingFactory" />
    public class CastleFactory : BuildingFactory
    {
        /// <inheritdoc />
        public override Building GetBuilding()
        {
            return new Castle();
        }
    }
}
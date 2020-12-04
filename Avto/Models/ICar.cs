namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Common interface for any car.
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Gets brand of car.
        /// </summary>
        string Brand { get; }

        /// <summary>
        /// Gets Classification of car.
        /// </summary>
        string Classification { get; }

        /// <summary>
        /// Gets color of car.
        /// </summary>
        string Color { get; }

        /// <summary>
        /// Gets price of car.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets fuel consumption of car.
        /// </summary>
        double FuelConsumption { get; }
    }
}

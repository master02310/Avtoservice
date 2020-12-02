namespace Avto.Models.Grocary
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
        /// Gets engine of car.
        /// </summary>
        string Engine { get; }

        /// <summary>
        /// Gets color of car.
        /// </summary>
        string Color { get; }

        /// <summary>
        /// Gets price of car.
        /// </summary>
        double Price { get; }
    }
}

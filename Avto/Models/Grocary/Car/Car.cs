namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Base class for car form grocary.
    /// </summary>
    public abstract class Car : Grocary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="price">Price of car.</param>
        /// <param name="fuel_consumption">Fuel consumption of car.</param>
        /// <param name="brand">Brand of car.</param>
        /// <param name="classification">Classification of car.</param>
        /// <param name="color">Color of car.</param>
        protected Car(double price, double fuel_consumption, string brand, string classification, string color)
            : base(price, fuel_consumption, brand, classification, color)
        {
        }

        /// <summary>
        /// Gets type of car engine.
        /// </summary>
        public abstract TypeEngineCar TypeEngineCar { get; }
    }
}

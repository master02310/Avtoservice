namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FirstCar.
    /// </summary>
    public class SecondCar : Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondCar"/> class.
        /// </summary>
        /// <param name="price">Price of car.</param>
        /// <param name="fuel_consumption">Fuel consumption of car.</param>
        /// <param name="brand">Brand of car.</param>
        /// <param name="classification">Classification of car.</param>
        /// <param name="color">Color of car.</param>
        public SecondCar(double price, double fuel_consumption, string brand, string classification, string color)
            : base(price, fuel_consumption, brand, classification, color)
        {
        }

        /// <summary>
        /// Gets type of car.
        /// </summary>
        public override TypeEngineCar TypeEngineCar => TypeEngineCar.ElectricCar;

        /// <summary>
        /// Gets or sets brand.
        /// </summary>
        public override string Brand { get; set; }

        /// <summary>
        /// Gets or sets fuelConsumption.
        /// </summary>
        public override double FuelConsumption { get; set; }
    }
}
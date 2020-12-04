namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Base class for any items from car.
    /// </summary>
    public abstract class Grocary : ICar
    {
        private readonly double price;
        private readonly double fuelConsumption;
        private readonly string brand;
        private readonly string classification;
        private readonly string color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Grocary"/> class.
        /// </summary>
        /// <param name="price">Price of car.</param>
        /// <param name="fuel_consumption">Fuel consumption of car.</param>
        /// <param name="brand">Brand of car.</param>
        /// <param name="classification">Classification of car.</param>
        /// <param name="color">Color of car.</param>
        public Grocary(double price, double fuel_consumption, string brand, string classification, string color)
        {
            this.price = price;
            this.fuelConsumption = fuel_consumption;
            this.brand = brand;
            this.classification = classification;
            this.color = color;
        }

        /// <summary>
        /// Gets or sets brand of car in gorocary.
        /// </summary>
        public abstract string Brand { get; set; }

        /// <summary>
        /// Gets price of car in gorocary.
        /// </summary>
        public double Price => this.price;

        /// <summary>
        /// Gets classification of car in gorocary.
        /// </summary>
        public string Classification => this.classification;

        /// <summary>
        /// Gets color of car in gorocary.
        /// </summary>
        public string Color => this.color;

        /// <summary>
        /// Gets or sets fuel consumption of car.
        /// </summary>
        public abstract double FuelConsumption { get; set; }
    }
}

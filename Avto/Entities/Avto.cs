namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Entity avto.
    /// </summary>
    public class Avto
    {
        /// <summary>
        /// Gets or sets car.
        /// </summary>
        public Car[] Car { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public double Price { get; set; }
    }
}

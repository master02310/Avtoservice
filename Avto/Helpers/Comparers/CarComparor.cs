    namespace Avtopark
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Comparer of car.
    /// </summary>
    public class CarComparor : IComparer
    {
        /// <summary>
        /// Comparble.
        /// </summary>
        /// <param name="low">low item.</param>
        /// <param name="big">big item.</param>
        /// <returns>Comparable value.</returns>
        public int Compare(object low, object big)
        {
            var x = low as Car;
            var y = big as Car;

            if (x.FuelConsumption > y.FuelConsumption)
            {
                return 1;
            }
            else if (x.FuelConsumption < y.FuelConsumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

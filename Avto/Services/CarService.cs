namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Car service.
    /// </summary>
    public class CarService : ICarService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarService"/> class.
        /// </summary>
        public CarService()
        {
        }

        /// <summary>
        /// Make salad cesar.
        /// </summary>
        /// <returns>return list of vegerable for this salad.</returns>
        public Avto AvtoPark()
        {
            var car = new Car[]
            {
                new FirstCar(20000, 0, "Tesla", "Electro car", "Green"),
                new SecondCar(25000, 15, "Lambo", "Sport car", "Pink"),
            };

            var price = 0d;
            for (var i = 0; i < car.Length; i++)
            {
                price += car[i].Price;
            }

            return new Avto { Car = car, Price = price };
        }
    }
}

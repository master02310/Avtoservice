namespace Avtopark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Start buisness logic.
    /// </summary>
    public class Starter
    {
        private readonly ICarService carservice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
            this.carservice = new CarService();
        }

        /// <summary>
        /// Run buisness logic.
        /// </summary>
        public void Run()
        {
            var car = this.carservice.AvtoPark();
            Array.Sort(car.Car, new CarComparor());

            for (int i = 0; i < car.Car.Length; i++)
            {
                Console.WriteLine($"Brand: {car.Car[i].Brand} Price: {car.Car[i].Price} " +
                    $"Fuel consumption: {car.Car[i].FuelConsumption}");
            }

            Console.WriteLine($"Car park Price: {car.Price}");

            Console.WriteLine("-------------------");
        }
    }
}

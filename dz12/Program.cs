namespace dz12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scooter = new Scooter
            {
                RentalCostPerMinute = 1.2m,
                Model = "Xiaomi",
                Year = 2021
            };

            var scooterRental = new TransportRental<Scooter>("Иванов Иван Иванович", scooter, 120);
            Console.WriteLine(scooterRental.GetRentalInfo());
            Console.WriteLine($"Общая стоимость аренды: {scooterRental.CalculateTotalCost()}\n");




            var car = new Car
            {
                RentalCostPerMinute = 15m,
                LicensePlate = "777",
                Make = "Toyota",
                Model = "Camry",
                Color = "X5"
            };

            var carRental = new TransportRental<Car>("Петров Петр Петрович", car, 60);
            Console.WriteLine(carRental.GetRentalInfo());
            Console.WriteLine($"Общая стоимость аренды: {carRental.CalculateTotalCost()}");
        }
    }
}

using static dz12.Sword;

namespace dz12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var scooter = new Scooter
            //{
            //    RentalCostPerMinute = 1.2m,
            //    Model = "Xiaomi",
            //    Year = 2021
            //};

            //var scooterRental = new TransportRental<Scooter>("Иванов Иван Иванович", scooter, 120);
            //Console.WriteLine(scooterRental.GetRentalInfo());
            //Console.WriteLine($"Общая стоимость аренды: {scooterRental.CalculateTotalCost()}\n");




            //var car = new Car
            //{
            //    RentalCostPerMinute = 15m,
            //    LicensePlate = "777",
            //    Make = "Toyota",
            //    Model = "Camry",
            //    Color = "X5"
            //};

            //var carRental = new TransportRental<Car>("Петров Петр Петрович", car, 60);
            //Console.WriteLine(carRental.GetRentalInfo());
            //Console.WriteLine($"Общая стоимость аренды: {carRental.CalculateTotalCost()}");

            //Sword sword = new()
            //{
            //    WeaponPower = 10,
            //    SpecialAbility = "Парирование",
            //    Quality = SwordQuality.Уникальное
            //};


            //CharacterInGame<Sword> okr = new CharacterInGame<Sword>(
            //    "Джон", "Орк", sword, 70);

            //Console.WriteLine(okr.GetCharacterInfo());
            //Console.WriteLine($"Суммарная сила: {okr.GetPower()}");


            //Bow bow = new()
            //{
            //    WeaponPower = 20,
            //    SpecialAbility = "Двойной выстрел",
            //    Range = 100,
            //    Accuracy = 75
            //};


            //CharacterInGame<Bow> archer = new CharacterInGame<Bow>(
            //    "Эльза", "Эльф", bow, 7);

            //Console.WriteLine(archer.GetCharacterInfo());
            //Console.WriteLine($"Суммарная сила: {archer.GetPower()}");
            //var bread = new Necessites
            //{
            //    ProductName = "Хлеб",
            //    ProductCost = 50.2
            //};

            //var gold = new Lux
            //{
            //    ProductName = "Золото",
            //    ProductCost = 113123
            //};

            //bread.Print(); gold.Print();

            var manager = new Manager
            {
                FullName = "Петя",
                WorkingDays = 28
            };

            var departament = new DepartamentHead
            {
                FullName = "Вася",
                WorkingDays = 65
            };
            manager.Print(); departament.Print();
        }
    }
}


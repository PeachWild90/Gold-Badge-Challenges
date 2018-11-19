using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public class GreenProgramUI
    {
        CarRepo _carRepo = new CarRepo();
        List<CarInfo> _cars;
        public void Run()
        {
            _cars = _carRepo.GetCarList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Yo, let's save the Earth" +
                    "\n1. Add a Car to da List" +
                    "\n2. Show a specific Car's details" +
                    "\n3. Update a specific Car's specs" +
                    "\n4. Delete a specific Car" +
                    "\n5. Display List of all Cars");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        CreateCar();
                        break;
                    case 2:
                        ShowCarDetails();
                        break;
                    case 3:
                        UpdateCarInfo();
                        break;
                    case 4:
                        DeleteCarEntry();
                        break;
                    case 5:
                        DisplayListOfCars();
                        break;
                }
            }
        }
        private void CreateCar()
        {
            CarInfo newCar = new CarInfo();

            Console.WriteLine("What is the make?");
            newCar.Make = Console.ReadLine();

            Console.WriteLine("What is the model?");
            newCar.Model = Console.ReadLine();

            Console.WriteLine("What kinda MPG does it get?");
            newCar.MilesPerGallon = int.Parse(Console.ReadLine());

            Console.WriteLine("Is it badass? y/n");
            newCar.IsItBadass = IsItBadass();

            Console.WriteLine("What Type of Car is it? I'm super cereal");
            newCar.CarType = DefineCarType();
        }

        private CarType DefineCarType()
        {
            Console.WriteLine("Select a Car Type:" +
                                "\n1 Electric" +
                                "\n2 Hybrid;" +
                                "\n3 Gas GUSLA;");
            var input = Console.ReadLine();

            switch (input)
            {
                case "Electric":
                    return CarType.Electric;
                case "Hybrid":
                    return CarType.Hybrid;
                default:
                    return CarType.Gas;
            }
        }

        private bool IsItBadass()
        {
            var customerInput = Console.ReadLine();
            if (customerInput == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowCarDetails()
        {
            Console.WriteLine("Please enter the make: ");
            string userInput = Console.ReadLine();

            foreach (CarInfo car in _cars)
            {
                if (car.Make == userInput)
                {
                    Console.WriteLine(car.Make);
                    Console.WriteLine(car.Model);
                    Console.WriteLine(car.MilesPerGallon);
                    Console.WriteLine(car.CarType);
                    Console.WriteLine(car.IsItBadass);
                }
            }
        }
        private void UpdateCarInfo()
        {
            Console.WriteLine("Please enter the make: ");
            string userInput = Console.ReadLine();

            foreach (CarInfo car in _cars)
            {
                if (car.Make == userInput)
                {
                    CreateCar();
                }
            }
        }
        private void DeleteCarEntry()
        {
            Console.WriteLine("Please enter the make: ");
            string userInput = Console.ReadLine();

            foreach (CarInfo carInfo in _cars.ToList())
            {
                if (carInfo.Make == userInput)
                {
                    _carRepo.RemoveCarInfo(carInfo);
                }
            }
            return;
        }
        private void DisplayListOfCars()
        {
            Console.WriteLine("Please enter the car type: ");
            
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Electric"+
                    "\n2.Hybrid"+
                    "\n3.Gas");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine($"{List<CarType>}"); //need help here
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }
    }
}

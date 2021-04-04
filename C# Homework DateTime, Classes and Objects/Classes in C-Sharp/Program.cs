using System;

namespace Classes_in_C_Sharp
{
    #region Class Exercise 3 (Create 5 Students)
    public class Student
    {
        public Student()
        {

        }
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public string StudentInfo()
        {
            return $@"The student name is {Name}, he is in {Academy} academy and it's in the {Group} group";
        }
    }

    #endregion

    public class Driver
    {
        public Driver()
        {

        }
        public string Name { get; set; }
        public int Skill { get; set; }

    }

    public class Car
    {
        public Car()
        {

        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;
        }

    }



    class Program
    {

        static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine($"The winner is {car1.Driver.Name} with the :{car1.Model}, the max speed was {car1.Speed}km/h");
            }
            else if (car1.CalculateSpeed() < car2.CalculateSpeed())
            {
                Console.WriteLine($"The winner is {car2.Driver.Name} with the :{car2.Model}, the max speed was {car2.Speed}km/h");
            }
            else if (car1.CalculateSpeed() == car2.CalculateSpeed())
            {
                Console.WriteLine($"There is no winner, the cars have the same speed!");
            }
        }
        static void Main(string[] args)
        {

            #region Class Exercise 3 (Create 5 Students)
            Console.WriteLine("Hello Classes!");


            Student student01 = new Student();

            student01.Name = "Pero";
            student01.Academy = "SEDC";
            student01.Group = "G4";

            Student student02 = new Student();

            student02.Name = "Blazo";
            student02.Academy = "SEDC";
            student02.Group = "G4";

            Student student03 = new Student();

            student03.Name = "Risto";
            student03.Academy = "SEDC";
            student03.Group = "G4";

            Student student04 = new Student();

            student04.Name = "Trajce";
            student04.Academy = "SEDC";
            student04.Group = "G3";

            Student student05 = new Student();

            student05.Name = "Petko";
            student05.Academy = "SEDC";
            student05.Group = "G3";

            Student[] studentArray = new Student[5] { student01, student02, student03, student04, student05 };



            while (true)
            {
                bool found = false;
                //Console.WriteLine("\n");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Please enter student name");
                string userInput = Console.ReadLine();

                foreach (Student student in studentArray)
                {

                    if (student.Name.ToLower() == userInput.ToLower())
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(student.StudentInfo());
                        Console.WriteLine("\n");
                        found = true;
                    }

                }

                if (!found) Console.WriteLine("There is no such student");

                if (userInput.ToLower() == "x") break;
                Console.WriteLine($"-----If you want to exit the program please enter 'X' or else ...");
            }

            #endregion



            Driver driver01 = new Driver();
            driver01.Name = "Bob";
            driver01.Skill = 90;

            Driver driver02 = new Driver();
            driver02.Name = "Greg";
            driver02.Skill = 80;

            Driver driver03 = new Driver();
            driver03.Name = "Jill";
            driver03.Skill = 70;

            Driver driver04 = new Driver();
            driver04.Name = "Ann";
            driver04.Skill = 60;

            Car car01 = new Car();
            car01.Model = "Hyundai";
            car01.Speed = 180;

            Car car02 = new Car();
            car02.Model = "Mazda";
            car02.Speed = 200;

            Car car03 = new Car();
            car03.Model = "Ferrari";
            car03.Speed = 320;

            Car car04 = new Car();
            car04.Model = "Porsche";
            car04.Speed = 300;

            Driver[] driverArray = { driver01, driver02, driver03, driver04 };
            Car[] carArray = { car01, car02, car03, car04 };

            Car firstRaceCar = new Car();
            Car secondRaceCar = new Car();

            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("--------It's Race Day--------");

                Console.WriteLine("Please select your first Car\n");

                for (int i = 0; i < carArray.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{carArray[i].Model}\n");
                }

                bool tryParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCar);

                if (tryParseFirstCar)
                {
                    if (firstCar > 4 || firstCar < 1)
                    {
                        Console.WriteLine("Please enter Number between 1 and 4\n");
                        continue;
                    }
                    firstRaceCar = carArray[firstCar - 1];

                    Console.WriteLine("Please select your first driver\n");

                    for (int i = 0; i < driverArray.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.{driverArray[i].Name}\n");
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only!\n");
                    continue;
                }

                bool tryParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriver);

                if (tryParseFirstDriver)
                {
                    if (firstDriver > 4 || firstDriver < 1)
                    {
                        Console.WriteLine("Please enter Number between 1 and 4\n");
                        continue;
                    }

                    firstRaceCar.Driver = driverArray[firstDriver - 1];
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only!\n");
                    continue;
                }
                Driver[] leftDrivers = new Driver[3];

                int counterDriver = 0;

                for (int i = 0; i < driverArray.Length; i++)
                {
                    if (i != firstDriver - 1)
                    {
                        leftDrivers[counterDriver] = driverArray[i];
                        counterDriver++;

                    }
                }

                Car[] leftCars = new Car[3];

                int counterCar = 0;

                for (int i = 0; i < carArray.Length; i++)
                {
                    if (i != firstCar - 1)
                    {
                        leftCars[counterCar] = carArray[i];
                        counterCar++;

                    }
                }

                Console.WriteLine("Please select your second Car\n");

                for (int i = 0; i < leftCars.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{leftCars[i].Model}\n");
                }

                bool tryParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCar);

                if (tryParseSecondCar)
                {
                    if (secondCar > 4 || secondCar < 1)
                    {
                        Console.WriteLine("Please enter Number between 1 and 4\n");
                        continue;
                    }
                    secondRaceCar = leftCars[secondCar - 1];
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only!\n");
                    continue;
                }

                Console.WriteLine("Please select your second driver\n");

                for (int i = 0; i < leftDrivers.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{leftDrivers[i].Name}\n");
                }

                bool tryParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriver);

                if (tryParseSecondDriver)
                {
                    if (secondDriver > 4 || secondDriver < 1)
                    {
                        Console.WriteLine("Please enter Number between 1 and 4\n");
                        continue;
                    }
                    secondRaceCar.Driver = leftDrivers[secondDriver - 1];
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only!\n");
                    continue;
                }

                RaceCars(firstRaceCar, secondRaceCar);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Pres 'Y' if you would like to Race again or 'N' to Quit");
                string raceAgain = Console.ReadLine();

                if (raceAgain.ToLower() == "y")
                {
                    continue;
                }
                else if (raceAgain.ToLower() == "n")
                {
                    break;
                }
            }


            Console.ReadLine();
        }
    }
}

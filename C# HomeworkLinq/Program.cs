using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more

			List<Person> peopleAged50 = people
										.Where(x => x.Age >= 50)
										.ToList();
            Console.WriteLine("People aged 50 or more.");
            Console.WriteLine("------------------------------------");
			peopleAged50.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("------------------------------------");

			// Task 02
			// all people name starts with B

			List<Person> nameStartsWith_B = people
										.Where(x => x.FirstName.StartsWith('B'))
										.ToList();
			Console.WriteLine("People which names starts with 'B'. ");
			Console.WriteLine("------------------------------------");
			nameStartsWith_B.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("------------------------------------");

			// Task 03
			// first person whose surname starts with T

			Person surnameStartsWith_B = people
										.Where(x => x.LastName.StartsWith('T'))
										.FirstOrDefault();
			
			Console.WriteLine("------------------------------------");
			if(surnameStartsWith_B == null)
            {
                Console.WriteLine("There is no Person whose name starts with 'T'");
				Console.WriteLine("------------------------------------");
			}
			else
            {
                Console.WriteLine($"First Person whose name starts with 'T' is {surnameStartsWith_B.FirstName} {surnameStartsWith_B.LastName} ");
				Console.WriteLine("------------------------------------");
			}





			// Task 04
			// find youngest and oldest person


			List<int> peopleAge = people
										.Select(x => x.Age)
										.ToList();
			peopleAge
					.Sort();

			int youngestAge = peopleAge.FirstOrDefault();
			int oldestAge = peopleAge.LastOrDefault();

			Person youngestPerson = people
								.Where(x => x.Age == youngestAge)
								.FirstOrDefault();
			Person oldestPerson = people
								.Where(x => x.Age == oldestAge)
								.FirstOrDefault();

			
			Console.WriteLine("------------------------------------");
            Console.WriteLine($"The youngest person is {youngestPerson.FirstName}, with the age of {youngestPerson.Age}");
			Console.WriteLine($"The oldes person is {oldestPerson.FirstName}, with the age of {oldestPerson.Age}");
			Console.WriteLine("------------------------------------");


			// Task 05
			// find all male people aged 45 or more


			List<Person> maleAged45 = people
										.Where(x => x.Age >= 45 && x.Gender == 'M')
										.ToList();
			Console.WriteLine("All male people aged 45 or more.");
			Console.WriteLine("------------------------------------");
			maleAged45.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("------------------------------------");



			// Task 06
			// find all females whose name starts with V

			List<Person> femaleFirstName_V = people
										.Where(x => x.FirstName.StartsWith('V') && x.Gender == 'F')
										.ToList();
			Console.WriteLine("All Females whose name starts with 'V' ");
			Console.WriteLine("------------------------------------");
			femaleFirstName_V.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("------------------------------------");

			// Task 07
			// find last female person older than 30 whose name starts with p

			Person female30and_P = people
									.Where(x => x.Age >= 30 && x.FirstName.StartsWith('p'))
									.LastOrDefault();


			



			// Task 08
			// find first male younger than 40

			Person firstMaleYoungerThan40 = people
										.Where(x => x.Age < 40 && x.Gender == 'M')
										.FirstOrDefault();
			Console.WriteLine("------------------------------------");
			if (firstMaleYoungerThan40 == null)
			{
				Console.WriteLine("There is no male person younger than 40. ");
				Console.WriteLine("------------------------------------");
			}
			else
			{
				Console.WriteLine($"The First male younger than 40 is {firstMaleYoungerThan40.FirstName}, Age: {firstMaleYoungerThan40.Age}");
				Console.WriteLine("------------------------------------");
			}
			// Task 09
			// print the names of the male persons that have firstName longer than lastName

			List<Person> maleWithLongerFirstname = people
										.Where(x => x.FirstName.Length > x.LastName.Length && x.Gender == 'M')
										.ToList();


			if(maleWithLongerFirstname.Count == 0)
            {
                Console.WriteLine("There are no Males with FirstName longer than the LastName");
            }
            else {	Console.WriteLine("The Male people that have firstName longer than lastName are: ");
			Console.WriteLine("------------------------------------");
			maleWithLongerFirstname.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
			Console.WriteLine("------------------------------------");
			}


			// Task 10
			// print the lastNames of the female persons that have odd number of ages

			var femaleOddNumberOfAge = people
									.Where(x =>x.Age % 2 != 0 && x.Gender == 'F')
									.ToList();
			Console.WriteLine("The LastNames of the female persons that have odd number of ages are:");
			Console.WriteLine("------------------------------------");
			femaleOddNumberOfAge.ForEach(x => Console.WriteLine($"{x.LastName} with the age of {x.Age}"));
			Console.WriteLine("------------------------------------");


			Console.ReadLine();
		}
    }
}

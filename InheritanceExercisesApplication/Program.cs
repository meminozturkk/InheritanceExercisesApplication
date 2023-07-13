using Ecosystem;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercisesApplication
{
	internal class Program
	{
		private static List<Animal> animals { get; set; }
        public static List<IGrowable> LivingThings { get; set; }

        static void Main(string[] args)
		{

			CreateAnimals();
			MakeAnimalsEat();

			BreedAnimals();

			GrowLivingThings();

			Console.ReadLine();

		}

		private static void GrowLivingThings()
		{
			foreach (IGrowable livingthing in LivingThings)
			{
				livingthing.Grow();
			}
		}

		private static void BreedAnimals()
		{
			foreach (Animal animal in animals)
			{
				animal.Breed();
			}
		}

		private static void CreateAnimals()
		{

			animals = new List<Animal>();
			LivingThings = new List<IGrowable>();

			LivingThings.Add(new Lion());
			LivingThings.Add(new WhiteTailedDeer());
			LivingThings.Add(new Moose());
			LivingThings.Add(new Plant());

			animals.Add(new Lion());
			animals.Add(new WhiteTailedDeer());
			animals.Add(new Moose());

		}

		private static void MakeAnimalsEat()
		{

			foreach (Animal animal in animals)
			{
				animal.Eat();
			}

		}


	}

}

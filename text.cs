using System;


public class Legolas

{

	public static void Main()

	{

		

		int arrows = 3;

		int enemies = 3;

		int percent = 0;

		

		for(int numberOfArrows = 0; numberOfArrows <= 3; numberOfArrows++)

		{

			arrows--;

			enemies--;


			Console.WriteLine("How many enemies are left?" + enemies);

			

		}	

		

		if(enemies == 0) {

			Console.WriteLine("Legolas lives");

		}

		

		if (enemies != 0) {

			Console.WriteLine("Legolas Dies");

		}

	}


}

using System;

public class Legolas
{
    public static void Main()
    {
        //creating and assigning variables
        int arrows = 8;
        int enemies = 9;
        int percent = 0;
        bool legolasLives = false;
    
        //setting up for loop with integers
        for(int numberOfArrows = 0; numberOfArrows <= 3; numberOfArrows++)
        {
            //removing a value each time the for loop occurs
            //remove value from arrows countand enemies count
            arrows--;
            enemies--;

            Console.WriteLine("How many enemies are left?" + enemies);

            //if statement checking enemy count
            if(enemies == 0) {
                legolasLives = true;
            } else {
                legolasLives = false;
            }
        }   

        //Checking boolean value
        if(legolasLives) {
            Console.WriteLine("Legolas lives");
        } else {
            Console.WriteLine("Legolas Dies");
        }

        //if statement checking enemy count
        if (enemies == 0) {
            //do this
        } else if (enemies == 1) {
            //do this
        } else if (enemies == 2) {//example of if else statement

        } else { //example of else statement
            //do this
        }
        
        if (enemies != 0) {
            Console.WriteLine("Legolas Dies");
        }

        //switch case statement example
        switch (enemies)
        {
            case 0:
                Console.WriteLine("Legolas Lives");
                break;
            case 1:
                break;
            default:
                Console.WriteLine("Legolas Dies");
                break;
        }

        //Contiue with this code...
    }

}
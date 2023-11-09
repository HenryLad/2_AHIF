namespace Rpg.Logic;
using Rpg.Logic;

public class Fight
{
   public Fight(Person character1, Person character2)
   {
      Character1 = character1;
      Character2 = character2;
   }

   public Person Character1 { get; }
   public Person Character2 { get; }
   public int Charc1Wins { get; set; }
   public int Charc2Wins { get; set; }
   public int Helath2 { get; set; }
   public int Helath1 { get; set; }


   public Person ExecuteFight()
   {


      double damage1 = 0;
      double damage2 = 0;
      double defense1 = 0;
      double defense2 = 0;
      int Count = 0;
      int turn = Random.Shared.Next(1, 3);
      do
      {
         double health1 = Helath1;
         double health2 = Helath2;
         do
         {
            if (turn == 1)
            {
               damage1 = Character1.CalulateDamage();
               defense2 = Character2.CalculateDefence();
               if (damage1 > defense2)
               {
                  health2 -= damage1 - defense2;
               }

               turn = 2;
            }
            else
            {
               damage2 = Character2.CalulateDamage();
               defense1 = Character1.CalculateDefence();
               if (damage2 > defense1)
               {
                  health1 -= damage2 - defense1;
               }
               turn = 1;
            }
         } while (health1 > 0 && health2 > 0);
         if (health1 <= 0)
         {
            Charc2Wins++;
            Count++;

         }
         else if(health2 <= 0)
         {
            Charc1Wins++;
            Count++;
         }

      } while (Count < 100);
      return Character1;
   }
}
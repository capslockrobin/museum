using System;

namespace museum_level_2
{
    class Program
    {       
        static void Main(string[] args)
        {
            Random random = new Random();

            int rum = 0;
            int points = 0;

            bool running = true;
            bool fire = false;
            

            while (running)
            {

                Console.WriteLine("Använd siffrorna för menyn för gå i museum");
                Console.WriteLine("Tänk på att du bara kan gå till närliggande rum");
                Console.WriteLine("Använd kartan för att lättast kunna navigera till närliggande rum");
                Console.WriteLine("[0] om du vill gå i lämna museumet");
                Console.WriteLine("[1] om du vill gå till rum ett i museum");
                Console.WriteLine("[2] om du vill gå till rum två i museum");
                Console.WriteLine("[3] om du vill gå till rum tre i museum");
                Console.WriteLine("[4] om du vill gå till rum fyra i museum");
                Console.WriteLine("[5] om du vill gå till rum fem i museum");
                Console.WriteLine("[6] om du vill gå till rum sex i museum");
                Console.WriteLine("[7] om du vill gå till rum sju i museum");
                Console.WriteLine("[8] om du vill kolla på karta över museum");

                int menyNr;
                while (!int.TryParse(Console.ReadLine(), out menyNr) || !(menyNr <= 8 && menyNr >= 0)) //om användaren inte väljer en "int" i menyn
                {
                    Console.WriteLine("Fel, välj en siffra mellan 0-8 i menyn, försök igen!");

                }
                switch (menyNr)
                {
                    case 0:
                        if (fire == true && rum == 1)
                        {
                            points++;
                            Console.WriteLine("Grattis! du han ut ur branden och nu är branden släkt");
                            Console.WriteLine("Du fick " + points + " poäng för rummen du gick igenom efter branden!");
                            Console.WriteLine("[1] Vill du lämna detta skit museum?");
                            Console.WriteLine("[2] Vågar du gå in igen?");

                            while (!int.TryParse(Console.ReadLine(), out menyNr) || !(menyNr <= 2 && menyNr >= 1)) //om användaren inte väljer en "int" i menyn
                            {
                                Console.WriteLine("Fel, välj en siffra mellan 1-2 i menyn, försök igen!");
                            }
                            switch (menyNr)
                            {
                                case 1:
                                    Console.WriteLine("Bra, vi skiter i det här");
                                    running = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Okej vi testar igen");
                                    fire = false;
                                    points = 0;
                                    rum = 0;
                                    break;                               
                            }

                        }
                        else if (rum == 1 || rum == 0)
                        {
                            Console.WriteLine("Du lämna nu museumet!");
                            running = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du kan bara lämna museumet när du befinner dig i rum 1!");

                        }
                        break;
                    case 1:
                        if (fire == true && rum == 2 || rum == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Du är i rum 1, men det brinner fortfarande, UT!");
                            rum = 1;
                            points++;
                        }
                        else if (rum == 0 || rum == 2 || rum == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 1, här fins mona lisa");
                            rum = 1;
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum" + rum);
                        }

                        break;
                    case 2:
                        if (fire == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");
                            running = false;
                        }
                        else if (rum == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 2, hät finns bara toa");
                            rum = 2;                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 3:
                        if (fire == true && rum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Du är i rum 3, men det brinner fortfarande, UT!");
                            rum = 3;
                            points++;
                        }
                        else if (fire == true && rum == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");
                            running = false;
                        }
                        else if (rum == 1 || rum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 3, här ser man fina tavlor");
                            rum = 3;
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 4:
                        if (fire == true && rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du är i rum 4, men det brinner fortfarande, UT!");
                            rum = 4;
                            points++;
                        }
                        else if (fire == true && rum == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");
                            running = false;
                        }
                        else if (rum == 3 || rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 4, här finns codex vaticanus");
                            rum = 4;                           
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 5:
                        if (fire == true && (rum == 6 || rum == 7))
                        {
                            Console.Clear();
                            Console.WriteLine("Du är i rum 5, men det brinner fortfarande, UT!");
                            rum = 5;
                            points++;
                        }
                        else if (fire == true && rum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");
                            running = false;
                        }
                        else if (rum == 4 || rum == 6 || rum == 7)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 5, här finns skulpturer");
                            rum = 5;                           
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 6:
                        if (fire == true && rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");
                            running = false;
                        }
                        else if (rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 6, här finns konst från sverige");
                            rum = 6;                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 7:
                        if (fire == true && rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du gick åt fel håll och dog i lågorna!");                            
                            running = false;
                        }
                        else if (rum == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Du ser nu rum 7, här finns abstrakt konst");
                            rum = 7;                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste gå till ett närliggande rum, just nu är du i rum " + rum);
                        }
                        break;
                    case 8:
                        if (rum == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Du är utanför museumet nu, börja med att gå in i rum ett");
                            Console.WriteLine("_________________");
                            Console.WriteLine("|****|  7  |****|");
                            Console.WriteLine("|****|_____|____|");
                            Console.WriteLine("|****|  5  | 6  |");
                            Console.WriteLine("|****|_____|____|");
                            Console.WriteLine("|****|  4  |****|");
                            Console.WriteLine("|****|_____|****|");
                            Console.WriteLine("|****|  3  |****|");
                            Console.WriteLine("|____|_____|****|");
                            Console.WriteLine("| 2  |  1  |****|");
                            Console.WriteLine("|    |     |****|");
                            Console.WriteLine("´´´´´´in/ut``````");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("just nu befinner du dig i rum " + rum);
                            Console.WriteLine("_________________");
                            Console.WriteLine("|****|  7  |****|");
                            Console.WriteLine("|****|_____|____|");
                            Console.WriteLine("|****|  5  | 6  |");
                            Console.WriteLine("|****|_____|____|");
                            Console.WriteLine("|****|  4  |****|");
                            Console.WriteLine("|****|_____|****|");
                            Console.WriteLine("|****|  3  |****|");
                            Console.WriteLine("|____|_____|****|");
                            Console.WriteLine("| 2  |  1  |****|");
                            Console.WriteLine("|    |     |****|");
                            Console.WriteLine("´´´´´´in/ut``````");
                        }

                        break;
                }

                if (fire == false) // detta är inne i loopen och ser om det börjar brinna varje gång
                {
                    int temp = random.Next(0, 10);
                    if (temp == 5)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("MEN Det börja plötsligt brinna i museumet! nu måste du skynda dig ut");
                        Console.WriteLine("går du åt fel håll nu så dör du i lågorna!");
                        Console.WriteLine(" ");
                        fire = true; 
                    }
                }
                
            }
        }
    }
}

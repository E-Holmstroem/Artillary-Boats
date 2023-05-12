using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artillary_Boats_v2
{
    internal class Program
    {
        //Declarations
        public int[,] FieldP1 = new int[5, 5];
        public int[,] FieldP2 = new int[5, 5];

        public int[,] HitMapP1 = new int[5, 5];
        public int[,] HitMapP2 = new int[5, 5];

        public int P1Hits = 0;
        public int P1Wins = 0;

        public int P2Hits = 0;
        public int P2Wins = 0;

        public int Draws = 0;

        public int boats = 0;
        public string sboats = "";

        public string FieldLine = "";

        static Program Player = new Program();

        //Methods
        static void Main(string[] args)
        {

            Player.Menu();

        }

        public void PrintField(int p)
        {
            if (p == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 4; i > -1; i--)
                {
                    if ( i < 4) { Console.WriteLine("  | ----------------- |"); }
                    
                    for (int l = 0; l < 5; l++)
                    {
                        FieldLine = FieldLine + MarkConverter(FieldP1[i, l]) + " | ";
                        if (l == 4) 
                        { 
                            switch (i)
                            { 
                                    case 0: Console.WriteLine( " 1| " + FieldLine + "\n  |___________________| \n    1   2   3   4   5");
                                        break;
                                    case 1: Console.WriteLine( " 2| " + FieldLine );
                                        break ;
                                    case 2: Console.WriteLine( " 3| " + FieldLine );
                                        break ;
                                    case 3: Console.WriteLine( " 4| " + FieldLine );
                                        break ;
                                    case 4: Console.WriteLine( " 5| " + FieldLine );
                                        break ;
                            }
                            
                            FieldLine = ""; 
                        }
                    }
                }

                Console.ResetColor();
            }

            if (p == 11)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 4; i > -1; i--)
                {
                    if (i < 4) { Console.WriteLine("  | ----------------- |"); }

                    for (int l = 0; l < 5; l++)
                    {
                        FieldLine = FieldLine + MarkConverter(HitMapP1[i, l]) + " | ";
                        if (l == 4)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine(" 1| " + FieldLine + "\n  |___________________| \n    1   2   3   4   5");
                                    break;
                                case 1:
                                    Console.WriteLine(" 2| " + FieldLine);
                                    break;
                                case 2:
                                    Console.WriteLine(" 3| " + FieldLine);
                                    break;
                                case 3:
                                    Console.WriteLine(" 4| " + FieldLine);
                                    break;
                                case 4:
                                    Console.WriteLine(" 5| " + FieldLine);
                                    break;
                            }

                            FieldLine = "";
                        }
                    }
                }

                Console.ResetColor();

            }

            if (p == 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 4; i > -1; i--)
                {
                    if (i < 4) { Console.WriteLine("  | ----------------- |"); }

                    for (int l = 0; l < 5; l++)
                    {
                        FieldLine = FieldLine + MarkConverter(FieldP2[i, l]) + " | ";
                        if (l == 4)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine(" 1| " + FieldLine + "\n  |___________________| \n    1   2   3   4   5");
                                    break;
                                case 1:
                                    Console.WriteLine(" 2| " + FieldLine);
                                    break;
                                case 2:
                                    Console.WriteLine(" 3| " + FieldLine);
                                    break;
                                case 3:
                                    Console.WriteLine(" 4| " + FieldLine);
                                    break;
                                case 4:
                                    Console.WriteLine(" 5| " + FieldLine);
                                    break;
                            }

                            FieldLine = "";
                        }
                    }
                }

                Console.ResetColor();
            }

            if (p == 22)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 4; i > -1; i--)
                {
                    if (i < 4) { Console.WriteLine("  | ----------------- |"); }

                    for (int l = 0; l < 5; l++)
                    {
                        FieldLine = FieldLine + MarkConverter(HitMapP2[i, l]) + " | ";
                        if (l == 4)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine(" 1| " + FieldLine + "\n  |___________________| \n    1   2   3   4   5");
                                    break;
                                case 1:
                                    Console.WriteLine(" 2| " + FieldLine);
                                    break;
                                case 2:
                                    Console.WriteLine(" 3| " + FieldLine);
                                    break;
                                case 3:
                                    Console.WriteLine(" 4| " + FieldLine);
                                    break;
                                case 4:
                                    Console.WriteLine(" 5| " + FieldLine);
                                    break;
                            }

                            FieldLine = "";
                        }
                    }
                }

                Console.ResetColor();
            }
        }

        public void Place(int p, int y, int x)
        {
            if (p == 1)
            {
                if (FieldP1[x, y] == 0)
                { FieldP1[x, y]++; Console.Clear(); }
                else if (FieldP1[x, y] == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Space occupied!");
                    Console.WriteLine();
                    PrintField(1);
                    Console.WriteLine();
                    Console.WriteLine("Choose a new X Coordinate");
                    int nx = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("Choose a new Y Coordinate");
                    int ny = Convert.ToInt32(Console.ReadLine()) - 1;
                    Place(1, nx, ny);
                }

            }
            if (p == 2)
            {
                if (FieldP2[x, y] == 0)
                { FieldP2[x, y]++; Console.Clear(); }
                else if (FieldP2[x, y] == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Space occupied!");
                    Console.WriteLine();
                    PrintField(2);
                    Console.WriteLine();
                    Console.WriteLine("Choose a new X Coordinate");
                    int nx = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("Choose a new Y Coordinate");
                    int ny = Convert.ToInt32(Console.ReadLine()) - 1;
                    Place(2, nx, ny);
                }
            }
        }

        public void AskToPlace(int p)
        {
            if (p == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 1 : Where is your boat?");
                Console.ResetColor();
                PrintField(1);
                Console.WriteLine();
                Console.WriteLine("X coordinate :");
                int p1x1 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Y coordinate :");
                int p1y1 = Convert.ToInt32(Console.ReadLine()) - 1;

                if (p1x1 <= 4 && p1x1 >= 0) { if (p1y1 <= 4 && p1y1 >= 0) { Place(p, p1x1, p1y1); } else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToPlace(1); } }
                else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToPlace(1); }


            }
            else if (p == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Player 2 : Where is your boat?");
                Console.ResetColor();
                PrintField(2);
                Console.WriteLine();
                Console.WriteLine("X coordinate :");
                int p2x1 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Y coordinate :");
                int p2y1 = Convert.ToInt32(Console.ReadLine()) - 1;

                if (p2x1 <= 4 && p2x1 >= 0) { if (p2y1 <= 4 && p2y1 >= 0) { Place(p, p2x1, p2y1); } else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToPlace(2); } }
                else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToPlace(2); }
            }
        }
        
        public void Shoot(int p, int y, int x)
        {
            if (p == 1)
            {
                if (FieldP2[x, y] == 1) { FieldP2[x, y]++; HitMapP1[x, y]++; Console.Clear(); Console.WriteLine("Your shot shattered a boat!"); P1Hits++; if (P1Hits != boats) { AskToShoot(p); }; Console.Clear(); }
                else if (FieldP2[x, y] == 0) { FieldP2[x, y]--; HitMapP1[x, y] = 2; Console.WriteLine("Your shot did not hit a boat!"); Console.ReadLine(); Console.Clear(); }
                else { Console.WriteLine("Already Shot There"); Console.ReadLine(); Console.Clear(); }
            }

            else if (p == 2)
            {
                if (FieldP1[x, y] == 1) { FieldP1[x, y]++; HitMapP2[x, y]++; Console.Clear(); Console.WriteLine("Your shot shattered a boat!"); P2Hits++; if (P2Hits != boats) { AskToShoot(p); } Console.Clear(); }
                else if (FieldP1[x, y] == 0) { FieldP1[x, y]--; HitMapP2[x, y] = 2; Console.WriteLine("Your shot did not hit a boat!"); Console.ReadLine(); Console.Clear(); }
                else { Console.WriteLine("Already Shot There"); Console.ReadLine(); Console.Clear(); }
            }
        }

        public void AskToShoot(int p)
        {
            if (p == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 1 : Where will you shoot?");
                Console.ResetColor();
                PrintField(11);
                Console.WriteLine("X coordinate :");
                int p1x1 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Y coordinate :");
                int p1y1 = Convert.ToInt32(Console.ReadLine()) - 1;

                if (p1x1 <= 4 && p1x1 >= 0) { if (p1y1 <= 4 && p1y1 >= 0) { Shoot(p, p1x1, p1y1); } else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToShoot(1); } }
                else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToShoot(1); }
            }

            else if (p == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Player 2 : Where will you shoot?");
                Console.ResetColor();
                PrintField(22);
                Console.WriteLine("X coordinate :");
                int p1x1 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Y coordinate :");
                int p1y1 = Convert.ToInt32(Console.ReadLine()) - 1;

                if (p1x1 <= 4 && p1x1 >= 0) { if (p1y1 <= 4 && p1y1 >= 0) { Shoot(p, p1x1, p1y1); } else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToShoot(2); } }
                else { Console.WriteLine("Invalid Coordinate. Please try again!"); Console.ReadLine(); Console.Clear(); AskToShoot(2); }
            }
        }

        public string MarkConverter(int x)
        {
            switch (x)
            {
                case 0:
                    return "*";

                case 1:
                    return "X";

                case 2:
                    return "O";
                default:
                    return "0";

            }
        }

        public void Intro()
        {
            
            PrintField(1);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This here is your map \n");
            Console.WriteLine("It is based of of an X and Y coordinate system \n");
            Console.WriteLine("The lowest available value for both x and y is 1");
            Console.WriteLine("The highest available value for both x and y is 5 \n");
            Console.WriteLine("You will be asked to place a boat according to this layout \n");
            Console.WriteLine("The goal is to sink the other persons boat");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        public void Boats()
        {
            
            Console.WriteLine("How many boats would you like each?");
            
            if (!int.TryParse(Console.ReadLine(), out boats))
            {
                Console.Clear(); Console.WriteLine("value invalid! Please try again"); Boats();
            }
            else if (boats <= 0 || boats > 25) { Console.Clear(); Console.WriteLine("value invalid! Please try again"); Boats(); }
            else
            { 
                Console.Clear();

                for (int i = 0; i < boats; i++) { AskToPlace(1); }
                Console.Clear();

                for (int i = 0; i < boats; i++) { AskToPlace(2); }
                Console.Clear();
            }

        }

        public void Play()
        {
            AskToShoot(1);


            AskToShoot(2);


            CheckWin();
        }

        public void AsciiBoat()
        {
            Console.WriteLine("      _~");
            Console.WriteLine("   _~)_)_~");
            Console.WriteLine("  )_))_))_)");
            Console.WriteLine("  _|__|__|_");
            Console.WriteLine("  L_______/");
            Console.WriteLine("~~~~~~~~~~~~~~");
        }

        public void Again()
        {
            Console.Clear();
            Console.WriteLine(" Player | Wins ");
            Console.WriteLine("  1     | " + P1Wins);
            Console.WriteLine("  2     | " + P2Wins);
            Console.WriteLine(" -------------");
            Console.WriteLine(" Draws : " + Draws);


            Console.WriteLine("Press \"enter\" to continue"); Console.ReadLine(); Console.Clear(); Wipe(); Menu(); 
        }

        public void Wipe()
        {
            FieldP1 = new int[5, 5];
            FieldP2 = new int[5, 5];

            HitMapP1 = new int[5, 5];
            HitMapP2 = new int[5, 5];

            P1Hits = 0;
            P2Hits = 0;
            boats = 0;
        }

        public void CheckWin()
        {
            if (P1Hits == P2Hits && P1Hits == boats) { Console.Clear(); Console.WriteLine("      :::::::::  :::::::::      :::     :::       :::                     ::: \r\n     :+:    :+: :+:    :+:   :+: :+:   :+:       :+:         :+:        :+:   \r\n    +:+    +:+ +:+    +:+  +:+   +:+  +:+       +:+                   +:+     \r\n   +#+    +:+ +#++:++#:  +#++:++#++: +#+  +:+  +#+                   +#+      \r\n  +#+    +#+ +#+    +#+ +#+     +#+ +#+ +#+#+ +#+                   +#+       \r\n #+#    #+# #+#    #+# #+#     #+#  #+#+# #+#+#          #+#        #+#       \r\n#########  ###    ### ###     ###   ###   ###                       ###       "); Draws++; Console.ReadLine(); Again(); }
            else if (P1Hits == boats) { Console.Clear(); Console.WriteLine("      :::::::::    :::        :::       ::: ::::::::::: ::::    :::  :::::::: \r\n     :+:    :+: :+:+:        :+:       :+:     :+:     :+:+:   :+: :+:    :+: \r\n    +:+    +:+   +:+        +:+       +:+     +:+     :+:+:+  +:+ +:+         \r\n   +#++:++#+    +#+        +#+  +:+  +#+     +#+     +#+ +:+ +#+ +#++:++#++   \r\n  +#+          +#+        +#+ +#+#+ +#+     +#+     +#+  +#+#+#        +#+    \r\n #+#          #+#         #+#+# #+#+#      #+#     #+#   #+#+# #+#    #+#     \r\n###        #######        ###   ###   ########### ###    ####  ########       "); P1Wins++; Console.ReadLine(); Again(); }
            else if (P2Hits == boats) { Console.Clear(); Console.WriteLine("      :::::::::   ::::::::        :::       ::: ::::::::::: ::::    :::  :::::::: \r\n     :+:    :+: :+:    :+:       :+:       :+:     :+:     :+:+:   :+: :+:    :+: \r\n    +:+    +:+       +:+        +:+       +:+     +:+     :+:+:+  +:+ +:+         \r\n   +#++:++#+      +#+          +#+  +:+  +#+     +#+     +#+ +:+ +#+ +#++:++#++   \r\n  +#+          +#+            +#+ +#+#+ +#+     +#+     +#+  +#+#+#        +#+    \r\n #+#         #+#              #+#+# #+#+#      #+#     #+#   #+#+# #+#    #+#     \r\n###        ##########         ###   ###   ########### ###    ####  ########       "); P2Wins++; Console.ReadLine(); Again(); }
            else { Play(); }
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1: P1 vs P2");
            Console.WriteLine("2: P1 vs Bot");
            Console.WriteLine("3: Scoreboard");
            Console.WriteLine("4: Clear Scores");
            Console.WriteLine("5: Rules \n");
            Console.WriteLine("6: Exit Game \n");
            string menuchoice = Console.ReadLine();
            Console.Clear();
            switch (menuchoice)
            {
                case "1": Boats(); Play();
                    break;
                case "2": Console.WriteLine("This feature is out order"); Console.ReadLine(); Menu();
                    break;
                case "3": Again();
                    break;
                case "4": P1Wins = 0; P2Wins = 0; Draws = 0; Menu();
                    break;
                case "5": Intro();
                    break;
                case "6": Environment.Exit(0);
                    break;
                default: Menu(); 
                    break;

                   
            }

        }

       

    }
}

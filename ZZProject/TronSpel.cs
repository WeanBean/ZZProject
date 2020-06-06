using System;
using System.Threading;
using static ZZProject.Skriv;
//fixa ai samt kometarer
namespace ZZProject { 
    public class TronSpel {
        
        private static Riktning Spelare1Riktning;
        private static int Spelare1LodrattPosition;
        private static int Spelare1VagrattPosition;
        private static int Spelare1Poeng = 0;

        private static int Spelare2LodrattPosition;
        private static Riktning Spelare2Riktning;
        private static int Spelare2VagrattPosition;
        private static int Spelare2Poeng = 0;
        
        private static bool[,] TronAnvands;


        public static void TronStart() {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            SpawnPositioner();
            Instruktioner();

            TronAnvands = new bool[Console.WindowWidth,Console.WindowHeight];

            while (true) {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo knappinfo = Console.ReadKey(true);
                    ConsoleKey knapp = knappinfo.Key;
                    switch (knapp) {
                        case ConsoleKey.Escape:
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Spelare2Riktning != Riktning.Hoger) {
                                Spelare2Riktning = Riktning.Vanster;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (Spelare2Riktning != Riktning.Ned) {
                                Spelare2Riktning = Riktning.Upp;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (Spelare2Riktning != Riktning.Vanster) {
                                Spelare2Riktning = Riktning.Hoger;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (Spelare2Riktning != Riktning.Upp) {
                                Spelare2Riktning = Riktning.Ned;
                            }
                            break;
                        case ConsoleKey.A:
                            if (Spelare1Riktning != Riktning.Hoger) {
                                Spelare1Riktning = Riktning.Vanster;
                            }
                            break;
                        case ConsoleKey.D:
                            if (Spelare1Riktning != Riktning.Vanster) {
                                Spelare1Riktning = Riktning.Hoger;
                            }
                            break;
                        case ConsoleKey.S:
                            if (Spelare1Riktning != Riktning.Upp) {
                                Spelare1Riktning = Riktning.Ned;
                            }
                            break;
                        case ConsoleKey.W:
                            if (Spelare1Riktning != Riktning.Ned) {
                                Spelare1Riktning = Riktning.Upp;
                            }
                            break;
                        default:
                            break;
                    }

                }

                TronRorelser();

                bool Spelare1Vann = HarSpelareForlorat(Spelare1VagrattPosition,Spelare1LodrattPosition);
                bool Spelare2Vann = HarSpelareForlorat(Spelare2VagrattPosition,Spelare2LodrattPosition);
                    if (Spelare1Vann && Spelare2Vann) {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        SkrivUtTron("Draw game!!!");
                        SkrivUtTron($"Current score: {Spelare1Poeng} - {Spelare2Poeng}");
                        ResetGame();
                    }
                    if (Spelare1Vann && !Spelare2Vann) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Spelare2Poeng++;
                        SkrivUtTron("Second player wins!!!");
                        SkrivUtTron($"Current score: {Spelare1Poeng} - {Spelare2Poeng}");
                        ResetGame();
                    }
                    if (Spelare2Vann && !Spelare1Vann) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Spelare1Poeng++;
                        SkrivUtTron("First player wins!!!");
                        SkrivUtTron($"Current score: {Spelare1Poeng} - {Spelare2Poeng}");
                        ResetGame();
                    }
                
                    if (Spelare2Poeng == 5) {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        SkrivUtTron("PLAYER TWO WINS!");
                        SkrivUtTron("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (Spelare1Poeng == 5) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        SkrivUtTron("PLAYER ONE WINS!");
                        SkrivUtTron("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                Skriv.SkrivUtPosition(Spelare1LodrattPosition,Spelare1VagrattPosition,'0',ConsoleColor.Blue);
                Skriv.SkrivUtPosition(Spelare2LodrattPosition,Spelare2VagrattPosition,'0',ConsoleColor.Red);
                TronAnvands[Spelare1LodrattPosition,Spelare1VagrattPosition] = true;
                TronAnvands[Spelare2LodrattPosition,Spelare2VagrattPosition] = true;
                Thread.Sleep(100);
            }
        }
        private static void TronRorelser() {
            if (Spelare1Riktning == Riktning.Vanster) {
                Spelare1LodrattPosition++;
            }
            if (Spelare1Riktning == Riktning.Hoger) {
                Spelare1LodrattPosition--;
            }
            if (Spelare1Riktning == Riktning.Upp) {
                Spelare1VagrattPosition--;
            }
            if (Spelare1Riktning == Riktning.Ned) {
                Spelare1VagrattPosition++;
            }
            if (Spelare2Riktning == Riktning.Vanster) {
                Spelare2LodrattPosition++;
            }
            if (Spelare2Riktning == Riktning.Hoger) {
                Spelare2LodrattPosition--;
            }
            if (Spelare2Riktning == Riktning.Upp) {
                Spelare2VagrattPosition--;
            }
            if (Spelare2Riktning == Riktning.Ned) {
                Spelare2VagrattPosition++;
            }
        }

        private static bool HarSpelareForlorat(int row,int col) {
            if (row <= 0) {
                return true;
            }
            if (col <= 0) {
                return true;
            }
            if (row >= Console.WindowHeight) {
                return true;
            }
            if (col >= Console.WindowWidth) {
                return true;
            }

            if (TronAnvands[col,row]) {
                return true;
            }

            return false;
        }

        private static void Instruktioner() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            SkrivUtTron("A simple tron-like game");

            Console.ForegroundColor = ConsoleColor.Blue;
            SkrivUtTron("Player 1's controls:");
            SkrivUtTron("W - Up");
            SkrivUtTron("A - Left");
            SkrivUtTron("S - Down");
            SkrivUtTron("D - Right");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            SkrivUtTron("Player 2's controls:");
            SkrivUtTron("Up Arrow - Up");
            SkrivUtTron("Left Arrow - Left");
            SkrivUtTron("Down Arrow - Down");
            SkrivUtTron("Right Arrow - Right");

            Console.ReadKey();
            Console.Clear();
        }




        private static void ResetGame() {
            TronAnvands = new bool[Console.WindowWidth,Console.WindowHeight];
            SpawnPositioner();

            SkrivUtTron("Press any key to Continue...");
            Console.ReadKey();
            Console.Clear();
            TronRorelser();
        }

        private static void SpawnPositioner() {
            Spelare1LodrattPosition = 0;
            Spelare1VagrattPosition = Console.WindowHeight / 2;

            Spelare2LodrattPosition = Console.WindowWidth - 1;
            Spelare2VagrattPosition = Console.WindowHeight / 2;

            Spelare1Riktning = Riktning.Vanster;
            Spelare2Riktning = Riktning.Hoger;
        }
        
    }
}
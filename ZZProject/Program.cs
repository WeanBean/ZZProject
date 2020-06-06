using System;
using System.Globalization;

namespace ZZProject {
    class Program {
        public static int SpelÄrPå = 1;
        public static Människan spelare;
        static void Main() {
            SpelarNamnOchBeskrivningInmatning();
            Huvudsaken();
        }

        private static void Huvudsaken() {
            do {
                KnappTryck();
            } while (SpelÄrPå == 1);
        }

        public static void SpelarNamnOchBeskrivningInmatning() {
            string Namn;
            string UnikBeskrivning;
            string FixaNamn;
            Console.WriteLine("Ange Ditt Namn");
            FixaNamn = TaFramNamn("Namn: ");
            Namn = NamnKapitaliserare(FixaNamn);
            Console.WriteLine($"Du Har Angivit Namnet:{Namn}");
        Askagain:
                Console.WriteLine("Vill Du Skapa En Egen Beskrvining Av Dig?");
                Console.WriteLine("Y/N");
                ConsoleKeyInfo KnappInfo = Console.ReadKey(true);
                ConsoleKey JaEllerNej = KnappInfo.Key;
                switch (JaEllerNej) {
                    case ConsoleKey.Y:
                        goto Yes;
                    case ConsoleKey.N:
                        goto No;
                    case ConsoleKey.F23:
                        Yes:
                         UnikBeskrivning = null;
                         SpelarBeskrivning(UnikBeskrivning);
                         spelare = new Människan(Namn, UnikBeskrivning);
                        break;
                    case ConsoleKey.F24:
                        No:
                        spelare = new Människan(Namn);
                        Huvudsaken();
                        break;
                    default:
                    goto Askagain;
                }

        }
        //fixar stor bokstav i början på namnet av spelaren
        private static string TaFramNamn(string NamnInMatning) {
            //skriver ut texten inom paranteser och sitattäken som kommer från en en sådan -> TaFramNamn("EXEMPEL TEXT ");
            Console.Write(NamnInMatning);
            string NamnUtMatning = Console.ReadLine().Trim();
            //kollar om det är några bokstäver i input om inte loopar tills man skriver nåt tar också bort tomarutor
            while (string.IsNullOrWhiteSpace(NamnUtMatning)) {
                Console.WriteLine("Your name can't be empty.");
                Console.Write("Name: ");
                NamnUtMatning = Console.ReadLine().Trim();
            }
            //sickar namnet som blev inmatat 
            return NamnUtMatning;
        }

        //omandlar usernamet så att den har en storbokstav i början av sig
        static string NamnKapitaliserare(string FixaNamn) {
            //inför kulturen på namnet 
            string Namn = new CultureInfo("sv-SE")
                .TextInfo
                .ToTitleCase(FixaNamn);//gör så att namnet får enn stor bokstav
            //sickartillbaka fixat namn 
            return Namn;
        }
        private static string SpelarBeskrivning(string UnikBeskrivning) {
            while (UnikBeskrivning is null) {
                Console.WriteLine("Ange En Beskrvining");
                UnikBeskrivning = Console.ReadLine();
            }
            return UnikBeskrivning;
        }

        private static void KnappTryck() {
            ConsoleKeyInfo KnappInfo = Console.ReadKey(true);
            ConsoleKey Knapp = KnappInfo.Key;
            SpelarKontroller(Knapp);
        }

        private static void SpelarKontroller(ConsoleKey Knapp) {
            switch (Knapp) {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Escape:
                    SpelÄrPå = 0;
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.H:
                    break;
            }
        }
    }
}

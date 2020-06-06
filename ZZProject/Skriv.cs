using System;
using System.Threading;
/*
+§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§+
§                                                 §
§                  Innehåll.                      §                 
§                                                 §
§                                                 §
§                                                 §
§   metooder som skapar skrivmaskin effekter      §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
§                                                 §
+§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§+
*/

namespace ZZProject {
    public class Skriv {      

        //skapar en skrivmaskin effect för stringgs
        public static void SkrivUt(string taptap) {
            Console.SetCursorPosition((Console.WindowWidth - taptap.Length) / 2,Console.CursorTop);
            //söver tråden för 43 milisecunder efter varje char i stringen
            foreach (char z in taptap.ToCharArray()) {
                Console.Write(z);
                Thread.Sleep(43);
            }
            //gör en ny rad för nästa text
            Console.WriteLine();
        }
        //skapar en skrivmaskin effect för string arrayer
        public static void SkrivArrayUt(string tiptap) {
            Console.SetCursorPosition((Console.WindowWidth - 11) / 2,Console.CursorTop);
            //söver tråden för 20 milisecunder efter varje char i stringen
            foreach (char x in tiptap.ToCharArray()) {
                Console.Write(x);
            }
            //gör en ny rad för nästa text
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void SkrivUtTron(string Trontap) {
            Console.SetCursorPosition((Console.WindowWidth - Trontap.Length) / 2,Console.CursorTop);
            //söver tråden för 20 milisecunder efter varje char i stringen
            foreach (char x in Trontap.ToCharArray()) {
                Console.Write(x);
                Thread.Sleep(10);

            }
            //gör en ny rad för nästa text
            Console.WriteLine();
            Console.WriteLine();

        }
        //skapar en skrivmaskin effect för stringgs som ska ta inmatning på sama rad som de själva
        public static void SkrivSamaRadUt(string tiptop) {
            Console.SetCursorPosition((Console.WindowWidth - tiptop.Length) / 2,0);

            foreach (char y in tiptop.ToCharArray()) {
                Console.Write(y);
            }

        }
        public static void SkrivSamaRadUtAntiBlinkning(string trptop) {
            Console.SetCursorPosition((Console.WindowWidth - trptop.Length - 4) / 2,0);

            foreach (char y in trptop.ToCharArray()) {
                Console.Write(y);
            }

        }
        //skapar en skrivmaskin effect för Titlel och konst
        public static void TitelArtUt(string tuptip) {
            Console.SetCursorPosition((Console.WindowWidth - tuptip.Length) / 2,Console.WindowHeight / 2 - 8);
            //söver tråden för 1 milisecunder efter varje char i stringen
            foreach (char e in tuptip.ToCharArray()) {
                Console.Write(e);
                Thread.Sleep(23);

            }
            Console.WriteLine();

        }
        public static void SkrivNastaRad(string NastaRad) {
            Console.SetCursorPosition((Console.WindowWidth - NastaRad.Length) / 2,Console.CursorTop);
            //söver tråden för 1 milisecunder efter varje char i stringen
            foreach (char e in NastaRad.ToCharArray()) {
                Console.Write(e);
                Thread.Sleep(23);
            }
            Console.WriteLine(); 
        }
        public static void SkrivUtPosition(int X,int Y,char Char,ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(X,Y);
            Console.Write(Char);
        }
        public static void SkrivUtPosition(int X, int Y, string TxT, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(X, Y);
            Console.Write(TxT);
        }
        public static void SkrivUtPosition(int X,int Y,char Char,ConsoleColor colorF, ConsoleColor colorB) {
            Console.ForegroundColor = colorF;
            Console.BackgroundColor = colorB;
           Console.SetCursorPosition(X,Y);
            Console.Write(Char);
        }
        public static void SkrivPostionUt(char Char, Postion Position) {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Char);
        }        
        public static void SkrivPostionUt(string TxT, Postion Position) {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(TxT);

        }
    }
}


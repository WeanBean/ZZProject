using System;
using System.Collections.Generic;
using System.Text;
using static ZZProject.Program;

namespace ZZProject {
    class Föremål : IArtikel {
        public Föremålen Föremålet { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public int PengVärde { get; set; }

        public void Använd() {
            if (Föremålet == Föremålen.HälsoDricka) {
                HälsoDryck.AnvändHälsoDricka();
            }
        }
        public void Sälj() {

        }
    }
    class HälsoDryck : Föremål {
        private readonly Föremålen HälsoDricka = Föremålen.HälsoDricka;
        private static int HealMängd { get; set; }
        public HälsoDryck(int healmängd) {
            Föremålet = HälsoDricka;
            HealMängd = healmängd;
        }
        public static void AnvändHälsoDricka() {
            int HealMängden = HealMängd;
            AnvändHälsoDryck(HealMängden);
        }
        private static void AnvändHälsoDryck(int healmängd) {
            spelare.Heal(healmängd);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace ZZProject {
    public interface IArtikel {
        Föremålen Föremålet { get; set; }
        string Namn { get; set; }
        string Beskrivning { get; set; }
        int PengVärde { get; set; }
        void Använd();
        void Sälj();
    }
    interface IVarelse {
        Varelser Varelsen { get; set; }
        string Namn { get; set; }
        string Beskrivning { get; set; }
        string VarelseBeskrivning { get; set; }
        //Stats Strength, Speed, Endurense, Inteligens, Vitality, Dexterity, luck 
        float Strength { get; set; }
        float Speed { get; set; }
        float Endurense { get; set; }
        float Inteligens { get; set; }
        float Vitality { get; set; }
        float Dexterity { get; set; }
        float Luck { get; set; }
        //atack värden
        float VarelseMinAttack { get; set; }
        float VarelseMaxAttack { get; set; }
        //Hälso Värde 
        int MaxHälsa { get; set; }
        static int Hälsa { get; set; }
        void Skada(int skada);
        void Heal(int heal);
    }
}

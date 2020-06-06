namespace ZZProject {
    public class Varelse : IVarelse {
        public Varelser Varelsen { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string VarelseBeskrivning { get; set; }
        //Stats Strength, Speed, Endurense, Inteligens, Vitality, Dexterity, luck 
        public float Strength { get; set; }
        public float Speed { get; set; }
        public float Endurense { get; set; }
        public float Inteligens { get; set; }
        public float Vitality { get; set; }
        public float Dexterity { get; set; }
        public float Luck { get; set; }
        //atack värden
        public float VarelseMinAttack { get; set; }
        public float VarelseMaxAttack { get; set; }
        //Hälso Värde 
        public int MaxHälsa { get; set; }
        public static int Hälsa { get; set; }
        public void Skada(int skada) {
            if (skada + Hälsa <= 0) {
                Hälsa = 0;  
            }
            if (skada + Hälsa >= 0) {
                Hälsa -= skada;
            }
        }
        public void Heal(int heal) {
            if (heal + Hälsa >= MaxHälsa) {
                Hälsa = MaxHälsa;
            }
            if (heal + Hälsa <= MaxHälsa) {
                Hälsa += heal;
            }
        }
    }
    public class Människan : Varelse {
        private readonly Varelser Människa = Varelser.Människa;
        //Stats Värden
        private readonly float MänniskaBasStrength = 13;
        private readonly float MänniskaBasSpeed = 13;
        private readonly float MänniskaBasEndurense = 13;
        private readonly float MänniskaBasInteligens = 13;
        private readonly float MänniskaBasVitality = 13;
        private readonly float MänniskaBasDexterity = 13;
        private readonly float MänniskaBasluck = 13;
        //atack värden
        private readonly float MänniskaBasAttackMin = 13;
        private readonly float MänniskaBasAttackMax = 13;
        private readonly string BeskrivningMänniska = "Människor Är En Typ Av Varelse Med Genomsnittliga Stat Värden";
        public Människan(string namn,string UnikBeskrivning = "Om Ingen Beskrivning Finns Ser Du Detta") {
            Namn = namn;
            Beskrivning = UnikBeskrivning;
            VarelseBeskrivning = BeskrivningMänniska;
            Varelsen = Människa; 
            Strength = MänniskaBasStrength;
            Speed = MänniskaBasSpeed;
            Endurense = MänniskaBasEndurense;
            Inteligens = MänniskaBasInteligens;
            Vitality = MänniskaBasVitality;
            Dexterity = MänniskaBasDexterity;
            Luck = MänniskaBasluck;
            VarelseMinAttack = MänniskaBasAttackMin;
            VarelseMaxAttack = MänniskaBasAttackMax;
        }
    }
}

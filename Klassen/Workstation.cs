namespace RechnerVerwaltung.Klassen {
    internal class Workstation: Rechner {
        public decimal LeistungCPU { get; set; }
        public decimal GroesseRam { get; set; }
        public decimal GroesseSSD { get; set; }

        public Workstation( string name, string ipAdresse, decimal leistungCPU, decimal groesseRam, decimal groesseSSD ) : base( name, ipAdresse ) {
            LeistungCPU = leistungCPU;
            GroesseRam = groesseRam;
            GroesseSSD = groesseSSD;
        }

        public override string ToString() {
            return $"Leistung CPU: {LeistungCPU} GHz\n" +
                $"Ram: {GroesseRam} Gigabyte\n" +
                $"Kapazität SSD: {GroesseSSD} Gigabyte\n" +
                base.ToString();
        }
    }
}

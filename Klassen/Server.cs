namespace RechnerVerwaltung.Klassen {
    internal class Server: Rechner {
        public int AnzahlCPU { get; set; }
        public decimal LeistungCPU { get; set; }
        public decimal GroesseRam { get; set; }
        public int AnzahlSSD { get; set; }
        public decimal GroesseSSD { get; set; }
        public string FunktionServer { get; set; }
        public decimal Netzwerk { get; set; }



        public Server( string name, string ipAdresse, int anzahlCPU, decimal leistungCPU, decimal groesseRam, int anzahlSSD, decimal groesseSSD, string funktionServer, decimal netzwerk ) : base( name, ipAdresse ) {
            AnzahlCPU = anzahlCPU;
            LeistungCPU = leistungCPU;
            GroesseRam = groesseRam;
            AnzahlSSD = anzahlSSD;
            GroesseSSD = groesseSSD;
            FunktionServer = funktionServer;
            Netzwerk = netzwerk;
        }

        public override string ToString() {
            return $"Anzahl CPU's: {AnzahlCPU}\n" +
                $"Leistung CPU: {LeistungCPU} Ghz\n" +
                $"Ram: {GroesseRam} Gigabyte\n" +
                $"Anzahl SSD: {AnzahlSSD} Stk.\n" +
                $"Kapazität SSD: {GroesseSSD} Gigabyte\n" +
                $"Funktion Server: {FunktionServer}\n" +
                $"Netzwerk: {Netzwerk}\n" + base.ToString();
        }
    }
}

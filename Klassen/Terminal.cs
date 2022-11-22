namespace RechnerVerwaltung.Klassen {
    internal class Terminal: Rechner {
        public Server Anbindung { get; set; }
        public string Standort { get; set; }

        public Terminal( string name, string ipAdresse, Server anbindung, string standort ) : base( name, ipAdresse ) {
            Anbindung = anbindung;
            Standort = standort;
        }

        public override string ToString() {
            return "Server-Anbindung:\n" + Anbindung.ToString()+ "\n" + $"Standort: {Standort}\n" + base.ToString();
        }
    }
}

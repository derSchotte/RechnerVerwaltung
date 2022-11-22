namespace RechnerVerwaltung.Klassen {
    internal class Rechner {
        public string Name { get; set; }
        public string IpAdresse { get; set; }

        public Rechner( string name, string ipAdresse ) {
            Name = name;
            IpAdresse = ipAdresse;
        }

        public override string ToString() {
            return $"Name: {Name}\nIP-Adresse: {IpAdresse}\n";
        }
    }
}

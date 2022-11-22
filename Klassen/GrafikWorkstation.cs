namespace RechnerVerwaltung.Klassen {
    internal class GrafikWorkstation: Workstation {
        public string Monitorgroesse { get; set; }
        public string ModelNameGrafikKarte { get; set; }

        public GrafikWorkstation( string monitorgroesse, string modelNameGrafikKarte, string name, string ipAdresse, decimal leistungCPU, decimal groesseRam, decimal groesseSSD )
                                : base( name, ipAdresse, leistungCPU, groesseRam, groesseSSD ) {
            Monitorgroesse = monitorgroesse;
            ModelNameGrafikKarte = modelNameGrafikKarte;
        }

        public override string ToString() {
            return $"Monitor Größe: {Monitorgroesse} Zoll\n" +
                $"Grafikkarte Model: {ModelNameGrafikKarte}\n" + base.ToString();
        }
    }
}

using RechnerVerwaltung.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechnerVerwaltung {
    internal static class Menu {
        static int eingabe = 0;
        static bool check;
        public static void MainMenu() {
            Console.WriteLine( "RechnerVerwaltung" );
            Console.WriteLine( "Was genau kann ich für sie tun?" );
            Console.WriteLine( "[1] Alle Rechner anzeigen\n[2] Einen Rechner anzeigen lassen (Index)\n[3] Neuen Rechner anlegen\n[4] Vorhandenen Rechner löschen\n[5] Rechner Auflisten nach Art\n" );
            Console.Write( "Eingabe: " );
            do {
                check = int.TryParse( Console.ReadLine(), out eingabe );

                if( !check ) {
                    Console.WriteLine( "Ihre Eingabe habe ich nicht verstanden, bitte nur Zahlen eingeben!" );
                    Console.Write( "Eingabe: " );
                }

                Ausgabe( eingabe );
            } while( !check );
        }

        static void Ausgabe( int eingabe ) {
            switch( eingabe ) {
                case 1:
                ITVerwaltung.AlleAnzeigen();
                break;
                case 2:
                Console.WriteLine("Welchen Index wollen sie Abfragen");
                Console.Write( "Eingabe: " );
                do {
                    check = int.TryParse( Console.ReadLine(), out eingabe );

                    if( !check ) {
                        Console.WriteLine( "Ihre Eingabe habe ich nicht verstanden, bitte nur Zahlen eingeben!" );
                        Console.Write( "Eingabe: " );
                    }
                } while( !check );
                ITVerwaltung.RechnerIndex(eingabe);
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
            }
        }
    }
}

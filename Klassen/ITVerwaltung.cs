using System.Reflection;

namespace RechnerVerwaltung.Klassen {
    internal static class ITVerwaltung {

        static List<Rechner> rechnerListe = new() {
        //new Rechner("R-Win10-1","192.168.1.1"),
        //new Rechner("R-Win10-2","192.168.1.100"),

        //new Workstation("W-Win11-1","192.168.1.101",4.5m,8m,2048m),
        //new Workstation("W-Win11-2","192.168.1.102",4.0m,16m,1024m),

        //new GrafikWorkstation("32°","WinForce HTX 256","T-Win11-1","192.168.2.1",3.4m,8m,2048m),
        //new GrafikWorkstation("24°","WinForce HI HTX 1024","T-Win11-2","192.168.2.2",4.5m,16m,4096),

        //new Server("S-Linux-1","192.168.10.100",8,3.4m,16m,2,6152m,"EMail-Server",3652),
        //new Server("S-Linux-2","192.168.10.101",4,3.4m,16m,2,4192m,"Web-Server",3653),

        //new Terminal("T-Linux-1","192.168.5.100",
        //                new("S-Linux-1","192.168.10.100",8,3.4m,16m,2,6152m,"EMail-Server",3652),
        //                "Düsseldorf"),
        //new Terminal("T-Linux-2","192.168.5.101",
        //                new("S-Linux-2","192.168.10.101",4,3.4m,16m,2,4192m,"Web-Server",3653),
        //                "Hamburg")
    };

        // Zähler erstellen

        // Methode erstellen welche alle in der Liste vorhanden Rechner ausgibt.
        public static void Verwaltung() {
            foreach( Rechner rechner in rechnerListe ) {
                rechner.ToString();
            }
        }

        public static void VerwaltungIndex( int index ) {
            Console.WriteLine( rechnerListe.Count() );
            rechnerListe[ index ].ToString();
        }

        public static int Eingabe() {
            int eingabe;
            bool check;

            Console.WriteLine( "Welche art von Rechner möchten sie anlegen?" );
            Console.WriteLine( "[1] Rechner, [2] Workstation, [3] Grafik Workstation, [4] Server, [5] Terminal" );

            do {
                Console.Write( "Eingabe: " );
                check = int.TryParse( Console.ReadLine(), out eingabe );

                if( !check ) {
                    Console.WriteLine( "Sie haben keine Zahl eingegeben!" );
                }
            } while( !check );

            return eingabe;
        }

        public static void RechnerAnlegen( int eingabe ) {
            switch( eingabe ) {
                case 1:
                AnlegenInListe( typeof( Rechner ) );
                break;
                case 2:
                AnlegenInListe( typeof( Workstation ) );
                break;
                case 3:
                AnlegenInListe( typeof( GrafikWorkstation ) );
                break;
                case 4:
                AnlegenInListe( typeof( Server ) );
                break;
                case 5:
                AnlegenInListe( typeof( Terminal ) );
                break;
            }
        }

        static void AnlegenInListe( Type type ) {
            Type t = type;
            PropertyInfo[] propInfos = t.GetProperties( System.Reflection.BindingFlags.Public | BindingFlags.Instance);

            List<string> eingaben = new();

            foreach( var prop in propInfos ) {
                Console.Write( $"{prop.Name}: " );
                string eingabe = Console.ReadLine();
                
                eingaben.Add( eingabe );
            }

            for( int i = 0; i < propInfos.Length; i++ ) {
                Console.Write( eingaben[ i ] );
            }



            //Console.WriteLine( "\n" + rechnerListe[ 0 ] );
            //DisplayPropertyInfo( propInfos );

            //static void DisplayPropertyInfo( PropertyInfo[] propInfos ) {
            //    // Display information for all properties.
            //    foreach( var propInfo in propInfos ) {
            //        bool readable = propInfo.CanRead;
            //        bool writable = propInfo.CanWrite;

            //        Console.WriteLine( "   Property name: {0}", propInfo.Name );
            //        Console.WriteLine( "   Property type: {0}", propInfo.PropertyType );
            //        Console.WriteLine( "   Read-Write:    {0}", readable & writable );
            //        if( readable ) {
            //            MethodInfo getAccessor = propInfo.GetMethod;
            //            Console.WriteLine( "   Visibility:    {0}",
            //                              GetVisibility( getAccessor ) );
            //        }
            //        if( writable ) {
            //            MethodInfo setAccessor = propInfo.SetMethod;
            //            Console.WriteLine( "   Visibility:    {0}",
            //                              GetVisibility( setAccessor ) );
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //static String GetVisibility( MethodInfo accessor ) {
            //    if( accessor.IsPublic )
            //        return "Public";
            //    else if( accessor.IsPrivate )
            //        return "Private";
            //    else if( accessor.IsFamily )
            //        return "Protected";
            //    else if( accessor.IsAssembly )
            //        return "Internal/Friend";
            //    else
            //        return "Protected Internal/Friend";
            //}
        }
    }
}

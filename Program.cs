using RechnerVerwaltung.Klassen;
using System.Reflection;
//ITVerwaltung.Verwaltung();
//ITVerwaltung.VerwaltungIndex( 1 );


//Type t = typeof(Rechner);
//PropertyInfo[] propInfos = t.GetProperties( System.Reflection.BindingFlags.Public | BindingFlags.Instance);

//Console.WriteLine( propInfos.Length );

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

ITVerwaltung.RechnerAnlegen(ITVerwaltung.Eingabe());

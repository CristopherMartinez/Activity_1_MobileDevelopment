using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("FCA.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("FCA.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]

//El error Java.IO.IOException: 'Cleartext HTTP traffic to localhost not permitted' se debe a que
//Android 9 (API nivel 28) y versiones posteriores restringen las conexiones HTTP no seguras (HTTP
//no cifrado) de forma predeterminada, incluso cuando intentas acceder a localhost. Esto es una medida de seguridad
//para proteger la comunicaciones en la red.
[assembly: Application(UsesCleartextTraffic = true)] //Deshabilita temporalmente la restricción de tráfico HTTP no cifrado. FOROhttps://stackoverflow.com/questions/56953255/where-to-set-applicationusescleartexttraffic-true-in-xamarin-android
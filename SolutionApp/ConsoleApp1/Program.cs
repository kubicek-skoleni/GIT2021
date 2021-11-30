// See https://aka.ms/new-console-template for more information
String lang= args.Length>0 ? args[0] : "CZ";

if ("CZ".Equals(lang.ToUpper())) {
    Console.WriteLine("Nazdar lidi, buďte zdrávi");
    Console.WriteLine("Nashledanou!");
}
else
{
    Console.WriteLine("Hello, World");
    Console.WriteLine("Goodby, World!");
}

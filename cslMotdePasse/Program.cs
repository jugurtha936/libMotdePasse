using libMotdePasse;
using System.Globalization;
Console.WriteLine("saisir le login");
string a= Console.ReadLine();
Console.WriteLine("saisir le mdp");
string b= Console.ReadLine();
MotdePasse conn1=new MotdePasse(a,b);

Console.WriteLine("resaisir le mdp");
string c = Console.ReadLine();
Console.WriteLine(conn1.Verifier(c));
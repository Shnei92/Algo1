string phase1;
string phrase2;
string phrase3;
string phrase4;
string separateur;

Console.WriteLine("Entrer votre premiere phrase");
phase1 = Console.ReadLine();

Console.WriteLine("Entrer votre seconde phrase");
phrase2 = Console.ReadLine();

Console.WriteLine("Entrer votre troisieme phrase");
phrase3 = Console.ReadLine();

Console.WriteLine("Entrer votre quatrieme phrase");
phrase4 = Console.ReadLine();

Console.WriteLine("Choisir un séparateur");
separateur = Console.ReadLine();


string lesPhrases = "Bonjour votre phrase complete est:" + " " + phase1 + " " + separateur + phrase2 + " " + separateur + phrase3 + " " + separateur + phrase4 + " " + separateur;
Console.WriteLine(lesPhrases);
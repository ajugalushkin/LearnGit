using System.IO;

string[] massInput = File.ReadAllLines("A:\\Users\\ajuga\\source\\repos\\LearnGit\\employees.dat");

foreach (var item in massInput) {
    Console.WriteLine(item);
}

string Doljnost = Console.ReadLine();

List<string> massOutput = new List<string>();
for (int i = 0; i < massInput.Length; i++) {
    string[] currentStringMass = massInput[i].Split('|');

    if (Doljnost == currentStringMass[1]) {
        massOutput.Add(currentStringMass[0] + " " + currentStringMass[2]);
    }
}

foreach( var item in massOutput){
    Console.Write(item);
}
Console.WriteLine();

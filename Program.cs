using System.IO;

string Doljnost = Console.ReadLine();

string[] massInput = File.ReadAllLines("A:\\Users\\ajuga\\source\\repos\\LearnGit\\employees.dat");

string[] massOutput;

for(int i = 0; i < massInput.Length){

string[] currentStringMass = massInput[i].Split('|');

if (Doljnost == currentStringMass[1]){
    massOutput = currentStringMass[0] + " " + currentStringMass[2];
}

foreach( var item in massOutput){
    Console.Write(item);
}
Console.WriteLine();

}
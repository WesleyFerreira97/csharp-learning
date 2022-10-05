using BasicExamples.Examples;
using Newtonsoft.Json;
using System.IO;

//ExProps RickSanchez = new ExProps();
//RickSanchez.Name = "Rick Sanchez";
//Console.WriteLine(RickSanchez.Name);

// Example Queue
//ExQueue namesQueue = new ExQueue();
//namesQueue.GetAllItems();
//namesQueue.AddQueue("Wesley");
//namesQueue.AddQueue("Juliana");
//namesQueue.AddQueue("Pedro");

//namesQueue.GetAllItems();
//namesQueue.RemoveQueue();
//Console.WriteLine(namesQueue.QueueContains("Wesley"));

// Example Stack
//ExStack namesStack = new ExStack();
//namesStack.AddStack("Morty Smith");
//namesStack.AddStack("Summer Smith");

//namesStack.GetAllItems();
//namesStack.RemoveStack();

//Console.WriteLine( namesStack.QueueContains("Morty Smith") );

// Example Hashtable
//ExHashtable person = new ExHashtable();
//person.AddHash("888.555.444.32", "Wesley");
//person.AddHash("888.555.444.32", "Wesley fail");
//person.AddHash("888.555.444.31", "Wesley");
//person.GetAllItems();
//person.RemoveHash("888.555.444.31");
//Console.WriteLine("Item Removido abaixo ↓↓");
//person.GetAllItems();

//bool checkContains = person.HashContains("888.555.444.32");
//Console.WriteLine($"Contém Item {checkContains}");


// Example Tuple
//ExTuple personTuple = new ExTuple();
//personTuple.Ex1();
//personTuple.Ex2();
//personTuple.Ex3();
// A declaração do var permite delega a responsabilidade da tipagem aos parametros da tupla
//var (Name, LastName, AgeRenomeado) = personTuple.ReturnTypeTuple();
//Console.WriteLine(Name);
//Console.WriteLine(LastName);
//Console.WriteLine(AgeRenomeado);

// Tupla com descartes - Permite pegar apenas o retorno necessário
// utilizando no lugar do parametro um _
//var (NameRenomeado, _, Age) = personTuple.ReturnTypeTuple();
//Console.WriteLine(Name);
//Console.WriteLine(Age);

// Example Deconstruct
//ExDeconstruct propsDeconstruct = new ExDeconstruct("Wesley", "Ferreira");
//propsDeconstruct.GetAllProps();

//Desconstruct method
//(string name, string lastName) = propsDeconstruct;
//Console.WriteLine(name);
//Console.WriteLine(lastName);

// Example Sereialize Json
List<ExSerializeJson> productList = new List<ExSerializeJson>();

ExSerializeJson product1 = new ExSerializeJson(2525, "SSD", 480.50M);
ExSerializeJson product2 = new ExSerializeJson(2525, "Placa de Video", 1980.50M);
ExSerializeJson product3 = new ExSerializeJson(2525, "Monitor", 2580.50M);
ExSerializeJson product4 = new ExSerializeJson(2525, "Processador", 1970.20M);

productList.Add(product1);
productList.Add(product2);
productList.Add(product3);
productList.Add(product4);

string serialize = JsonConvert.SerializeObject(productList, Formatting.Indented);

File.WriteAllText("Archives/sales.json", serialize);

Console.WriteLine(serialize);
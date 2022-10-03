using BasicExamples.Examples;

//ExProps RickSanchez = new ExProps();
//RickSanchez.Name = "Rick Sanchez";
//Console.WriteLine(RickSanchez.Name);

// Example Queue
ExQueue namesQueue = new ExQueue();
namesQueue.GetAllItems();
namesQueue.AddQueue("Wesley");
namesQueue.AddQueue("Juliana");
namesQueue.AddQueue("Pedro");

namesQueue.GetAllItems();
namesQueue.RemoveQueue();
Console.WriteLine(namesQueue.QueueContains("Wesley"));
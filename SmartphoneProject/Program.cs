using SmartphoneProject.Models;

Nokia meuTijolo = new Nokia("98050-6060", "Tijolão", "98054605465046", 256);
meuTijolo.TurnOn();
meuTijolo.ReceiveCall();
meuTijolo.InstallApp("Youtube");

Console.WriteLine("\n");

Iphone fiqueiRico = new Iphone("98050-8080", "Iphone", "98054605465046", 1024);
fiqueiRico.TurnOn();
fiqueiRico.ReceiveCall();
fiqueiRico.InstallApp("Instagram");
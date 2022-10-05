using estacionamento.Models;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Bem Vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial : ");

initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora : ");

pricePerHour = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Preço inicial definido em : {initialPrice}");
Console.WriteLine($"Preço por hora definido em : {pricePerHour}");

Parking theParking = new Parking(initialPrice, pricePerHour);
using ParkingProject.Models;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Bem Vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial : ");

initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora : ");

pricePerHour = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Preço inicial definido em : {initialPrice}");
Console.WriteLine($"Preço por hora definido em : {pricePerHour}");

Parking currentParking = new Parking(initialPrice, pricePerHour);

bool showMenu = true;

while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            currentParking.AddVehicle(Console.ReadLine());
            break;

        case "2":
            int selectVehicle = int.Parse(Console.ReadLine());
            currentParking.RemoveVehicle(selectVehicle);

            break;

        case "3":
            currentParking.GetAllVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
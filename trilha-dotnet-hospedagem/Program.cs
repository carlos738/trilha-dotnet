using System.Text;
using trilha_dotnet_hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;
//Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> hospedes = new List<Person>();

Person p1 = new Person(nome: "Hospede 1");


Person p2 = new Person(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//cria suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 33);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserves reserves = new Reserves(diasReservados: 16);
reserves.CadastrarSuite(suite);
reserves.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserves.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserves.CalcularValorDiaria()}");
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
    }

        public void RemoverVeiculo()
        {
            Console.Clear();
            ListarVeiculos();
            Console.WriteLine("");
            Console.WriteLine("Digite a placa do veículo para removê-lo:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite quantas horas o veículo permaneceu estacionado:");
                //int horas = 0;
                //decimal valorTotal = 0;

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int horas = Convert.ToInt32(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.Clear();
                Console.WriteLine($"Veículo {placa.ToUpper()} removido!\n" + $"Valor a pagar: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Insira uma placa válida.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Veículo {i + 1}: {veiculos[i].ToUpper()}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

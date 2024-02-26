using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffsCar
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void adicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo: ");
            string placa = Console.ReadLine();
            placa = placa.ToUpper();

            if (veiculos.Any(x => x.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Já existe um veículo com essa placa.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso.");
            }
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            placa = placa.ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu no pátio: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa: {placa} foi removido e deve pagar {precoTotal}.");
            }
            else
            {
                Console.WriteLine("O veículo não está em nosso pátio.");
            }
        }

        public void listarVeiculo()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach(var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos no pátio.");
            }
        }
    }
}

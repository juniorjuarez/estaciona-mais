using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaMaios.Classes
{
    internal class Estacionamento
    {
        public Estacionamento()
        {
            //this.Vagas = 20;
            this.taxaHora = 5.00;
           

        }

   

        public DateTime dataEntrada { get; set; }

        public DateTime dataSaida { get; set; }


        public Clientes Cliente { get; set; }

        public Funcionario Funcionario { get; set; }
        public double taxaHora { get; private set; }
        public double Taxa { get; private set; }

        public double CalculaTaxa() {

           
            TimeSpan diferenca = dataSaida - dataEntrada;

            // Calcula o custo total
            double custoTotal = diferenca.TotalHours * taxaHora;

            return this.Taxa = custoTotal;

        }

        public void SetDataEntrada(DateTime entrada) {

            this.dataEntrada = entrada;
        
        }
        public void SetDataSaida(DateTime saida)
        {

            this.dataSaida = saida;

        }


        public void SetCliente(Clientes cliente) {

            this.Cliente = cliente;
        
        }


        public void SetFuncionario(Funcionario funcionario)
        {

            this.Funcionario = funcionario;

        }

        }

}

   

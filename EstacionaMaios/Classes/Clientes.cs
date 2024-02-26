using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaMaios.Classes
{
    public class Clientes { 

        public int Id { get; private set; }
    
        public string NomeCliente { get; private set; }
        public string MarcaModelo { get; private set; }
        public string Cor { get; private set; }

        public string PlacaVeiculo { get; private set; }


        public int GetId() {

            return this.Id;
        }


        public void SetId(int id) { 
            
            this.Id = id;
        
        }
        public void SetNomeCliente(string nome) { 
        
            this.NomeCliente = nome;
        
        }
        public void SetMarcaModelo(string marcaModelo)
        {

            this.MarcaModelo = marcaModelo;

        }
        public void SetCor(string cor)
        {

            this.Cor = cor;

        }

        public void SetPlacaVeiculo(string placaVeiuclo)
        {

            this.PlacaVeiculo = placaVeiuclo;

        }

    }
}

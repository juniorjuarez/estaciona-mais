using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaMaios.Classes
{
    internal class Funcionario
    {
        public int Id { get;  private set; }
        public string  nomeFuncionario { get; protected set; }

        public int Idade { get; private set; }


        public void SetId(int id) {
            this.Id = id;
        }

        public void SetNomeFuncionario(string nome) {
            this.nomeFuncionario = nome;
            
        }

        //public string GetNomeFuncionario() { return this.nomeFuncionario; }

        public void SetIdade(int idade) {

            this.Idade = idade;
        }

        //public void imprimeFuncionario() {

        //        Console.WriteLine("                                -------- Atributos --------                              ");
        //        Console.WriteLine("                                ===========================                              ");
        //        Console.WriteLine("                                ---------- ID: ------------                              ");
        //        Console.WriteLine($"                                  {this.Id}                                             ");
        //        Console.WriteLine("                                ---------- Nome: ----------                              ");
        //        Console.WriteLine($"                                  {this.nomeFuncionario}                                ");
        //        Console.WriteLine("                                ---------- Idade: ----------                             ");
        //        Console.WriteLine($"                                  {this.Idade}                                          ");

        //}

        public int GetId() { 
        
        return this.Id;
        }

        public string GetNome()
        {

            return this.nomeFuncionario;
        }


        public int GetIdade() { 
        
            return this.Idade;
        }
    }
}

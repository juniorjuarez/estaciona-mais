using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaMaios.Classes.Template
{
    internal class Layout
    {
        
        private static List<Funcionario> funcionarios = new List<Funcionario>();
        private static List<Clientes> clientes = new List<Clientes>();
        private static List<Estacionamento> entradas = new List<Estacionamento>();






        private static int opcao;

        public static void TelaPrincipal() {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Digite a opção desejada :                                ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                1 - Cadastrar Funcionário:                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                2 - Imprimir Funcionário :                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                3 - Cadastrar um Cliente :                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                4 - Imprimir um Cliente  :                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                5 - Registrar uma Entrada:                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                6 - Registrar uma Saída  :                               ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                7 - Sair:                                                ");
            Console.WriteLine("                                ===========================                              ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarFuncionário();
                    break;
                case 2:
                    ExibirFuncionarios();
                    break;
                case 3:
                    CadastrarCliente();
                    break;
                case 4:
                    ExibirClientes();
                    break;
                case 5:
                    RegistrarEntrada();
                    break;
                case 6:
                    ExibeRegistrosEntradas();
//                    ImprimeRegistrosEntradas(registro);
                    break;

                case 7:
                    Console.WriteLine("                                Sistema sendo encerrado!");
                    Console.WriteLine("                                Aperte [ENTER} para Fechar:                           ");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
                    Console.ReadKey();
                    TelaPrincipal();
                    break;
            }



        }

        private static void CadastrarFuncionário()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Cadastrando um funcionário :                             ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Nome do Funcionário:                                     ");
            string nome = Console.ReadLine();
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Idade do Funcionário:                                    ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("                                ===========================                              ");

            Funcionario funcionario = new Funcionario();

            funcionario.SetId(funcionarios.Count + 1);
            funcionario.SetNomeFuncionario(nome);
            funcionario.SetIdade(idade);


            Console.Clear();

            funcionarios.Add(funcionario);
            ImprimeFuncionario(funcionario);

            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();


            TelaPrincipal();
        }


        public static void CadastrarCliente() {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Cadastrando um Cliente :                                 ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Nome do Cliente:                                         ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Marca/Modelo do Carro:                                   ");
            Console.WriteLine("                                Exemplo: VW Gol                                          ");
            string marcaModelo = (Console.ReadLine());
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Placa do Carro:                                          ");
            Console.WriteLine("                                Exemplo: ABC - 2512                                      ");
            string placa = (Console.ReadLine());
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Cor do Carro:                                      ");
            string cor = (Console.ReadLine());
            Console.WriteLine("                                ===========================                              ");

            Clientes cliente = new Clientes();

            cliente.SetId(clientes.Count + 1);
            cliente.SetNomeCliente(nomeCliente);
            cliente.SetMarcaModelo(marcaModelo);
            cliente.SetPlacaVeiculo(placa);
            cliente.SetCor(cor);


            Console.Clear();

            clientes.Add(cliente);
            ImprimirCliente(cliente);

            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();


            TelaPrincipal();


        }



     

        public static void RegistrarESaida()





        {
            DateTime entrada = new DateTime(2023, 10, 1, 10, 0, 0); // substitua com a sua data e hora de entrada
            DateTime saida = new DateTime(2023, 10, 1, 11, 30, 0); // substitua com a sua data e hora de saída

            double taxaHora = 5.00;

            // Calcula a diferença
            TimeSpan diferenca = saida - entrada;

            // Calcula o custo total
            double custoTotal = diferenca.TotalHours * taxaHora;

            // Exibe o custo total
            Console.WriteLine("Custo total: R$" + custoTotal);


            Console.ReadKey();
            TelaPrincipal();
        }

        public static void ImprimeFuncionario(Funcionario funcionario)
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine($"                               |ID:  {funcionario.Id}                                   ");
            Console.WriteLine($"                               |Nome:{funcionario.nomeFuncionario}                      ");
            Console.WriteLine($"                               |Idade:{funcionario.Idade}                               ");
            Console.WriteLine("=========================================================================================");
        }


        public static void ExibirFuncionarios()
        {

            Console.Clear();

            foreach (var funcionario in funcionarios)
            {
                ImprimeFuncionario(funcionario);
            }
            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();


            TelaPrincipal();
        }

        public static Funcionario SelecionaFuncionario()
        {

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Buscando Funcionário                                     ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                ID do Funcionário:                                        ");
            int id = int.Parse(Console.ReadLine());

            var func = funcionarios.FirstOrDefault(p => p.GetId() == id);

            if (func == null)
            {


                Console.WriteLine($"                               Funcionário de {id} não existe                        ");
                Console.WriteLine("                                Aperte [ENTER} para voltar:                                 ");
                Console.ReadKey();
                TelaPrincipal();


            }
            else
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"                               |ID:  {func.Id}                                   ");
                Console.WriteLine($"                               |Nome:{func.nomeFuncionario}                      ");
                Console.WriteLine($"                               |Idade:{func.Idade}                               ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                Aperte [ENTER} para continuar:                                 ");
                Console.ReadKey();
                


            }

            return func;
        }





        public static void ImprimirCliente(Clientes cliente)
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine($"                               |ID            :{cliente.Id}                                       ");
            Console.WriteLine($"                               |Nome          :{cliente.NomeCliente}                              ");
            Console.WriteLine($"                               |Marca - Modelo:{cliente.MarcaModelo}                             ");
            Console.WriteLine($"                               |Cor           :{cliente.Cor}                                     ");
            Console.WriteLine($"                               |Placa         :{cliente.PlacaVeiculo}                            ");
            Console.WriteLine("=========================================================================================");


        }



        public static void ExibirClientes() {

            Console.Clear();
            foreach (var cliente in clientes) {

                ImprimirCliente(cliente);
            }
            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();


            TelaPrincipal();

        }


        public static Clientes SelecionarCliente() {
            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Buscando Cliente                                     ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                ID do Cliente:                                        ");
            int id = int.Parse(Console.ReadLine());


            var cliente = clientes.FirstOrDefault(p => p.GetId() == id);

            if (cliente == null)
            {

                Console.WriteLine($"                               Cliente de {id} não existe                        ");
                Console.WriteLine("                                Aperte [ENTER} para voltar:                                 ");
                Console.ReadKey();
                TelaPrincipal();
                


            }
            else {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"                               |ID            :{cliente.Id}                                       ");
                Console.WriteLine($"                               |Nome          :{cliente.NomeCliente}                              ");
                Console.WriteLine($"                               |Marca - Modelo:{cliente.MarcaModelo}                             ");
                Console.WriteLine($"                               |Cor           :{cliente.Cor}                                     ");
                Console.WriteLine($"                               |Placa         :{cliente.PlacaVeiculo}                            ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                Aperte [ENTER} para continuar:                                 ");
                Console.ReadKey();
                //TelaPrincipal(); 

            }

            return cliente;
        }
        
        
        
        
        public static void RegistrarEntrada()
        {
            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Cadastrando um funcionário :                             ");
            Console.WriteLine("                                ===========================                              ");




            Console.WriteLine("Informe a data e hora de entrada (formato: dd/MM/yyyy HH:mm): ");
            string dataEntradaString = Console.ReadLine();

            // Validação da entrada para garantir que está no formato correto
            if (DateTime.TryParseExact(dataEntradaString, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime entrada))
            {
                Console.WriteLine("Data de entrada válida: " + entrada);
            }
            else
            {
                Console.WriteLine("Formato de data e hora de entrada inválido. Certifique-se de seguir o formato: dd/MM/yyyy HH:mm");
            }

            Console.WriteLine("===========================");

            // Entrada de data e hora de saída
            Console.WriteLine("Informe a data e hora de saída (formato: dd/MM/yyyy HH:mm): ");
            string dataSaidaString = Console.ReadLine();

            // Validação da entrada para garantir que está no formato correto
            if (DateTime.TryParseExact(dataSaidaString, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime saida))
            {
                Console.WriteLine("Data de saída válida: " + saida);
            }
            else
            {
                Console.WriteLine("Formato de data e hora de saída inválido. Certifique-se de seguir o formato: dd/MM/yyyy HH:mm");
            }

            Estacionamento registro = new Estacionamento();

            registro.SetCliente(SelecionarCliente());
            registro.SetFuncionario(SelecionaFuncionario());
            registro.SetDataEntrada(entrada);
            registro.SetDataSaida(saida);
            registro.CalculaTaxa();
          

            entradas.Add(registro);


            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();
            TelaPrincipal();


        }

        public static void ImprimeRegistrosEntradas(Estacionamento entrada) {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine($"                               |Nome Cliente  :{entrada.Cliente.NomeCliente}            ");
            Console.WriteLine($"                               |Marca - Modelo:{entrada.Cliente.MarcaModelo}                    ");
            Console.WriteLine($"                               |Placa         :{entrada.Cliente.PlacaVeiculo}                     ");
            Console.WriteLine($"                               |Cor           :{entrada.Cliente.Cor}                             ");
            Console.WriteLine($"                               |Funcionário   :{entrada.Funcionario.GetNome()}                    ");
            Console.WriteLine($"                               |Data Entrada  :{entrada.dataEntrada}                    ");
            Console.WriteLine($"                               |Data Entrada  :{entrada.dataSaida}                    ");
            Console.WriteLine($"                               |Taxa Total    :{entrada.Taxa}                    ");
            Console.WriteLine("=========================================================================================");


        }


        public static void ExibeRegistrosEntradas() {
            
            Console.Clear();
            foreach (var estacionaemnto in entradas) {
              Console.WriteLine("                                Entradas :                             ");
               ImprimeRegistrosEntradas(estacionaemnto);
               Console.WriteLine("                                ===========================                              ");

            }
            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();
            TelaPrincipal();



        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Conta Corrente
            //ContaCorrente conta1 = new ContaCorrente(867, 129043939);

            ////Cliente
            //Cliente cliente1 = new Cliente();
            //cliente1.Nome = "Guilherme";
            //cliente1.CPF = "12345";
            //cliente1.Profissao = "Desenvolvedor";

            //conta1.Titular = cliente1;

            //conta1.Saldo = 1000;
            //Console.WriteLine(conta1.Titular.Nome);
            //Console.WriteLine(conta1.Saldo);
            //Console.WriteLine(conta1.Titular.CPF);
            //Console.WriteLine(conta1.Titular.Profissao);

            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //CalcularBonificacao();
            UsarSistema();


            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicios02
{
    internal class Program
    {

        static void SalarioLiquidoINSS()
        {
            Console.Write("Informe o salário do funcionário (R$): ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual do INSS a ser descontado (R$): ");
            double percentualInss = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual do Pensão a ser descontado (R$): ");
            double percentualPensao = double.Parse(Console.ReadLine());

            //double salarioLiquido = salarioBruto * (1 - (percentualInss + percentualPensao) / 100);

            double salarioLiquido = salarioBruto * (1 - (percentualInss / 100)) * (1 - (percentualPensao / 100));

            //Console.WriteLine($"{1 - (percentualInss / 100)}");
            //Console.WriteLine($"{1 - (percentualInss / 100)}");

            //double salarioLiquido = salarioBruto * 0.9 * 0.8;

            Console.WriteLine($"O salário líquido do funcionário é de R${string.Format(salarioLiquido.ToString(), "C")}");
        }

        static void MaiorOuMenor()
        {
            Console.WriteLine($"Insira o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("O primeiro número é maior");
            } else if (b > a)
            {
                Console.WriteLine("O segundo número é maior");
            } else
            {
                Console.WriteLine("Os número são iguais");
            }
        }

        static void DescontoSe()
        {
            Console.Write("Unidades compradas: ");
            int unidadesCompradas = int.Parse(Console.ReadLine());

            Console.Write("Valor unitário: ");
            double valorUnitário = double.Parse(Console.ReadLine());

            double percentualDesconto = 0;
            string temDesconto = "Sem desconto";

            if (unidadesCompradas > 100)
            {
                Console.Write("Mais que 100 unidades. Informe o percentual de desconto: ");
                percentualDesconto = double.Parse(Console.ReadLine());
                temDesconto = "Com desconto";
            }

            double valorFinal = valorUnitário * unidadesCompradas * (1 - percentualDesconto/100);
            
            Console.WriteLine($"O valor final é de R${valorFinal} ({temDesconto})");
           
        }

        static void HouM()
        {
            string sexo = Console.ReadLine();

            sexo = sexo.Trim().ToUpper();

            if (sexo == "M")
            {
                Console.WriteLine("Masculino");
            } else if (sexo == "F") 
            {
                Console.WriteLine("Feminino");
            } else
            {
                Console.WriteLine("Nulo");
            }
        }

        static void Calculadora()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            string operacao = Console.ReadLine();

            float resultado = 0;
            bool deuErro = false;

            switch (operacao)
            {
                case "+":
                    resultado = a + b;
                    break;
                case "-":
                    resultado = a - b;
                    break;
                case "*":
                       resultado = a * b;
                    break;
               case "/":
                    resultado = a / b;
                    break;
                case "%":
                    resultado = a / b;
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    deuErro= true;
                    break;

            }

            if (!deuErro) Console.WriteLine($"A resposta é: {resultado}");
            
        }
        static void Main(string[] args)
        {

            //SalarioLiquidoINSS();
            //MaiorOuMenor(); 
            //DescontoSe();
            Calculadora();
            Console.ReadLine();
        }
    }
}

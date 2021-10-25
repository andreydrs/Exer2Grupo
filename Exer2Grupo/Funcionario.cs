using System;
using System.Collections.Generic;
using System.Text;

namespace Exer2Grupo
{
    class Funcionario
	{
		private string Nome = "Joao Silva";
        private double SalarioBruto = 6000;
		private double Imposto = 1000;

		public void salarioLiquido()
		{
			double salario = SalarioBruto-Imposto;
			Console.WriteLine("\nFuncionario: {0} $ {1}",Nome, salario.ToString("F2"));

		}

		public void aumentarSalario()
		{
			double aumento = 10;
			double salarioAtualizado = SalarioBruto * 0.10 + SalarioBruto-Imposto;
			
			Console.WriteLine("\nDigite a percentagem para aumentar o salario: {0}", aumento.ToString("F1"));
			Console.WriteLine("\nDados Atualizado: {0} $ {1}",Nome, salarioAtualizado.ToString("F2"));
		}

	}
}

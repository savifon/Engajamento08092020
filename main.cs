using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa MinhaPessoa = new Pessoa();

		do {
			Console.Write("Digite o nome da pessoa >> ");
			MinhaPessoa.AlteraNome(Console.ReadLine());
			Console.Write("Digite a idade da pessoa >> ");
			MinhaPessoa.Envelhercer(int.Parse(Console.ReadLine()));
			Console.Write("Digite o peso da pessoa >> ");
			MinhaPessoa.Engordar(double.Parse(Console.ReadLine()));
			Console.Write("Digite a altura da pessoa >> ");
			MinhaPessoa.Crescer(double.Parse(Console.ReadLine()));
		} while (MinhaPessoa.RetornaNome() == null || MinhaPessoa.RetornaNome() == "");
  }
}
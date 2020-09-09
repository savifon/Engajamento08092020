using System;

class MainClass {
  public static void Main (string[] args) {
		int opcao;
		double valor;
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

		do {
			Console.WriteLine("\n\n** ESCOLHA UMA OPÇÃO **\n[1] para envelhecer\n[2] para engordar\n[3] para emagrecer\n[4] para crescer\n [0] para sair\n");
			opcao = int.Parse(Console.ReadLine());

			if (opcao > 0) {
				Console.Write("Digite o valor >> ");
				valor = double.Parse(Console.ReadLine());

				switch (opcao){
					case 1:
						MinhaPessoa.Envelhercer(valor);
						break;
					case 2:
						MinhaPessoa.Engordar(valor);
						break;
					case 3:
						MinhaPessoa.Emagrecer(valor);
						break;
					case 4:
						MinhaPessoa.Crescer(valor);
						break;
					case 0:
					default:
						break;
				}
			}

			Console.WriteLine("Nome: {0}", MinhaPessoa.RetornaNome());
			Console.WriteLine("Idade: {0}", MinhaPessoa.RetornaIdade());
			Console.WriteLine("Peso: {0}", MinhaPessoa.RetornaPeso());
			Console.WriteLine("Altura: {0}", MinhaPessoa.RetornaAltura());
		} while(opcao > 0);
  }
}
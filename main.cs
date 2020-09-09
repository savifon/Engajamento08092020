using System;

class MainClass {
  public static void Main (string[] args) {
		int opcao;
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
			Console.WriteLine("\n\n** ESCOLHA UMA OPÇÃO **\n[1] para envelhecer\n[2] para engordar 1kg\n[3] para emagrecer 1kg\n[4] para crescer 1cm\n[0] para sair");
			opcao = int.Parse(Console.ReadLine());

			switch (opcao){
				case 1:
					MinhaPessoa.Envelhercer(1);
					break;
				case 2:
					MinhaPessoa.Engordar(1);
					break;
				case 3:
					MinhaPessoa.Emagrecer(1);
					break;
				case 4:
					MinhaPessoa.Crescer(0.01);
					break;
				case 0:
				default:
					break;
			}

			Console.WriteLine("Nome: {0}", MinhaPessoa.RetornaNome());
			Console.WriteLine("Idade: {0}", MinhaPessoa.RetornaIdade());
			Console.WriteLine("Peso: {0}", MinhaPessoa.RetornaPeso());
			Console.WriteLine("Altura: {0}", MinhaPessoa.RetornaAltura());
		} while(opcao > 0);
  }
}
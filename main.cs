using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa MinhaPessoa = new Pessoa();
		MinhaPessoa.AlteraNome("Savio Fonseca");
		MinhaPessoa.Envelhercer(24);
		MinhaPessoa.Engordar(49);
		MinhaPessoa.Crescer(1.67);
		Console.WriteLine("Nome: {0}", MinhaPessoa.RetornaNome());
		Console.WriteLine("Altura: {0}", MinhaPessoa.RetornaAltura());
		Console.WriteLine("Peso: {0}", MinhaPessoa.RetornaPeso());
		Console.WriteLine("Idade: {0}", MinhaPessoa.RetornaIdade());
		MinhaPessoa.Envelhercer(25);
		Console.WriteLine("Nome: {0}", MinhaPessoa.RetornaNome());
		Console.WriteLine("Altura: {0}", MinhaPessoa.RetornaAltura());
		Console.WriteLine("Peso: {0}", MinhaPessoa.RetornaPeso());
		Console.WriteLine("Idade: {0}", MinhaPessoa.RetornaIdade());
  }
}
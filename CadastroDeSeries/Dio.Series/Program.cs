using Dio.Series.src.Classes;
using Dio.Series.src.Enum;

SerieRepositorio repositorio = new SerieRepositorio();

string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "X")
{
	switch (opcaoUsuario)
	{
		case "1":
			ListarSeries();
			break;

		case "2":
			InserirSerie();
			break;

		case "3":
			//AtualizarSerie();
			break;

		case "4":
			//ExcluirSerie();
			break;

		case "5":
			//VisualizarSerie();
			break;

		case "C":
			Console.Clear();
			break;

		default:
			throw new ArgumentOutOfRangeException();
	}

	opcaoUsuario = ObterOpcaoUsuario();
}

Console.WriteLine("###### DOTNETFLIX ######");
Console.ReadLine();

void ListarSeries()
{
	var lista = repositorio.Lista();

	if (lista.Count == 0)
	{
		Console.WriteLine("Nenhuma série cadastrada");
		return;
	}

	foreach (var serie in lista)
	{
		Console.WriteLine($"#ID{serie.RetornaId()}: - {serie.RetornaTitulo()}");
	}
}
void InserirSerie()
{
    Console.WriteLine("Inserir nova serie");

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero),i)}");
    }

    Console.WriteLine("Digite o genero de acordo com as opções acima: ");
	int entradaGenero = int.Parse(Console.ReadLine());
}

static string ObterOpcaoUsuario()
{
	Console.WriteLine();
	Console.WriteLine("****************************************************************");
	Console.WriteLine("****** DIOFLIX ****** Estamos a seu dispor ****** DIOFLIX ******");
	Console.WriteLine("****************************************************************");
	Console.WriteLine();

	Console.WriteLine("1 - Listar séries");
	Console.WriteLine("2 - Inserir série");
	Console.WriteLine("3 - Atualizar série");
	Console.WriteLine("4 - Excluir série");
	Console.WriteLine("5 - Visualizar série");
	Console.WriteLine("C - Limpar Tela");
	Console.WriteLine("X - Sair");

	Console.WriteLine();
	Console.WriteLine("****** DIOFLIX ****** Informe o item desejado:");

	string opcaoUsuario = Console.ReadLine().ToUpper();
	Console.WriteLine();

	return opcaoUsuario;
}


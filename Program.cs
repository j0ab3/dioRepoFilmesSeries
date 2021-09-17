using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new   SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new   FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        opcaoUsuario = GerenciaSerie();
                        break;
                    case "2":
                        opcaoUsuario = GerenciaFilme();
                        break;
                    case "A":
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        
                }
                if(opcaoUsuario.ToUpper() == "1" && opcaoUsuario.ToUpper() == "2" && opcaoUsuario.ToUpper() == "A")
                {
                    opcaoUsuario = ObterOpcaoUsuario();
                }
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        public static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        }

        public static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaporID(indiceSerie);
            Console.WriteLine(serie);
        }
        public static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero),i));                
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Serie: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Início da Série: ");

            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Série: ");

            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano:entradaAno,
                                        descricao:entradaDescricao);

            repositorioSerie.Atualiza(indiceSerie,atualizaSerie);
        }
        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero),i));                
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Serie: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Início da Série: ");

            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Série: ");

            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano:entradaAno,
                                        descricao:entradaDescricao);

            repositorioSerie.Insere(novaSerie);
        }
        public static void ExcluirFilme()
        {
            Console.WriteLine("Digite o id da Filme: ");
            int indiceFilme=int.Parse(Console.ReadLine());

            repositorioFilme.Exclui(indiceFilme);
        }

        public static void VisualizarFilme()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceFilme=int.Parse(Console.ReadLine());

            var Filme = repositorioFilme.RetornaporID(indiceFilme);
            Console.WriteLine(Filme);
        }
        public static void AtualizarFilme()
        {
            Console.WriteLine("Digite o id da Filme: ");
            int indiceFilme=int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero),i));                
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Início da Filme: ");

            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Filme: ");

            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano:entradaAno,
                                        descricao:entradaDescricao);

            repositorioFilme.Atualiza(indiceFilme,atualizaFilme);
        }
        public static void InserirFilme()
        {
            Console.WriteLine("Inserir nova Filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero),i));                
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Início da Filme: ");

            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Filme: ");

            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano:entradaAno,
                                        descricao:entradaDescricao);

            repositorioFilme.Insere(novoFilme);
        }

        private static string GerenciaSerie()
        {
            string opcaoSerieUsuario = ObterOpcaoSerieUsuario();
            while(opcaoSerieUsuario.ToUpper() != "A" && opcaoSerieUsuario.ToUpper() != "X")
            {
                switch(opcaoSerieUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        
                }
                 opcaoSerieUsuario = ObterOpcaoSerieUsuario();
            }
            return opcaoSerieUsuario;

        }

        private static string GerenciaFilme()
        {
            string opcaoFilmeUsuario = ObterOpcaoFilmeUsuario();
            while(opcaoFilmeUsuario.ToUpper() != "A"  && opcaoFilmeUsuario.ToUpper() != "X")
            {
                switch(opcaoFilmeUsuario)
                {
                    case "1":
                        ListarFilmes();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        ExcluirFilme();
                        break;
                    case "5":
                        VisualizarFilme();
                        break;                 
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        
                }
                 opcaoFilmeUsuario = ObterOpcaoFilmeUsuario();
            }
            return opcaoFilmeUsuario;

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Catalogo a seu Dispor!!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Séries");
            Console.WriteLine("2- Filmes");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static string ObterOpcaoSerieUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu Dispor!!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("A- Alterar Categoria");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoFilmeUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Filme a seu Dispor!!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar Filmes");
            Console.WriteLine("2- Inserir nova Filmes");
            Console.WriteLine("3- Atualizar Filmes");
            Console.WriteLine("4- Excluir Filmes");
            Console.WriteLine("5- Visualizar Filmes");            
            Console.WriteLine("A- Alterar Categoria");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        public static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");
            var Lista = repositorioSerie.Lista();
            if(Lista.Count==0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada");
                return;
            }
            foreach (var serie in Lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(),serie.retornaTitulo());
            }
        }
        public static void ListarFilmes()
        {
            Console.WriteLine("Listar Filmes");
            var Lista = repositorioFilme.Lista();
            if(Lista.Count==0)
            {
                Console.WriteLine("Nenhum Filme Cadastrado");
                return;
            }
            foreach (var filme in Lista)
            {
                Console.WriteLine("#ID {0}: - {1}", filme.retornaId(),filme.retornaTitulo());
            }
        }

        

    }
}

int escolhaNivel = 0;
int escolhaAtividade = 0;

while (escolhaNivel != 5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("======Gerenciador de Atividades======");
    Console.ResetColor();

    Console.WriteLine("Escolha uma opção para acessar:\n" +
        "1. Nível 1 - Variáveis e Operações Básicas\n" +
        "2. Nível 2 - Estruturas Condicionais (if, else if, else)\n" +
        "3. Nível 3 - Estruturas de Repetição (Loops)\n" +
        "4. Nível 4 - Coleções (Arrays e Listas)\n" +
        "5. Sair");
    Console.Write("Opção Escolhida: ");
    escolhaNivel = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(); //Pulo de linha para melhor visualização no console;

    switch (escolhaNivel)
    {
        case 1:
            Console.WriteLine("Atividades do Nível 1:\n" +
                "1. Calculadora de Média Simples\n" +
                "2. Conversor de Idade\n" +
                "3. Troca de Valores\n" +
                "4.Voltar para a escolha de nível");
            Console.Write("Opção Escolhida: ");
            escolhaAtividade = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Limpa o console para melhor visualização da atividade escolhida;

            switch (escolhaAtividade)
            {
                case 1:
                    #region Atividade 1 - Calculadora de Média Simples
                    Console.ForegroundColor = ConsoleColor.Green ;
                    Console.WriteLine("=====N1A1 - Calculadora de Média Simples=====");
                    Console.ResetColor();

                    Console.WriteLine("Insira sua primeira nota:");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira sua segunda nota:");
                    double nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira sua terceira nota:");
                    double nota3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira sua quarta nota:");
                    double nota4 = Convert.ToDouble(Console.ReadLine());
                    double media = (nota1 + nota2 + nota3 + nota4) / 3;
                    Console.WriteLine($"Sua média é {media.ToString("F2")}.");
                    #endregion
                    break;
                case 2:
                    #region Atividade 2 - Conversor de Idade
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("=====N1A2 - Conversor de Idade=====");
                    Console.ResetColor();

                    Console.WriteLine("Qual a sua idade?");
                    double idade = Convert.ToDouble(Console.ReadLine());

                    double idadeDias = idade * 365;

                    Console.WriteLine($"Você está vivo há aproximadamente {idadeDias} dias!");
                    #endregion
                    break;
                case 3:
                    #region Atividade 3 - Troca de Valores
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("=====N1A3 - Troca de Valores=====");
                    Console.ResetColor();

                    Console.WriteLine("Insira o primeiro valor:");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor:");
                    int B = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Valor A: {A}\nValor B: {B}");

                    int temp = A;
                    A = B;
                    B = temp;

                    Console.WriteLine("==== Troca de valores ====");

                    Console.WriteLine($"Valor A: {A}\nValor B: {B}");
                    #endregion
                    break;
                case 4:
                    break;

            }
            break;

        case 2:
            Console.WriteLine("Atividades do Nível 2:\n" +
                "1. Verificador de Maioridade\n" +
                "2. Classificador de Números\n" +
                "3. Validador de Login Simples\n" +
                "4.Voltar para a escolha de nível");
            Console.Write("Opção Escolhida: ");
            escolhaAtividade = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Limpa o console para melhor visualização da atividade escolhida;

            switch (escolhaAtividade)
            {
                case 1:
                    #region Atividade 1 - Verificador de Maioridade
                    Console.ForegroundColor = ConsoleColor.Yellow ;
                    Console.WriteLine("=====N2A1 - Verificador de Maioridade=====");
                    Console.ResetColor();
                    Console.WriteLine("Insira sua idade:");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    if (idade >= 18)
                    {
                        Console.WriteLine("Parabéns, você é maior de idade, portanto já pode votar!");
                    }
                    else
                    {
                        Console.WriteLine($"Você ainda não é maior de idade, portanto ainda não pode votar!");
                    }
                    #endregion
                    break;
                case 2:
                    #region Atividade 2 - Classificador de Números
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====N2A2 - Classificador de Números=====");
                    Console.ResetColor();
                    Console.WriteLine("Insira um número:");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 0)
                    {
                        Console.WriteLine("O seu número é zero, portanto ele é par!");
                    }
                    else if (num > 0 && num % 2 == 0)
                    {
                        Console.WriteLine($"O seu número é {num}, portanto ele é par e positivo!");
                    }
                    else if (num > 0 && !(num % 2 == 0))
                    {
                        Console.WriteLine($"O seu numero é o {num}, portanto ele é ímpar e positivo!");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine($"O seu número é o {num}, portanto ele é negativo!");
                    }

                    #endregion
                    break;
                case 3:
                    #region Atividade 3 - Validador de Login Simples
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====N2A3 - Validador de Login Simples=====");
                    Console.ResetColor();
                    string usuario_correto = "admin";
                    string senha_correta = "12345";

                    Console.WriteLine("Insira o seu nome de usuário:");
                    string usuario_informado = Console.ReadLine();
                    Console.WriteLine("Insira sua senha:");
                    string senha_informada = Console.ReadLine();

                    if (usuario_correto == usuario_informado && senha_correta == senha_informada)
                    {
                        Console.WriteLine("Login efetuado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Usuário ou senha inválidos.");
                    }
                    #endregion
                    break;
                case 4:
                    break;


            }

            break;

        case 3:
            Console.WriteLine("Atividades do Nível 3:\n" +
                "1. Contagem regressiva\n" +
                "2. Soma de ímpares\n" +
                "3. Tabuada Personalizada\n" +
                "4.Voltar para a escolha de nível");
            Console.Write("Opção Escolhida: ");
            escolhaAtividade = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Limpa o console para melhor visualização da atividade escolhida;

            switch (escolhaAtividade)
            {
                case 1:
                    #region Atividade 1 - Contagem regressiva
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("=====N3A1 - Contagem Regressiva=====");
                    Console.ResetColor();
                    Console.WriteLine("Insira um número para iniciar a contagem:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Contagem regressiva:");

                    for (int i = num; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("Lançar!");
                    #endregion
                    break;
                case 2:
                    #region Atividade 2 - Soma de ímpares
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("=====N3A2 - Soma de ímpares=====");
                    Console.ResetColor();
                    Console.WriteLine("Insira um número inteiro:");
                    int numBase = Convert.ToInt32(Console.ReadLine());
                    int numSoma = 0;

                    while (numBase != 0)
                    {
                        if (numBase % 2 != 0)
                        {
                            numSoma += numBase;
                        }
                        Console.WriteLine("Insira mais um número inteiro:");
                        numBase = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine($"A soma dos números impares citados é {numSoma}.");

                    #endregion
                    break;
                case 3:
                    #region Atividade 3 - Tabuada Personalizada
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("=====N3A3 - Tabuada Personalizada=====");
                    Console.ResetColor();
                    Console.WriteLine("Insira um número:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Até que número você quer calculá-lo?");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    if (limit < 0)
                    {
                        for (int i = 0; i >= limit; i--)
                        {
                            Console.WriteLine($"{numero}x{i} = {numero * i}");
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= limit; i++)
                        {
                            Console.WriteLine($"{numero}x{i} = {numero * i}");
                        }
                    }

                    #endregion
                    break;
                case 4:
                    break;


            }
            break;

        case 4:
            Console.WriteLine("Atividades do Nível 4:\n" +
                "1. Inversão de Array\n" +
                "2. Busca e Contagem em Lista\n" +
                "3. Gerenciador de Tarefas Simples\n" +
                "4.Voltar para a escolha de nível");
            Console.Write("Opção Escolhida: ");
            escolhaAtividade = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Limpa o console para melhor visualização da atividade escolhida;

            switch (escolhaAtividade)
            {
                case 1:
                    #region Atividade 1 - Inversão de Array
                    Console.ForegroundColor = ConsoleColor.Red ;
                    Console.WriteLine("=====N4A1 - Inversão de Array=====");
                    Console.ResetColor();
                    string[] names = new string[5];

                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.Write($"Insira o {i+1}º de {names.Length} nomes: ");
                        names[i]=Console.ReadLine();
                    } 

                    Console.WriteLine(); //Pulo de linha para melhor visualização no console;

                    Console.WriteLine($"Array original: {string.Join(", ", names)}.");
                    Array.Reverse(names);
                    Console.WriteLine($"Array reversa: {string.Join(", ", names)}.");
                    #endregion
                    break;
                case 2:
                    #region Atividade 2 - Busca e Contagem em Lista (foreach)

                    List<string> cores = new List<string>();

                        int escolhaCor = 0;
                        while (escolhaCor != 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=====N4A2 - Busca e Contagem em Lista====");
                        Console.ResetColor();
                        Console.WriteLine("Escolha uma opção:\n" +
                            "1. Adicionar cor\n" +
                            "2. Contar cor e sair");
                        escolhaCor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(); //Pulo de linha para melhor visualização no console;

                        switch (escolhaCor)
                        {
                            case 1:
                                Console.WriteLine("Insira uma cor:");
                                cores.Add(Console.ReadLine());

                                Console.Clear();

                                break;
                            case 2:
                                Console.Clear();
                                
                                break;
                            default:
                                Console.WriteLine("Opção inválida, tente novamente.");
                                break;
                        }
                    }

                    int contador = 0;

                    HashSet<string> coresUnicas = new HashSet<string>(cores);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=====N4A2 - Busca e Contagem em Lista====");
                    Console.ResetColor();

                    Console.WriteLine($"Insira uma cor ({string.Join(", ", coresUnicas)})");
                    string cor = Console.ReadLine();
                    foreach (string coresRepeticao in cores)
                    {
                        if (coresRepeticao.ToLower() == cor.ToLower())
                        {
                            contador++;
                        }

                    }

                    Console.WriteLine($"A cor {cor} aparece {contador} vezes.");
                    #endregion
                    break;
                case 3:
                    #region Atividade 3 - Gerenciador de Tarefas Simples (CRUD Básico em Memória)
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=====N4A3 - Gerenciador de Tarefas=====");
                    Console.ResetColor();
                    int opcao = 0;
                    List<string> tarefas = new List<string>();

                    while (opcao != 3)
                    {
                        Console.WriteLine("Escolha uma opção:\n" +
                            "1. Adicionar Tarefa\n" +
                            "2. Listar Tarefa\n" +
                            "3. Sair");
                        Console.Write("Opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(); //Pulo de linha para melhor visualização no console;

                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine("Insira a tarefa que você quer adicionar:");
                                tarefas.Add(Console.ReadLine());
                                break;

                            case 2:
                                if (tarefas == null || tarefas.Count == 0)
                                {
                                    Console.WriteLine("Sua lista ainda está vazia, insira alguma tarefa.");
                                    break;
                                }
                                Console.WriteLine("Tarefas:");
                                foreach (string tarefa in tarefas)
                                {
                                    Console.WriteLine($"{tarefas.IndexOf(tarefa) + 1} - {tarefa}");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Você saiu do Gerenciador de Tarefas.");
                                break;
                            default:
                                Console.WriteLine("Opcão inexistente, tente novamente.");
                                break;
                        }
                        Console.WriteLine(); //Pulo de linha para melhor visualização no console;
                    }

                    #endregion
                    break;
                case 4:
                    break;


            }
            break;

        case 5:
            Console.WriteLine("Você saiu do sistema. ");
            break;

    }

    if (escolhaNivel != 5 && escolhaAtividade != 4)
    {
        Console.WriteLine(); //Pulo de linha para melhor visualização no console;

        for (int i = 5; i > 0; i--) //Contagem regressiva para voltar para a escolha de níveis
        {
            Console.Write("\rVocê voltará para a escolha de");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" níveis ");
            Console.ResetColor();
            Console.Write($"em {i}...");
            Thread.Sleep(1000);
        }
        escolhaNivel = 0;
        escolhaAtividade = 0;
        Console.Clear(); //Limpa o console para melhor visualização da escolha de níveis;
    }

}
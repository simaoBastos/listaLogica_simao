#region Nivel 1 - Variáveis e Operações Básicas

#region Atividade 1 - Calculadora de Média Simples
//Console.WriteLine("=====N1A1 - Calculadora de Média Simples=====");
//Console.WriteLine("Insira sua primeira nota:");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira sua segunds nota:");
//double nota2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira sua terceira nota:");
//double nota3 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira sua quarta nota:");
//double nota4 = Convert.ToDouble(Console.ReadLine());
//double media = (nota1 + nota2 + nota3 + nota4) /3;
//Console.WriteLine($"Sua média é {media}.");
#endregion

#region Atividade 2 - Conversor de Idade
//Console.WriteLine("=====N1A2 - Conversor de Idade=====");
//Console.WriteLine("Qual a sua idade?");
//double idade = Convert.ToDouble(Console.ReadLine());

//double idadeDias = idade * 365;

//Console.WriteLine($"Você está vivo há aproximadamente {idadeDias} dias!");
#endregion

#region Atividade 3 - Troca de Valores
//Console.WriteLine("=====N1A3 - Troca de Valores=====");


//Console.WriteLine("Insira o primeiro valor:");
//int A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insira o segundo valor:");
//int B = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Valor A: {A}\nValor B: {B}");

//int temp = A;
//A = B;
//B = temp;

//Console.WriteLine("==== Troca de valores ====");

//Console.WriteLine($"Valor A: {A}\nValor B: {B}");
#endregion

#endregion

#region Nivel 2 - Estruturas Condicionais (if, else if, else)

#region Atividade 1 - Verificador de Maioridade
//Console.WriteLine("=====N2A1 - Verificador de Maioridade=====");
//Console.WriteLine("Insira sua idade:");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Parabéns, você é maior de idade, portanto já pode votar!");
//}
//else {
//    Console.WriteLine($"Você ainda não é maior de idade, portanto ainda não pode votar!");
//} 
#endregion

#region Atividade 2 - Classificador de Números
//Console.WriteLine("=====N2A2 - Classificador de Números=====");
//Console.WriteLine("Insira um número:");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num == 0)
//{
//    Console.WriteLine("O seu número é zero, portanto ele é par!");
//}
//else if (num > 0 && num % 2 == 0)
//{
//    Console.WriteLine($"O seu número é {num}, portanto ele é par e positivo!");
//}
//else if (num > 0 && !(num % 2 == 0))
//{
//    Console.WriteLine($"O seu numero é o {num}, portanto ele é ímpar e positivo!");
//}
//else if (num < 0) {
//    Console.WriteLine($"O seu número é o {num}, portanto ele é negativo!");
//}

#endregion

#region Atividade 3 - Validador de Login Simples
//Console.WriteLine("=====N2A3 - Validador de Login Simples=====");
//string usuario_correto = "admin";
//string senha_correta = "12345";

//Console.WriteLine("Insira o seu nome de usuário:");
//string usuario_informado = Console.ReadLine();
//Console.WriteLine("Insira sua senha:");
//string senha_informada = Console.ReadLine();

//if (usuario_correto == usuario_informado && senha_correta == senha_informada)
//{
//    Console.WriteLine("Login efetuado com sucesso!");
//}
//else
//{
//    Console.WriteLine("Usuário ou senha inválidos.");
//}


#endregion

#endregion

#region Nivel 3 - Estruturas de Repetição (Loops)

#region Atividade 1 - Contagem regressiva
//Console.WriteLine("=====N3A1 - Contagem Regressiva=====");
//Console.WriteLine("Insira um número para iniciar a contagem:");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Contagem regressiva:");

//for (int i = num; i > 0; i--)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(1000);
//}

//Console.WriteLine("Lançar!");
#endregion

#region Atividade 2 - Soma de ímpares
//Console.WriteLine("=====N3A2 - Soma de ímpares=====");
//Console.WriteLine("Insira um número inteiro:");
//int numBase = Convert.ToInt32(Console.ReadLine());
//int numSoma = 0;

//while (numBase != 0)
//{
//    if (numBase % 2 != 0)
//    {
//        numSoma += numBase;
//    }
//    Console.WriteLine("Insira mais um número inteiro:");
//    numBase = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine($"A soma dos números impares citados é {numSoma}.");

#endregion

#region Atividade 3 - Tabuada Personalizada
//Console.WriteLine("=====N3A3 - Tabuada Personalizada=====");
//Console.WriteLine("Insira um número:");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Até que número você quer calculá-lo?");
//int limit = Convert.ToInt32(Console.ReadLine());
//if (limit < 0)
//{
//    for (int i = 0; i >= limit; i--)
//    {
//        Console.WriteLine($"{num}x{i} = {num * i}");
//    }
//}
//else
//{
//for (int i = 1; i <= limit; i++)
//{
//    Console.WriteLine($"{num}x{i} = {num * i}");
//}
//}

#endregion

#endregion

#region Nível 4 - Coleções (Arrays e Listas)

#region Atividade 1 - Inversão de Array
//Console.WriteLine("=====N4A1 - Inversão de Array=====");
//string[] names = { "Joao", "Carlos", "Daniel", "Dracula", "Whatsapp" };
//Console.WriteLine($"Array original:{string.Join(", ", names)}.");
//Array.Reverse(names);
//Console.WriteLine($"Array reversa:{string.Join(", ", names)}.");
#endregion

#region Atividade 2 - Busca e Contagem em Lista (foreach)
//Console.WriteLine("=====N4A2 - Busca e Contagem em Lista====");

//List <string> cores = new List<string> {"Azul", "Verde", "Azul", "Azul", "Amarelo", "Vermelho", };
//int contador = 0;

//Console.WriteLine("Insira uma cor (Azul, Verde ou Vermelho)");
//string cor = Console.ReadLine();
//foreach (string coresRepeticao in cores)
//{
//    if (coresRepeticao.ToLower() == cor.ToLower())
//    {
//        contador++; 
//    }

//}

//Console.WriteLine($"A cor {cor} aparece {contador} vezes.");
#endregion

#region Atividade 3 - Gerenciador de Tarefas Simples (CRUD Básico em Memória)
//Console.WriteLine("=====N4A3 - Gerenciador de Tarefas=====");
//int opcao = 0;
//List<string> tarefas = new List<string>();

//while (opcao != 3) {
//    Console.WriteLine("Escolha uma opção:\n" +
//        "1. Adicionar Tarefa\n" +
//        "2. Listar Tarefa\n" +
//        "3. Sair");
//    Console.Write("Opção: ");
//    opcao = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(); //Pulo de linha para melhor visualização no console;

//    switch (opcao)
//    {
//        case 1:
//            Console.WriteLine("Insira a tarefa que você quer adicionar:");
//            tarefas.Add(Console.ReadLine());
//            break;

//        case 2:
//            if (tarefas == null || tarefas.Count == 0)
//            {
//                Console.WriteLine("Sua lista ainda está vazia, insira alguma tarefa.");
//                break;
//            }
//            Console.WriteLine("Tarefas:");
//            foreach (string tarefa in tarefas)
//            {
//                Console.WriteLine($"{tarefas.IndexOf(tarefa)+1} - {tarefa}");
//            }
//            break;
//        case 3:
//            Console.WriteLine("Você saiu do Gerenciador de Tarefas.");
//            break;
//        default:
//            Console.WriteLine("Opcão inexistente, tente novamente.");
//            break;
//    }
//    Console.WriteLine(); //Pulo de linha para melhor visualização no console;
//}

#endregion
#endregion
#region Nivel 1
#region Atividade 1
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

#region Atividade 2
//Console.WriteLine("Qual a sua idade?");
//double idade = Convert.ToDouble(Console.ReadLine());

//double idadeDias = idade * 365;

//Console.WriteLine($"Você está vivo há aproximadamente {idadeDias} dias!");
#endregion

#region Atividade 3
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

#region Nivel 2

#region Atividade 1 - Verificador de Maioridade
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

#region Nivel 3

#region Atividade 1 - Contagem regressiva
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



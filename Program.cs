class Program
{
    private static void Main(string[] args)
    {
        /*
         Os comandos abaixo são válidos apenas para o tipo "Console Application":
         Comandos de saída de dados:
            Console.Write(string textoAqui): Escreve um texto na tela.
            Console.WriteLine(string textoAqui): Escreve um texto na tela e após apresenta-lo salta uma linha (quebra de linha).
         Comandos de entrada de dados:
            Console.Read(): Ler o próximo caractere que o usuário, mas retorna um inteiro (Inteiro do número ASCII do caractere informado).
            Console.ReadKey(): Ler a próxima tecla pressionada e retorna uma estrutura ConsoleKeyInfo (que pode facilmente fornecer a tecla pressionada acessando as propriedades Key e/ou KeyChar).
            Console.ReadLine(): Ler tudo o que o usuário digitar até que seja pressionado a tecla "Enter". Este método recebe uma string(texto digitado pelo usuário) e retorna uma string. (Use ele no exercício seguinte)
        *//*
        int CodigoASCII = Console.Read();
        char Letra = (char)CodigoASCII;
        Console.WriteLine("Codigo ASCII: " + CodigoASCII + " - Letra: " + Letra);
        Console.ReadKey();
         */

        Console.WriteLine("Qual o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua Iddade: ");
        string idade = Console.ReadLine();

        int IdadeAno = int.Parse(idade);
        int AnoNascimento = DateTime.Now.Year - IdadeAno;

        Console.WriteLine("Seu nome é: " + nome);
        Console.WriteLine("Seu Idade é " + idade +", Nasceu no Ano de: " + AnoNascimento);

        Console.ReadKey();


    }
}


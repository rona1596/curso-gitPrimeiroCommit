using System;
using System.Collections.Generic;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)

        {
            #region[Apenas um teste no commit 10082021]
            #endregion

            #region[DateTimeKind - ISO 8601]

            //DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            //Console.WriteLine();
            //== O certo
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            
            //Console.WriteLine();

            //Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            //Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            //==  Z indica que a data/hora está em Utc

            #endregion

            #region[Operações com TimeSpan]

            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);
            //Console.WriteLine("Days: " + t.Days);
            //Console.WriteLine("Hours: " + t.Hours);
            //Console.WriteLine("Minutes: " + t.Minutes);
            //Console.WriteLine("Milliseconds: " + t.Milliseconds);
            //Console.WriteLine("Seconds: " + t.Seconds);
            //Console.WriteLine("Ticks: " + t.Ticks);
            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //t1 = new TimeSpan(1, 30, 10);
            //t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            #endregion

            #region[Operações com DateTime]

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //d = new DateTime(2001, 8, 15, 13, 45, 58);
            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();
            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //DateTime x =...
            //DateTime y = x.Add(timeSpan);
            //DateTime y = x.AddDays(double);
            //DateTime y = x.AddHours(double);
            //DateTime y = x.AddMilliseconds(double);
            //DateTime y = x.AddMinutes(double);
            //DateTime y = x.AddMonths(int);
            //DateTime y = x.AddSeconds(double);
            //DateTime y = x.AddTicks(long);
            //DateTime y = x.AddYears(int);
            //DateTime y = x.Subtract(timeSpan);
            //TimeSpan t = x.Subtract(dateTime);

            #endregion

            #region[TimeSpan - Duração = Intervalo entre dois instantes]

            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);

            //t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            //t1 = TimeSpan.FromDays(1.5);
            //t2 = TimeSpan.FromHours(1.5);
            //t3 = TimeSpan.FromMinutes(1.5);
            //t4 = TimeSpan.FromSeconds(1.5);
            //t5 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            #endregion

            #region[DateTime]

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d4 = new DateTime(2000, 8, 15);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            //Console.WriteLine(d4);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //d1 = DateTime.Now;
            //d2 = DateTime.UtcNow;
            //d3 = DateTime.Today;
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //d1 = DateTime.Parse("2000-08-15");
            //d2 = DateTime.Parse("2000-08-15 13:05:58");
            //d3 = DateTime.Parse("15/08/2000");
            //d4 = DateTime.Parse("15/08/2000 13:05:58");
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            //CultureInfo.InvariantCulture);
            //d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            //CultureInfo.InvariantCulture);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            #endregion

            #region[Funções interessantes para string]

            //    Checklist
            //• Formatar: ToLower(), ToUpper(), Trim()
            //• Buscar: IndexOf, LastIndexOf
            //• Recortar: Substring(inicio), Substring(inicio, tamanho)
            //• Substituir: Replace(char, char), Replace(string, string)
            //• String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
            //• str.Split(' ')
            //• Conversão para numero: int x = int.Parse(str), int x = Convert.ToInt32(str)
            //• Conversão de número: str = x.ToString(), str = x.ToString("C"), str =
            //x.ToString("C3"), str = x.ToString("F2")

            //string original = "abcde FGHIJ ABC abc DEFG ";
            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();
            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");
            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);
            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");
            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf('bc'): " + n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);
            //Console.WriteLine("Substring(3): -" + s4 + "-");
            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            //Console.WriteLine("IsNullOrEmpty: " + b1);
            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            #endregion

            #region[Exercicío 2 - Matrix / Resolução]

            //Fazer um programa para ler dois números inteiros M e N, e depois ler
            //uma matriz de M linhas por N colunas contendo números inteiros,
            //podendo haver repetições. Em seguida, ler um número inteiro X que
            //pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            //esquerda, acima, à direita e abaixo de X, quando houver, conforme
            //exemplo

            //string[] line = Console.ReadLine().Split(' ');
            //int m = int.Parse(line[0]);
            //int n = int.Parse(line[1]);

            //int[,] mat = new int[m, n];

            //for (int i = 0; i < m; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mat[i, j] == x)
            //        {
            //            Console.WriteLine("Position " + i + "," + j + ":");
            //            if (j > 0)
            //            {
            //                Console.WriteLine("Left: " + mat[i, j - 1]);
            //            }
            //            if (i > 0)
            //            {
            //                Console.WriteLine("Up: " + mat[i - 1, j]);
            //            }
            //            if (j < n - 1)
            //            {
            //                Console.WriteLine("Right: " + mat[i, j + 1]);
            //            }
            //            if (i < m - 1)
            //            {
            //                Console.WriteLine("Down: " + mat[i + 1, j]);
            //            }
            //        }
            //    }
            //}

            #endregion

            #region[Exercicío 1 - Matriz / Verificando quantidade de numeros negativos, pega valores na diagonal]

            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            ////Para cada uma das linhas
            //for (int i = 0; i < n; i++)
            //{
            //    //Lendo a linha inteira, recortando os espaços em branco
            //    string[] values = Console.ReadLine().Split(' ');
            //    //Percorre as colunas
            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            ////Pegar valores na diagonal
            //Console.WriteLine("Main diagonal:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i] + " ");
            //}
            //Console.WriteLine();

            //int count = 0;
            ////Estrutura básica para percorrer uma matrix (**)
            //for (int i = 0; i < n; i++)
            //{
            //    //(**)
            //    for (int j = 0; j < n; j++)
            //    {
            //        //Verificando todos os numeros negativos na matrix
            //        if (mat[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Negative numbers: " + count);

            #endregion

            #region[Exercicío - Laço Foreach]

            //Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de
            //N funcionários.Não deve haver repetição de id.
            //Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            //Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma
            //mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            //conforme exemplos.
            //Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            //ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            //aumento por porcentagem dada

            //---------------------------------------------------------------------------------------

            //Console.Write("How many employees will be registered? ");
            //int n = int.Parse(Console.ReadLine());

            //List<Employee> list = new List<Employee>();

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Employee #" + i + ":");
            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    list.Add(new Employee(id, name, salary));
            //    Console.WriteLine();
            //}

            //Console.Write("Enter the employee id that will have salary increase : ");
            //int searchId = int.Parse(Console.ReadLine());

            //Employee emp = list.Find(x => x.Id == searchId);
            //if (emp != null)
            //{
            //    Console.Write("Enter the percentage: ");
            //    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    emp.IncreaseSalary(percentage);
            //}
            //else
            //{
            //    Console.WriteLine("This id does not exist!");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Updated list of employees:");
            //foreach (Employee obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            #region[Laço Foreach]

            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");
            //list.Insert(2, "Marco");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("List count: " + list.Count);
            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': " + s1);
            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);
            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos1);
            //int pos2 = list.FindLastIndex(x => x[0] == 'A');

            //Console.WriteLine("Last position 'A': " + pos2);
            //List<string> list2 = list.FindAll(x => x.Length == 5);

            //Console.WriteLine("---------------------");

            //foreach (string obj in list2)
            //{
            //    Console.WriteLine(obj);
            //}
            //list.Remove("Alex");

            //Console.WriteLine("---------------------");

            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //list.RemoveAll(x => x[0] == 'M');

            //Console.WriteLine("---------------------");

            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            #endregion

            #region[Modificador params - out]

            //int a = 10;
            //int triple;

            //Calculator.Triple(a, out triple);
            //Console.WriteLine(triple);

            #endregion

            #region[Modificador params - ref]

            //int a = 10;

            //Calculator.Triple(ref a);
            //Console.WriteLine(a);

            #endregion

            #region[Modificador params - Sum]

            //int s1 = Calculator.Sum( 2, 3 );
            //int s2 = Calculator.Sum( 2, 3, 7 );

            //Console.WriteLine(s1 + s2);

            #endregion

            #region[Exercicío de Fixação - Vetor complexo]

            //Estudante[] vect = new Estudante[10];
            //Console.Write("Quantos quartos serão alugados? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Aluguel #{i}:");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Quarto: ");
            //    int quarto = int.Parse(Console.ReadLine());
            //    vect[quarto] = new Estudante(nome, email);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Quartos ocupados:");

            //for (int i = 0; i < 10; i++)
            //{
            //    if (vect[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + vect[i]);
            //    }
            //}

            #endregion

            #region[Entrada de dados com vetor - Parte 2]

            //int n = int.Parse(Console.ReadLine());
            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region[Entrada de dados com vetor - Parte 1]

            //int n = int.Parse(Console.ReadLine());
            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region[Conta Corrente]

            //ContaCorrente conta;

            //Console.WriteLine("Digite o nome do titular da conta: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite o número da conta: ");
            //int numeroConta = int.Parse(Console.ReadLine());

            //Console.WriteLine("Havera deposito Inicial ?");
            //char resp = char.Parse(Console.ReadLine());

            //if (resp == 'S' || resp == 's')
            //{
            //    Console.WriteLine("Digite o valor a ser depositado: ");
            //    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    conta = new ContaCorrente(numeroConta, nome, valor);
            //    Console.WriteLine(conta);
            //}
            //else
            //{
            //    conta = new ContaCorrente(numeroConta, nome);
            //    Console.WriteLine(conta);
            //}

            #endregion

            #region[Conversor Dolares - Static]
            //Console.Write("Qual é a cotação do dólar? ");
            //double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantos dólares você vai comprar? ");
            //double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            //Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region[Calculadora - Static]

            //Console.Write("Entre o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double circ = Calculadora.Circunferencia(raio);
            //double volume = Calculadora.Volume(raio);

            //Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region[Exercicío - Aluno]
            //Aluno aluno = new Aluno();
            //Console.Write("Nome do aluno: ");

            //aluno.Nome = Console.ReadLine();
            //Console.WriteLine("Digite as três notas do aluno:");

            //aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            //if (aluno.Aprovado())
            //{
            //    Console.WriteLine("APROVADO");
            //}
            //else
            //{
            //    Console.WriteLine("REPROVADO");
            //    Console.WriteLine("FALTARAM "
            //    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            //    + " PONTOS");
            //}

            #endregion

            #region[Exercicío - Funcionário]
            //Funcionario func = new Funcionario();

            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();

            //Console.Write("Salario bruto: ");
            //func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine("Funcionário: " + func);

            //Console.WriteLine();
            //Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            //double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //func.AumentarSalario(porcent);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + func);
            #endregion

            #region[Exercicío - Retangulo]
            //Retangulo ret = new Retangulo();

            //Console.WriteLine("Entre a largura e altura do retângulo: ");

            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region[Produto]

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();

            //Console.Write("Preço do produto: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);

            //p.Nome = "Rona";

            //Console.WriteLine(p.Nome);

            //Produto p2 = new Produto 
            //{ 
            //    Nome = "Ronaldo",
            //    Preco = 2.00,
            //    Quantidade = 1
            //};

            //Produto p3 = new Produto()
            //{
            //    Nome = "Ronaldo",
            //    Preco = 2.00,
            //    Quantidade = 1
            //};

            //Console.WriteLine();
            //Console.WriteLine("Dados do Produto: " + p + p2);

            //Console.WriteLine();
            //Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qtd = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qtd);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizado: " + p);

            //Console.WriteLine();
            //Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            //qtd = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qtd);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizado: " + p);
            #endregion

            Console.ReadLine();
        }
    }
}

using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

































// int quantidadeEntradas = 3;
      
//     while (quantidadeEntradas > 0) {
//       var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
//       if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
//         string[] tartarugas = Console.ReadLine().Split(" ");
//         var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for ( int i = 0; i < tartarugas.Length; i++) {
//           var tartaruga = Int32.Parse(tartarugas[i]);
           
//           if (tartaruga > maiorVelocidade) {
//             maiorVelocidade = tartaruga;
//           }
//         }

//         if(maiorVelocidade < 10) {
//           Console.WriteLine(1);
//         } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
//           Console.WriteLine(2);
//         } else if (maiorVelocidade >= 20) {
//           Console.WriteLine(3);
//         }
//         quantidadeEntradas--;
//       } else {
//         Console.WriteLine("Insira um número entre 1 e 500");
//       }
//     }






















// double salario = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 
  
//     salario = Convert.ToDouble(Console.ReadLine()); 

// //TODO: Complete os espaços em branco com uma possível solução para o problema:
   
//     if( salario < 0) { 
//       return; 

//     } else if ( salario <= 400 ) { 
//       percentual = 0.15; 
//       reajuste =  salario * percentual; 
//       novoSalario =   salario + reajuste; 


//     } else if ( salario    <= 800) { 
//       percentual =   0.12; 
//       reajuste =  salario * percentual; 
//       novoSalario =   salario + reajuste; 

//     } else if ( salario   <= 1200) { 
//       percentual = 0.10; 
//       reajuste =  salario * percentual; 
//       novoSalario =   salario + reajuste; 

//     } else if ( salario   <= 2000) { 
//       percentual =  0.07; 
//       reajuste =  salario * percentual; 
//       novoSalario =   salario + reajuste; 

//     } else { 
//       percentual = 0.04; 
//       reajuste =  salario * percentual; 
//       novoSalario =   salario + reajuste;  

//     } 

//     Console.WriteLine($"Novo salario: {novoSalario:0.00}"); 
//     Console.WriteLine($"Reajuste ganho: {reajuste:0.00}"); 
//     Console.WriteLine($"Em percentual: {percentual:0 %}");











int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(num.majorityElement());
        

    



// int a = 10;
// int b =a;

// Console.WriteLine($"Valor de a = {a}");
// Console.WriteLine($"Valor de b = {b}");
// b = 20;
// Console.WriteLine($"Mudando Valor de b para {b}");
// Console.WriteLine($"Valor de a = {a}");







// Pessoa p1 = new Pessoa("Tiago", "Furtado");
// Pessoa p2 = new Pessoa("Taissa", "Oliveira");

// Console.WriteLine($"Nome da pessoa 1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa 2: {p2.NomeCompleto}");

// Pessoa p3 = p1;

// p3.Nome = "Neide";

// Console.WriteLine($"Nome da pessoa 3: {p3.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa 1: {p1.NomeCompleto}");




// int numero = 20;

// bool ehPar = false;
// // IF Ternario

// ehPar = numero.EhPar();

// Console.WriteLine($"O numero {numero} é {(ehPar ? "par": "impar")}");
















// MeuArray<int> arrayInteiro = new MeuArray<int>();


// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();


// arrayString.AdicionarElementoArray("Tiago");
// Console.WriteLine(arrayString[0]);




// dynamic variavelDinamica = 4.00400055344536456634563464564;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, e seu valor: {variavelDinamica}");

// variavelDinamica = "Tiago";

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, e seu valor: {variavelDinamica}");









// string json = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(json);

// var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});
// foreach (var item in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {item.Produto}, Preco: {item.Preco}");
// }




// var tipoAnonimo = new { Nome = "Tiago", Sobrenome = "Furtado", Idade = 20};


// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Idade: {tipoAnonimo.Idade}");













// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuario optou por receber e-mail.");
// }else
// {
//     Console.WriteLine("O usuario nao respondeu ou nao optou por nao recerber email");
// }

// var json = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(json);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco :C}, Data: {venda.DataVenda :dd/MM/yyyy}{(venda.Desconto.HasValue ? $", Desconto Venda: {venda.Desconto :C}" : "")}");
// }







// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();
// Venda v1 = new Venda(1, "Material de Escritorio", 25.00M, dataAtual);
// Venda v3 = new Venda(2, "Licenca Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v3);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

// Venda v2 = JsonConvert.DeserializeObject<Venda>(serializado);

// Console.WriteLine($"{v2.Id} - {v2.Preco} - {v2.Produto}");












// int numero = 21;

// bool ehPar = false;
// // IF Ternario

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O numero {numero} é {(ehPar ? "par": "impar")}");


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }else
// {
//     Console.WriteLine($"O numero {numero} é ímpar");
// }

















// Pessoa p1 = new Pessoa("Tiago", "Furtado");

// (string nome1, string sobrenome) = p1;

// Console.WriteLine($"Nome: {nome1}, Sobrenome: {sobrenome}");














// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Tiago", "Furtado", 10.5M);
// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Tiago", "Furtado", 10.5M);
// var maisUmExemploDeTupla = Tuple.Create(1, "Tiago", "Furtado", 10.5M);

// Console.WriteLine(new LeituraArquivo().LerArquivo("Arquivos/arquivoLeitura.txt"));

// LeituraArquivo arquivo = new LeituraArquivo();

// (bool sucesso, string[] linhas, _) =  arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine($"Quantidade de Linhas: {quantidadeLinhas}");
//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }else
// {
//     Console.WriteLine("Caminha inexistente");
// }



















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("SP", "Sao Paulo");
// estados.Add("MG", "Minas Gerais");

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value} - {item}");
// }

// estados.Remove("SP");
// estados["RJ"] = "Rio de janeiro - valor alterado";
// Console.WriteLine("---------");

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value} - {item}");
// }

// string chave = "RJ1";
// Console.WriteLine($"Verificando o elemento {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"valor existente: {chave}");
// }else
// {
//     Console.WriteLine($"valor nao existe: {chave}");
// }



// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo {pilha.Pop()}");
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);
// Console.WriteLine(fila.Count);
// Console.WriteLine(fila.Max());

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// fila.Dequeue();
// foreach(int item in fila)
// {
//     Console.WriteLine("------------");
//     Console.WriteLine(item);
// }






















// new ExemploExcecao().Metodo1();


















// try
// {

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretorio nao encontrado {ex.Message}");
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo nao encontrado {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uam excecao generica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou ate aqui");
// }




















// DateTime data = DateTime.Now;

// Console.WriteLine(data);
// Console.WriteLine($"{data:dd/MM/yyyy}");
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime dataParse = DateTime.Parse("17/04/2022 18:00");

// Console.WriteLine(dataParse);

// string dataStringTryParse = "2022-11-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataStringTryParse, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime date);

// if (sucesso)
// {
//     Console.WriteLine($"Conversao feita com sucesso, data: {date:dd/MM/yyy}");
// }
// else
// {
//     Console.WriteLine($"Data Invalida");
// }
// DateTime.TryParse(dataStringTryParse, out DateTime date1);

// Console.WriteLine(date);
// Console.WriteLine(date1);








// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine($"{valorMonetario:C3}");

// Console.WriteLine($"{valorMonetario.ToString("C3")}");

// Console.WriteLine($"{valorMonetario:N5}");
// Console.WriteLine($"{valorMonetario.ToString("N5")}");

// Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");


// double porcentagem = .3421;

// Console.WriteLine($"{porcentagem:P3}");
// Console.WriteLine($"{porcentagem.ToString("P")}");


// long numero = 24998550570;

// Console.WriteLine($"{numero:(##) #########}");
// Console.WriteLine($"{numero.ToString("##-#########")}");





// Pessoa p1 = new Pessoa("Tiago", "Furtado");

// Pessoa p2 = new Pessoa(nome:"Taissa", sobrenome:"Oliveira");

// Curso c1 = new Curso();
// c1.Nome = "Curso de Ingles";

// c1.AdicionarAlunos(p1);
// c1.AdicionarAlunos(p2);
// Console.WriteLine(c1.ObterQuantidadeDeAlunosMatriculados());
// c1.ListarAlunos();
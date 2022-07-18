Console.WriteLine("Hello\nWorld!");// nova linha \n
Console.WriteLine("Hello\tWorld!");// adicionará uma guia \t


//E se você precisar inserir uma aspa dupla em uma cadeia de caracteres literal?
Console.WriteLine("Hello \"World\"!");


//E se você precisar usar a barra invertida para outras finalidades, como exibir um caminho de arquivo?
Console.WriteLine("c:\\source\\repos");

//Exiba a saída a seguir.
/*
Generating invoices for customer "ABC Corp" ...

Invoice: 1021		Complete!
Invoice: 1022		Complete!

Output Directory:
*/
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//itens mais importantes a serem lembrados sobre a formatação de cadeias de caracteres literais:
//   \t uma tabulação
//   \n uma nova linha
//   \" uma aspa dupla
//   Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
//   Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
//   Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
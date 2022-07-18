Console.WriteLine('a');// aspas simples para um caractere.

Console.WriteLine("conjunto de caracteres");//aspas dupla para um conjunto de caracteres.

Console.WriteLine(84);//numero inteiro

Console.WriteLine(84.5m);// usa-se o "m" no final para números decimas

Console.WriteLine(true);//boolean
Console.WriteLine(false);//bolean

Console.WriteLine("123");//string
Console.WriteLine(123);// inteiro

Console.WriteLine("true");//string
Console.WriteLine(true);//boolean



//Declarando uma Variável
//Para criar uma nova variável, primeiro você deve declarar o tipo de dados da variável e, em seguida, dar um nome a ela.
//Nesse caso, estamos criando uma nova variável do tipo string chamada firstName.
string firstName;

string firstNome;//Criando variável
firstNome = "Roberto";//Atribuindo Valor
Console.WriteLine(firstNome);//Recuperando valor armazenado
firstNome = "Conrado";//Reatribuindo Valor
Console.WriteLine(firstNome);//Recuperando novo valor armazenado
firstNome = "Vitória";//Reatribuindo Valor
Console.WriteLine(firstNome);//Recuperando novo valor armazenado
firstNome = "Santos";//Reatribuindo Valor
Console.WriteLine(firstNome);//Recuperando novo valor armazenado

//Na verdade, você pode declarar e definir o valor da variável em uma linha de código. Essa técnica é chamada de inicializar a variável.
string firstName = "Marcos";//Criando variável e atribuindo valor
Console.WriteLine(firstName);//Recuperando o valor

//O que são variáveis locais de tipo implícito?

//Uma variável local de tipo implícito é criada usando a palavra-chave var, que instrui o compilador de C# a inferir o tipo. Depois de inferir o tipo, é como se o tipo de dados real tivesse sido usado para declarar a variável.

var message = "Hello world!";//instância do tipo string.
//a variável message é definida para ser do tipo cadeia de caracteres e para nunca poder ser alterada do tipo string

message = "alterei o valor!";
Console.WriteLine(message);//novo valor recuperado === alterei o valor!

//Etapa 1: escrever o código no Editor
//Quando você tiver terminado, a mensagem deverá ser semelhante à seguinte saída: Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
// Concatenar uma cadeia de caracteres literal e uma variável.
string firstName = "Beto";
string mensagem = "Óla " + firstName;
Console.WriteLine(mensagem);

//Concatenar diversas variáveis e cadeias de caracteres literais.
string primeiroNome = "Roberto";
string saudar = "Óla";
string message = saudar + " " + primeiroNome + "!";
Console.WriteLine(message);
//Usamos uma variável extra para conter a nova cadeia de caracteres resultante da operação de concatenação. A menos que você tenha um bom motivo para fazer isso, você pode (e deve) evitar usar variáveis intermediárias executando a operação de concatenação conforme necessário.

//A seguir verá a melhor e mais correta forma a se usar.
string firstName = "Roberto";
string greeting = "Óla";
Console.WriteLine(greeting + " " + firstName + "!");//concatenação
//Interpolação de cadeia de caracteres
string message = $"{greeting} {firstName}!";//interpolação
Console.WriteLine(message);//Recuperando valor armazenado
// Pode se interpolar com cadeia de caracteres: veja a seguir
string secondName = "willians";
string msg = $"Hello {secondName}!";
Console.WriteLine(msg);

//DESAFIO
//Comece a resolver o desafio com as duas linhas de código a seguir.
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

//Para concluir esse desafio, seu código deve produzir a saída a seguir.
View English output:
		c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
		c:\Exercise\ACME\ru-RU\data.txt
        
//SOLUÇÂO
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
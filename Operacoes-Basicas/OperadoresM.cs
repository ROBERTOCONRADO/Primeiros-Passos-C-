//Etapa 1 – Escrever código para executar adição, subtração, multiplicação e divisão com ints.

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
/* saida 
Sum: 12
Difference: 2
Product: 35
Quotient: 1
*/

//Aqui temos dois exemplos adicionais que funcionam bem
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;


// As seguintes linhas de código não funcionam (ou fornecem resultados imprecisos):
int decimalQuotient = 7 / 5.0m;// vai dar resultado decimal
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;

//Para converter int em decimal, você adiciona o operador de conversão antes do valor. Use o nome do tipo de dados entre parênteses na frente do valor para convertê-lo. 
int first = 7;
int second = 5;
decimal divisao = (decimal)first / (decimal)second;
Console.WriteLine(divisao);

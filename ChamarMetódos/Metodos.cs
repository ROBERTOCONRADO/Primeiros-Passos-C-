//O exemplo a seguir simula uma jogada de dados gerando um número aleatório e imprimindo-o no console.
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
//Se você executar o código várias vezes, os números de 1 a 6 serão exibidos na saída do console.

//
Random dice = new Random();
int roll1 = dice.Next();//de 0 a 2,147,483,647 que é o valor maximo que um int pode armazenar
int roll2 = dice.Next(101);//um valor aleatório entre 0 e 100.
int roll3 = dice.Next(50, 101);//um valor aleatório entre 50 e 100.

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


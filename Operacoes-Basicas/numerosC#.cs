
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
//Para concatenar números inteiros corretamente deve-se coloacr a espressão entre parenteses para que execute, não cancatene a espressão: veja a seguir

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");//resultado=> Bob sold 77 widgets.

//maneira correta 
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");// resultado=> Bob sold 14 widgets.
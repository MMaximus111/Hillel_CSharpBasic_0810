

byte _age = 42;
short age2 = 56;// 0-255
int health = 100; // -2,147,483,648 to 2,147,483,647
uint score = 100; // 0 to 4,294,967,295
long ordersCount = 1000000000000000000; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

float speed = 100.5f; // -3.4 x 10^38 to 3.4 x 10^38
double kilemeters = 100.5; // 1.7 x 10^308
const double PI = 3.143434445; // 1.7 x 10^308
decimal price = 100.5m; // 1.7 x 10^308

string name1 = "John1";
string name2 = "John2";

string greeting = $@"Hello123
sdsd
sdsdsd {name1}
sdsdsd";

string text = """
{
    "glossary": {
    "title": "example glossary",
		"GlossDiv": {
        "title": "S",
			"GlossList": {
            "GlossEntry": {
                "ID": "SGML",
					"SortAs": "SGML",
					"GlossTerm": "Standard Generalized Markup Language",
					"Acronym": "SGML",
					"Abbrev": "ISO 8879:1986",
					"GlossDef": {
                    "para": "A meta-markup language, used to create markup languages such as DocBook.",
						"GlossSeeAlso": ["GML", "XML"]
                    },
					"GlossSee": "markup"
                }
        }
    }
}
}
""";

char initial = ' ';

bool isWorking = 5 > 7;

// Console.WriteLine($"{name1}  dfdf   ddf fedfd  {name2}");
//Console.Write(isWorking);
//Console.Write("========");


//string? qwerty = null;
//Console.WriteLine(qwerty);
// string? inputFromConsole = Console.ReadLine();

// int ageFromUser = Convert.toint(ageFromUserStr);

//Console.Write("Enter your age: ");

//string ageFromUserStr = Console.ReadLine()!;

//int ageFromUser = int.Parse(ageFromUserStr);

//if (int.TryParse(ageFromUserStr, out ageFromUser))
//{
//    if (ageFromUser < 18)
//    {
//        Console.WriteLine($"Buying alcohol forbidden");
//    }
//    else
//    {
//        Console.WriteLine($"Buying alcohol allowed )");
//    }
//}
//else
//{
//    Console.WriteLine($"Invalid age");
//}


//int x = 5;
//long y = x;

//long z = 4_000_000_000_000;
//int t = (int)z;

//decimal price1 = 100.5m;
//int price2 = (int)price1;

int price5 = (int)Sum(12.5m, 100.5m);

Console.WriteLine(price5);



static decimal Sum(decimal a, decimal b)
{
    return a + b;
}






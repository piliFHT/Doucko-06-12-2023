﻿
    
        /*PROMĚNNÁ

        //Místo v paměti PC kam si můžeme ukládat nějaká data(hodnoty výpočty, mezi-výpočtů, slova, znaky, čísla, výrazy, ..)

        int - Z
        double - R
        string - texty
        bool - true/false *(Jakákoliv NENULOVÁ hodnota, je vždy TRUE {1, 3, -6}
        char - jednotlivé znaky (UNICODE, ASCII, ..)

        C# = staticky typovaný jazyk
        */

        int cislo = 15;

//<datový typ> <identifikátor>; | = <hodnota> |;

//Aritmetika:
// +, -, *, /, % (modulo)
// +=, -=, *=, /=, %= | ==> složené přirazené

cislo = cislo + 1; //16 ==> ekvivalence => cislo += 1;

//unární operátory (jsou jen na jedné straně operandu)
// x++, ++x; inkrementace (+1)
// x--, --x; dekrementace (-1)

int x = 10;
Console.WriteLine(x++);
Console.WriteLine(x);
Console.WriteLine(++x);


//UŽIVATELSKÝ VSTUP
Console.WriteLine("Zadej číslo: ");
var ziskanaHodnota = Console.ReadLine();

//Sčítání INTu
int a = int.Parse("1") + int.Parse("2");
Console.WriteLine(a);
//Sčítání STRINGu
Console.WriteLine("1+1 = 11");
string s = "1" + "1" + "1";
Console.WriteLine(s);


//Console.WriteLine($"Hodnota, kterou jsi zadal(a), je datového typu: {ziskanaHodnota.GetType()}");
//Console.WriteLine($"Parsovaná hodnota, kterou jsi zadal(a), je datového typu: {int.Parse(ziskanaHodnota).GetType()}");
//Parsování = z textového čísla urobíme skutečné aritmeticky použitelné číslo
    
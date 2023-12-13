

//PROMĚNNÁ

//Místo v paměti PC kam si můžeme ukládat nějaká data(hodnoty výpočty, mezi-výpočtů, slova, znaky, čísla, výrazy, ..)

//int - Z
//double - R
//string - texty
//bool - true/false *(Jakákoliv NENULOVÁ hodnota, je vždy TRUE {1, 3, -6})
//char - jednotlivé znaky (UNICODE, ASCII, ..)

//C# = staticky typovaný jazyk

//int cislo = 15;

//<datový typ> <identifikátor>; | = <hodnota> |;

//Aritmetika:
// +, -, *, /, % (modulo)
// +=, -=, *=, /=, %= | --> složené aritmetické výrazy

//cislo = cislo + 1; //16 --> ekvivalence -> cislo += 1;

//unární operátory (jsou jen na jedné straně operandu)
// x++, ++x; inkrementace (+1)
// x--, --x; dekrementace (-1)

//-----------------------------------------

//Praktická ukázka

//int x = 10;
//Console.WriteLine(x++);
//Console.WriteLine(x);
//Console.WriteLine(++x);


////UŽIVATELSKÝ VSTUP
//Console.WriteLine("Zadej číslo: ");
//var ziskanaHodnota = Console.ReadLine();

////Sčítání INTu
//int a = int.Parse("1") + int.Parse("2");
//Console.WriteLine(a);
////Sčítání STRINGu
//Console.WriteLine("1+1 = 11");
//string s = "1" + "1" + "1";
//Console.WriteLine(s);

//-----------------------------------------


//Console.WriteLine($"Hodnota, kterou jsi zadal(a), je datového typu: {ziskanaHodnota.GetType()}");
//Console.WriteLine($"Parsovaná hodnota, kterou jsi zadal(a), je datového typu: {int.Parse(ziskanaHodnota).GetType()}");
//Parsování = z textového čísla urobíme skutečné aritmeticky použitelné číslo

//PODMÍNKY (VĚTVENÍ PROGRAMU)

//Učíme program reagovat na určité situace.
//Rohodovací mechanismus je čistě strojní (0/1) - pravda/nepravda

//---------------------------------------------------

//if (výraz)
//{
//    nějaká reakce
//}
//else if (výraz)
//{
//    nějaká jiná reakce
//}
//else
//{
//    Pokud ostatní reakce nereagují, tohle bude
//}

//---------------------------------------------------

//        \\PRAKTICKÁ UKÁZKA//

//Console.WriteLine("Zadej nějaké hezké číslo: ");
//int hezkeCislo = int.Parse(Console.ReadLine());

//if (hezkeCislo % 2 == 0)
//{
//   Console.ForegroundColor = ConsoleColor.Green;
//   Console.WriteLine("HoVn&o");
//   Console.ForegroundColor = ConsoleColor.White;
//}
//else
//{
//   Console.ForegroundColor = ConsoleColor.Red;
//   Console.WriteLine("Kočička");
//   Console.ForegroundColor = ConsoleColor.White;
//}


//RELAČNÍ OPERÁTORY
//<, <=, >, >=, ==, !=

// = -> přirazuje hodnotu
// == -> testuje hodnotu


//---------------------------------------

//        \\PRAKTICKÁ UKÁZKA//

//Console.WriteLine("Zadejte číslo A: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadejte číslo B: ");
//int b = int.Parse(Console.ReadLine());



//if (a > b)
//{
//    Console.WriteLine("A je větší jak B");
//}
//else if (a == b)
//{
//    Console.WriteLine("A je rovno B");
//}
//else
//{
//    Console.WriteLine("A je menší jak B");
//}

//---------------------------------------

//---------------------------------------

//-------\\DALŠÍ PRAKTICKÁ UKÁZKA//------

//while (true)
//{

//    Console.WriteLine("Zadej číslo v rozsahu od 10-20 nebo 50-60: ");
//    int x = int.Parse(Console.ReadLine());

//    // AND -> &&
//    // OR -> ||
//    // NOT -> !

//    if ((x >= 10) && (x <= 20) || ((x >= 50) && (x <= 60)))
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("Trefil(a) ses! :)");
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Jdi doprdele ty hromado promrdanýho masa!");
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//}

//---------------------------------------

//-------\\Jak funguje AND a OR//--------

//  *1 = true | 0 = false
// | A && B | --> \\AND// --> oba dva musí být true (pravdivý)
// | 1    1 | --> true
// | 1    0 | --> false
// | 0    1 | --> false
// | 0    0 | --> false

//  ( A || B ) --> \\OR// --> aspoň jeden musí být true (pravdivý)
//  ( 1 || 1 ) --> true
//  ( 1 || 0 ) --> true
//  ( 0 || 1 ) --> true
//  ( 0 || 0 ) --> false

//---------------------------------------

//----------\\POLE - ARRAYS//------------

// -->KOLEKCE<-- prvků - shluk po sobě jdoucích hodnot, které mají své pořadí

//>> int[] pole = new int[10]; >>> pole s velikostí 10 prvků
// !!! INDEXY !!!

// Velikost polre = 10 prvků - přístup je pod indexy 0-9 --> velikost pole - 1

//>> pole[5] = 999; >>> na INDEXU 5, je nyní hodnota 999. Všude jinde jsou stále 0
//>> pole[10] = 69; >>> na INDEX 10, jsme chtěli dát hodnotu, ale INDEX 10 v poli s 10ti prvky, není


// -->Zkrácená inicializace pole: 
//>> int[] zkracenePole = {5,6,7,8,9,10,11,12,21}; --> velikost pole 9
// Jak zjistit délku pole?  >>> Console.Writeline(zkracenePole.Length);

// --> Vypsat pole <-- 
//>> for(int i = 0; i < zkracenePole.Length; i++)
//>> {
//>>    Console.WriteLine(zkracenePole[i]); --> vypíše hodnotu na daném INDEXU
//>> }

// --> Setřídit pole <--

//>> Array.Sort(zkracenePole);

//>> for(int i = 0; i < zkracenePole.Length; i++)
//>> {
//>>    Console.WriteLine(zkracenePole[i]); --> vypíše hodnotu na daném INDEXU
//>> }


// --> Aritmetický průměr v poli <--

//>> int[] zkracenePole = {5,6,7,8,9,10,11,12,21};
//>> int soucet = 0;

//>> for(int i = 0; i < zkracenePole.Length; i++)
//>> {
//>>    soucet += zkracenePole[i];
//>> }

//>> Console.WriteLine(soucet/(double)zkracenePole.Length);

//>> double prumer = zkracenePole.Average();
//>> Console.WriteLine(prumer); --> ten "for" cyklus a tahle fce "Average" udělá aritm. průměr z toho pole



//C# Példaprogramok



****REFERENCIÁK ****

//Az érték- illetve referenciatípusok közötti különbség egy másik aspektusa az, ahogyan a forráskódban
//hivatkozunk rájuk. Vegyük a következő kódot:
//int x = 10;
//int y = x;

class MyClass
{
    public int x;
}
    class Program
    {
        static void Main(string[] args)
        {
            MyClass s = new MyClass {x = 10};  //new MyClass(); s.x = 10;  
            MyClass p = s; //ha p módosul, akkor s is így tesz
            p.x = 14; //p nevű referencia ugyanarra a memóriaterületre hivatkozik
            Console.WriteLine(s.x);
            Console.ReadKey();
        }
    }

----------------------------


****BOXING ÉS UNBOXING (bedobozolás)**** (object)
//azt a folyamatot nevezzük, amely megengedi egy értéktípusnak, hogy úgy
//viselkedjen, mint egy referenciatípus.

//A következő forráskód azt mutatja, hogy miként tudunk “kézzel” dobozolni:
int x = 10;
object boxObject = x; // bedobozolva
Console.WriteLine("X értéke: {0}", boxObject);

//Az unboxing (vagy kidobozolás) a boxing ellentéte, vagyis a bedobozolt értéktípusunkból kinyerjük az eredeti értékét
int x = 0;
object obj = x; // bedobozolva
int y = (int)obj; // kidobozolva

//Fontos még megjegyezni, hogy a bedobozolás után teljesen új objektum keletkezik, amelynek semmi köze az eredetihez
int x = 10;
object z = x;
z = (int)z + 10;
Console.WriteLine(x); // 10
Console.WriteLine(z); // 20

------------------------------

****KONSTANSOK**** (const)
//const típusmódosító kulcsszó segítségével egy objektumot konstanssá, megváltoztathatatlanná tehetünk. 

const int x; // Hiba
const int y = 10; // Ez jó
x = 11; // Hiba

//A konstans változóknak adott értéket/kifejezést fordítási időben ki kell tudnia értékelni a fordítónak.

-------------------------------

**** A FELSOROLT TÍPUS enum ****

enum Name
{
    valami,
    valami2,
    valami3
}; //ez is egy mód

enum Name { valami, valami2, valami3 }; //lehet igy is
Name.valami //hivatkozás az egyes felsorolt elemekre

//A felsorolás minden tagjának megfeleltethetünk egy egész (numerikus) értéket. Ha mást nem adunk meg, akkor
//alapértelmezés szerint a számozás nullától kezdődik, és deklaráció szerinti sorrendben (értsd: balról jobbra)
//eggyel növekszik.

//Az Enum.TryParse metódussal string értékekből “gyárthatunk” felsorolt értékeket:

enum Animal { Cat = 1, Dog = 3, Tiger, Wolf }
string s1 = "1";
string s2 = "Dog";
Animal a1, a2;
Enum.TryParse(s1, true, out a1);

----------------------------------

****NULL TÍPUSOK****

//A referenciatípusok az inicializálás előtt automatikusan null értéket vesznek fel, illetve mi magunk is
//megjelölhetjük őket “beállítatlannak”:

class MyClass { }

class Program
{
    static void Main(string[] args)
    {
        MyClass mc = null;
        Console.ReadKey();
    }
}

//Ugyanez az értéktípusoknál már nem alkalmazható:
int x = null; // ez nem jó

// Mert ilyen típus a deklarációja pillanatában (néhány kivételtől eltekintve) automatikusan a megfelelő nulla értékre inicializálódik.
//nullable típusokat a “rendes” típus után írt kérdőjellel jelezzük:

int? x = null; // ez már jó

//Egy nullable típusra való konverzió implicit módon (külön kérés nélkül) megy végbe, míg az ellenkező irányban
//explicit konverzióra lesz szükségünk (vagyis ezt tudatnunk kell a fordítóval):

int y = 10;
int? x = y; // implicit konverzió
y = (int)x; // explicit konverzió

-----------------------------------




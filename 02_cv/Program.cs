// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Complex cislo1 = new Complex(2,3);
Complex cislo2 = new Complex(6,1);
Complex vysledek, ocekavana;
bool vysledekb, ocekavanab;
double vysledekD, ocekavanaD;

// +
vysledek = cislo1 + cislo2;
ocekavana = new Complex(8,4); //
TestComplex.Test(vysledek, ocekavana, "Sčítání");

// -
vysledek = cislo1 - cislo2;
ocekavana = new Complex(-4, 2); //
TestComplex.Test(vysledek, ocekavana, "Odčítání");

//*
vysledek = cislo1 * cislo2;
ocekavana = new Complex(9, 20); //
TestComplex.Test(vysledek, ocekavana, "Násobení");

// /
vysledek = cislo1 / cislo2;
ocekavana = new Complex(0.4054054054, 0.432432432); //
TestComplex.Test(vysledek, ocekavana, "Dělení");

// ==
vysledekb = cislo1 == cislo2;
ocekavanab = false;         //
TestComplex.Testb(vysledekb, ocekavanab, "Rovná se");

// !=
vysledekb = cislo1 != cislo2;
ocekavanab = true;          //
TestComplex.Testb(vysledekb, ocekavanab, "Nerovná se");

// unarni -
vysledek = -cislo1;
ocekavana = new Complex(-2, -3); //
TestComplex.Test(vysledek, ocekavana, "Unární mínus");

// komplexni sdruzena
vysledek = cislo1.Complex_conjugate();
ocekavana = new Complex(2, -3); //
TestComplex.Test(vysledek, ocekavana, "Komplexní sdružená");

// modul
vysledekD = cislo1.Modul();
ocekavanaD = Math.Sqrt(13);     //
TestComplex.TestD(vysledekD, ocekavanaD, "Modul");

// argument
vysledekD = cislo1.Argument();
ocekavanaD = 0.9827937;         //
TestComplex.TestD(vysledekD, ocekavanaD, "Argument");


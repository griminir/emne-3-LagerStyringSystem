// See https://aka.ms/new-console-template for more information

using emne_3_LagerStyringSystem;

Console.WriteLine("Lager styrings system");

var Warehouse13 = new Lager();
var Klær = new Klær();
var Elektronikk = new Elektronikk();
var Matvare = new Matvare();

Warehouse13.AddProduct(Klær, "kjelldress i grønn", 350, "large");
Warehouse13.AddProduct(Klær, "svarte sokker", 35, "small");
Warehouse13.AddProduct(Elektronikk, "elsykkel", 14000, "36 måneder");
Warehouse13.AddProduct(Elektronikk, "elektrisk tannbørste", 450.99, "24 måneder");
Warehouse13.AddProduct(Matvare, "brød", 10.99, "16-05-2024");
Warehouse13.AddProduct(Matvare, "ost", 95.95, "23-06-2024");

Warehouse13.ShowWares();
Console.WriteLine();

Warehouse13.RemoveItem("elsykkel");
Warehouse13.ShowWares();
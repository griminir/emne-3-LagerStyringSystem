// See https://aka.ms/new-console-template for more information

using emne_3_LagerStyringSystem;

Console.WriteLine("Lager styrings system");

var Warehouse13 = new Lager();

Warehouse13.AddProduct("klær", "kjelldress i grønn", 350, "large");
Warehouse13.AddProduct("klær", "svarte sokker", 35, "small");
Warehouse13.AddProduct("elektronikk", "elsykkel", 14000, "36 måneder");
Warehouse13.AddProduct("elektronikk", "elektrisk tannbørste", 450.99, "24 måneder");
Warehouse13.AddProduct("matvare", "brød", 10.99, "16-05-2024");
Warehouse13.AddProduct("matvare", "ost", 95.95, "23-06-2024");

Warehouse13.ShowWares();
Console.WriteLine();

Warehouse13.RemoveItem("elsykkel");
Warehouse13.ShowWares();
using System;
using System.Collections.Generic;

namespace ORFU21_Ovning_Shapes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            s1.side = 5;
            Console.WriteLine($"Square area is: {s1.GetArea()}"); //SWhould show 25

            Triangle t1 = new Triangle();
            t1.height = 8;
            t1.width = 12;
            Console.WriteLine($"Triangle area is: {t1.GetArea()}"); //Should show 48

            Circle c1 = new Circle();
            c1.radius = 13;
            Console.WriteLine($"Circle area is: {c1.GetArea()}"); //Should show ca. 530

            List<IShape> myList = new List<IShape> { t1, c1, s1 };

            Console.WriteLine("List Loop:");
            foreach (var item in myList)
            {
                Console.WriteLine($"Area of {item.Name()} is {item.GetArea()}");
            }
        }
    }
}

//Övning shapes
//•	Skapa ett interface som heter IShape som innehåller en metod som heter GetArea.
//•	Skapa en klass som heter Square som implementerar interface: et IShape.
//•	Skapa en property på klassen Square som är av typen int och som heter Side.
//•	I klassen Square skriver du en implementation för GetArea-metoden så att den returnerar Side* Side (arean av en fyrkant).
//•	Skapa en klass som heter Triangle som implementerar IShape.
//•	Skapa två properties av typen int (Height, Width) i Triangle-klassen.
//•	Implementera GetArea-metoden i Triangle så att den nu i stället returnerar Height* Width / 2.0.
//•	Skapa en ny klass som heter Circle som också implementerar IShape.Skapa även samtliga nödvändiga properties för att returnera arean av en cirkel (ni kan använda Math.PI för att komma åt värdet på π). Implementera GetArea.
//•	I Program.cs, skapa en lista av typen IShape.Lägg till en blandning av Square-, Triangle- och Circle-instanser i listan.Skriv en loop som loopar över listan och skriver ut alla elements area.

/*

using System;
using System.Drawing;
using Console = Colorful.Console;

namespace InheritanceCars
{
    public interface SportsCar
    {
        void WhatAreYou();
    }

    public interface GermanCar
    {
        void WhatAreYou();
    }

    // Basisklasse Car mit virtual Methode
    public abstract class Car
    {
        public virtual void WhatAreYou() { Console.WriteLine("I am a Car", Color.Azure); }
    }

    // Golf erbt von GermanCar, virtual Methode möglich zu überschreiben
    public abstract class Golf : GermanCar
    {
        public virtual void WhatAreYou() { Console.WriteLine("I am a Golf", Color.Azure); }
    }

    // GolfGTI überschreibt die Methode von Golf
    public class GolfGTI : Golf, SportsCar
    {
        public override void WhatAreYou() { Console.WriteLine("I am a Golf GTI", Color.Azure); }
    }

    // Manta versteckt die Methode von Opel mit new
    public class Manta : Opel, SportsCar
    {
        public new void WhatAreYou() { Console.WriteLine("eeh du, echt cool", Color.Azure); }
    }

    // Opel überschreibt virtual Methode von Car
    public class Opel : Car, GermanCar
    {
        public override void WhatAreYou() { Console.WriteLine("I am a Opel", Color.Azure); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Erklärungen direkt einfacher gemacht
            string erklaerung1 = "Casting auf Opel-Referenz: car1 ist Manta, aber Methode in Opel override -> Ausgabe: 'I am a Opel'";
            string erklaerung2 = "Casting auf GolfGTI-Referenz: car2 ist GolfGTI, override greift -> Ausgabe: 'I am a Golf GTI'";
            string erklaerung3 = "Casting auf Manta-Referenz: new Methode in Manta versteckt Opel override -> Ausgabe: 'eeh du, echt cool'";
            string erklaerung4 = "Casting auf Interface SportsCar: Manta-Objekt, new Methode gilt, Ausgabe: 'eeh du, echt cool'";
            string erklaerung5 = "Direkter Aufruf auf GolfGTI-Objekt: override greift -> Ausgabe: 'I am a Golf GTI'";
            string erklaerung6 = "Direkter Aufruf auf car1 (Manta-Objekt, Referenztyp Car): override in Opel wird ausgeführt, new in Manta wird ignoriert -> Ausgabe: 'I am a Opel'";

            Car car1 = new Manta();
            Golf car2 = new GolfGTI();

            ((Opel)car1).WhatAreYou();         // Ausgabe: "I am a Opel"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung1);

            ((GolfGTI)car2).WhatAreYou();      // Ausgabe: "I am a Golf GTI"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung2);

            ((Manta)car1).WhatAreYou();        // Ausgabe: "eeh du, echt cool"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung3);

            ((SportsCar)car1).WhatAreYou();    // Ausgabe: "eeh du, echt cool"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung4);

            car2.WhatAreYou();                 // Ausgabe: "I am a Golf GTI"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung5);

            car1.WhatAreYou();                 // Ausgabe: "I am a Opel"
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(erklaerung6);
        }
    }
}
*/
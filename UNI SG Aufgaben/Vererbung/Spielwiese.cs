
class Tier { 
    //public virtual void MachGeräusch() => Console.WriteLine("Ein Tier macht ein Geräusch");
}
 class Hund : Tier, Saeugetier { 
   // public override void MachGeräusch() => Console.WriteLine("Wuff!"); 
}
interface Saeugetier  { public void MachGeräusch() => Console.WriteLine("Miau!"); } //Override nicht möglich
class Program
{
    static void Main()
    {
        Tier t1 = new Hund(); // nicht instanziierbar wegen abstract
        Tier t2 = new Tier();
        //Saeugetier wal = new Saeugetier(); // nicht instanziierbar, weil interface
        ((Saeugetier)t1).MachGeräusch();

        //t1.MachGeräusch();  // Ausgabe: Wuff!
        //t2.MachGeräusch();  // Ausgabe: Miau!
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Itens
{
    public string name;
    public Itens next = null;

    public Itens(string name)
    {
        this.name = name;
    }
}


namespace ConsoleApplication1
{  
    class Program
    {
        private static void Main(string[] args)
        {
            Itens Itens1 = new Itens("poçaohp");
            Itens Itens2 = new Itens("Poçaompo");
            Itens Itens3 = new Itens("espada");
            Itens Itens4 = new Itens("machado");
            Itens Itens5 = new Itens("casaco");
            Itens Itens6 = new Itens("manto");
            Itens Itens7 = new Itens("colar");
            Itens Itens8 = new Itens("joia");
            Itens Itens9 = new Itens("berrante");
            Itens Itens10 = new Itens("pokeball");

            Itens1.next = Itens2;
            Itens2.next = Itens3;
            Itens3.next = Itens4;
            Itens4.next = Itens5;
            Itens5.next = Itens6;
            Itens6.next = Itens7;
            Itens7.next = Itens8;
            Itens8.next = Itens9;
            Itens9.next = Itens10;

            String x = Console.ReadLine();
            Itens currentElement = Itens1;
            int pos = 1;
            while ((currentElement != null))
            { 
                if (x == currentElement.name)
                {
                    Console.WriteLine("peguei o Item de nome: " + currentElement.name + (" - Item na posiçao:") + pos);
                    return;
                }
                else{
                    Console.WriteLine("Item nao encontrado");
                }
                
                currentElement = currentElement.next;
                pos++;
            }







            Console.ReadKey();
}
        

        

        

    }
}

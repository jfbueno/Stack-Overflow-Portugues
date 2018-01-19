using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

public class Program
{
    internal static void MetodoFacil()
    {
        var grupo1 = listaEventos.GroupBy(c => c.Data.ToString("MM/yyyy"))
                                 .Select(g => new { Key = g.Key, Itens = g.ToList() });

        foreach(var i in grupo1)
        {
            WriteLine(i.Key);

            foreach(var item in i.Itens)
            {
                WriteLine($"\t{item.Nome}");
            }

            WriteLine("\n");
        }
    }

    internal static void MetodoComplicado()
    {
        var grupo2 = listaEventos.GroupBy(c => c.Data.Year)
                                 .Select(g => new 
                                 { 
                                     Ano = g.Key, 
                                     Meses = g.ToList()
                                              .GroupBy(c => c.Data.ToString("MMMM"))
                                              .Select(grp => new 
                                                             { 
                                                                 Mes = grp.Key, 
                                                                 Eventos = grp.ToList() 
                                                             })
                                 });

        foreach(var i in grupo2)
        {
            WriteLine($"Ano: {i.Ano}");

            foreach(var mes in i.Meses)
            {
                WriteLine($"\tMês: {mes.Mes}");

                foreach(var evento in mes.Eventos)
                {
                    WriteLine($"\t\t{evento.Nome}");
                }

                WriteLine("\n");
            }           
        }
    }

    public static void Main()
    {           
        MetodoFacil();      
        MetodoComplicado();
    }

    internal static List<Evento> listaEventos = new List<Evento>
    {
        new Evento { Nome = "Evento 1", Data = new DateTime(2015, 01, 01) },
        new Evento { Nome = "Evento 2", Data = new DateTime(2016, 01, 01) },
        new Evento { Nome = "Evento 3", Data = new DateTime(2016, 01, 22) },
        new Evento { Nome = "Evento 4", Data = new DateTime(2016, 02, 24) },
        new Evento { Nome = "Evento 5", Data = new DateTime(2016, 03, 30) },
        new Evento { Nome = "Evento 6", Data = new DateTime(2016, 04, 04) },
        new Evento { Nome = "Evento 7", Data = new DateTime(2017, 01, 01) },
        new Evento { Nome = "Evento 8", Data = new DateTime(2017, 09, 30) },
        new Evento { Nome = "Evento 9", Data = new DateTime(2018, 05, 12) },
    };
}

public class Evento
{
    public string Nome { get; set; }
    public DateTime Data { get; set; }  
}
var grupo= listaEventos.GroupBy(x => new { x.Data.Year, x.Data.Month }) 
                       .Select(g => new { Key = g.Key, Itens = g.ToList() });

foreach(var i in grupo1)
{
    WriteLine($"{i.Key.Year} - { i.Key.Month }");

    foreach(var item in i.Itens)
    {
        WriteLine($"\t{item.Nome}");
    }

    WriteLine("\n");
}
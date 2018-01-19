using System;

namespace listalib
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new Lista();
            l.Add(1);
            l.Add(2);
            l.Add(3);

            var l2 = new Lista();
            l2.Add(4);
            l2.Add(5);
            l2.Add(6);

            l.Imprime();

            l.Concat(l2);
            l.Imprime();
        }

        public static Lista Concatenar (Lista l1, Lista l2) 
        {
            var novaLista = new Lista();
            Add(novaLista, l1);
            Add(novaLista, l2);

            return novaLista;
        }

        private static void Add(Lista nova, Lista velha)
        {
            NoLista p = velha.InicioLista;

            while (p.proximo != null) {
                nova.Add(p.informacao);                
                p = p.proximo;
            }
        }
    }
}

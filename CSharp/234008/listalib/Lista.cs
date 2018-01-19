using System;

namespace listalib
{
    public class Lista
    {
        /// <summary>
        /// Referência do primeiro nó (elemento) da lista
        /// </summary>
        public NoLista InicioLista { get; set; }

        /// <summary>
        /// Construtora da classe lista
        /// </summary>
        public Lista()
        {
            InicioLista = null;
        }

        /// <summary>
        /// Remove um valor da lista
        /// </summary>
        /// <param name="valor">Valor a ser removido</param>
        /// <returns>true se encontrar e false se não encontrar</returns>
        public bool Remove(int valor)
        {
            bool valorRetorno = false;

            NoLista auxiliar = InicioLista;

            // Verificar se a lista está vazia
            if (auxiliar != null)
            {
                // Percorrer  lista (navegar) até achar o nó com o valor desejado
                while ((auxiliar != null) && (auxiliar.informacao != valor))
                {
                    // Passa para o próximo elemento da lista
                    auxiliar = auxiliar.proximo;
                }

                // So atualizar a lista se o valor foi encontrado
                if (auxiliar.informacao == valor)
                {
                    // Verificar se existe um proximo elemento na lista
                    if (auxiliar.proximo != null)
                    {
                        // Remover a referencia do nó anterior
                        (auxiliar.proximo).anterior = null;
                    }

                    // Verificar se é o primeiro da lista
                    if (InicioLista.informacao == valor)
                    {
                        InicioLista = InicioLista.proximo;
                    }
                    else
                    {
                        // Verificar se existe um proximo elemento na lista
                        if (auxiliar.proximo != null)
                        {
                            (auxiliar.proximo).anterior = auxiliar.anterior;
                        }

                        // Fazer o anterior do auxiliar apontar para o proximo do auxiliar
                        (auxiliar.anterior).proximo = auxiliar.proximo;
                    }
                }
            }

            return valorRetorno;
        }

        /// <summary>
        /// Adiona um novo valor na lista
        /// </summary>
        /// <param name="valor">Valor a ser adicionado</param>

        public void Add(int valor)
        {
            NoLista novoNo = new NoLista();
            novoNo.informacao = valor;

            // Verificar se é o primeiro da lista
            if (InicioLista == null)
            {
                InicioLista = novoNo;
            }
            else
            {
                NoLista auxiliar = InicioLista;

                while (auxiliar.proximo != null)
                {
                    auxiliar = auxiliar.proximo;
                }

                auxiliar.proximo = novoNo;
                novoNo.anterior = auxiliar;
            }
        }

        public void Imprime()
        {
            NoLista auxiliar = InicioLista;
            Console.WriteLine("Imprimindo a lista");

            // Percorrer a lista até o fim
            while (auxiliar != null)
            {
                // Imprimir o valor
                Console.WriteLine(auxiliar.informacao);

                // Navegar para o próximo nó
                 auxiliar = auxiliar.proximo;
            }
        }

        public void Concat(Lista toConcat)
        {
            var no = InicioLista;

            while(no.proximo != null){
                no = no.proximo;
            }

            no.proximo = toConcat.InicioLista;
            toConcat.InicioLista.anterior = no;
        }
    }
}
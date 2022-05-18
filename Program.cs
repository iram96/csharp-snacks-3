// See https://aka.ms/new-console-template for more information

////Se volete verificare la velocità di una parte del codice
//double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
//Console.WriteLine("microseconds: {0}", microseconds);



/* Assegnazione
 - Costruire una lista (li) di 1000 numeri casuali compresi tra 0 e 999 incluso
 - Costruire un SortedSet (ssi) contenente i numeri già presenti in lista
 - Costruire un vettore di booleani (vb), lungo 1000, che per ogni intero n presente in lista
   vale vb[n]=true

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nel vettore vb (quindi if vb[n] == true). Non dovete stampare nulla

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nella lista li (quindi li.find...). Non dovete stampare nulla

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nell'insieme ordinato ssi (quindi ssi.find...). Non dovete stampare nulla

Infine, stampare i tre tempi in secondi

Opzionale: stampare il numero di ricerche/secondo.

 * */

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            List<int> RunScript(List<int> A)
            {

                var rand = new Random();
                var rtnlist = new List<int>();


                for (int i = 0; i < 10; i++)
                {
                    if (!rtnlist.Contains(rand.Next()))
                    {

                        rtnlist.Add(rand.Next(0, 999));
                    }

                }

                return A = rtnlist;

            }




            var NewList = RunScript(list);

            Console.WriteLine("La tua lista è : {0}\t", string.Join("", NewList));

            SortedSet<int> ssi = new SortedSet<int>();

            foreach (int i in NewList)
            {
                ssi.Add(i);
                Console.WriteLine(i);
            }

            Console.WriteLine("La tua SortedSet è : {0}\t", string.Join(",", ssi));

            //La ricerca in un sistema ordinato è logaritmica 
            //Se l'insieme contine N elementi, il tempo di ricerca oppure
            //il numero di operazioni eseguite per la ricerca è log(N)

            //La ricerca di un insieme sequenziale (non irdinato) è lineare
            //Se l'insieme contiene N elementi, il tempo di ricerca oppure
            //il numero di operazioni eseguite per la ricerca è pari a O(N) 







            for (int i = 0; i < 10000; i++)
            {
                var rand = new Random();
                list.Add(rand.Next(0, 1000));

            }


            List<int> Li_base = new List<int>();

            double start = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            foreach (int n in Li_base)
            {

                Li_base.Add(n);

            }


            double end = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);

            double TotalTime = end - start;
            Console.WriteLine("Per calcolare i numeri ci hai messo {0} microsecondi", TotalTime);


            //-calcolare quanto tempo impiegate per eseguire il seguente codice
            //     - per 10000 volte
            //        - prende in sequenza i numeri presenti in lista base
            //          - verifica se n è presente nella lista li (quindi li.find...). Non dovete stampare nulla


            int trovati = 0;
            int nontrovati = 0;
            start = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            for (int i = 0; i < 10000; ++i)
            {
                foreach (int n in NewList)
                {
                    //n è presente nella lista li?
                    if (list.Contains(n))
                        trovati++;
                    else
                        nontrovati++;
                }
            }
            end = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            Console.WriteLine("Tempo di 10000 ricerche di 1000 elementi in una lista: {0}", end - start);
            Console.WriteLine("Trovati: {0}", trovati);






            //Ora voglio utilizzare un vettore--------------------------------------

            int[] vi = new int[1000];



            int posv = 0;
            foreach (int i in vi)
            {
                vi[posv++] = i;
            }

            trovati = 0;
            nontrovati = 0;
            start = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            for (int i = 0; i < 10000; ++i)
            {
                foreach (int n in NewList)
                {
                    //n è presente nel vettore li?
                    /*for (int pos = 0; pos < 1000; ++pos)
                        if (vi[pos] == n)
                        {
                            trovati++;
                            break;
                        }
                    */

                    if (vi.Contains(n))
                        trovati++;
                    else
                        nontrovati++;

                }
            }
            end = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            Console.WriteLine("Tempo di 10000 ricerche di 1000 elementi in un vettore: {0}", end - start);
            Console.WriteLine("Trovati: {0}", trovati);


            bool[] vb = new bool[1000];


            //foreach (int i in vi)
            //{
            //    vi[posv++] = i;
            //}

            trovati = 0;
            nontrovati = 0;
            start = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            for (int i = 0; i < 10000; ++i)
            {
                foreach (int n in NewList)
                {
                    //n è presente nel vettore li?


                    /*for (int pos = 0; pos < 1000; ++pos)
                        if (vi[pos] == n)
                        {
                            trovati++;
                            break;
                        }
                    */

                    if (vb[n])
                        trovati++;
                    else
                        nontrovati++;

                }
            }
            end = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
            Console.WriteLine("Tempo di 10000 ricerche di 1000 elementi in un vettore booleano: {0}", end - start);
            Console.WriteLine("Trovati: {0}", trovati);

            //Vantaggi vettore: velocità di ricerca
            //Svantaggi vettore: devo fare un vettore grande quanto voglio
            //  La lista ha tanti elementi quanti ne estraggo


        }
    }
}







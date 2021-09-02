using System;

namespace Indexer
{
    class Program
    {
        
           class IndexedNames
        {
            private string[] namelist = new string[size];
            static public int size = 10;

            public IndexedNames()
            {
                for (int i = 0; i < size; i++)
                    namelist[i] = "Not Available";
            }
            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= size - 1)
                    {
                        tmp = namelist[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= size - 1)
                    {
                        namelist[index] = value;
                    }
                }
            }
            static void Main(string[] args)
            {
                IndexedNames names = new IndexedNames();
                names[0] = "Amar";
                names[1] = "Krish";
                names[2] = "Karan";
                names[3] = "Amit";
                names[4] = "Rohan";
                names[5] = "Ram";
                names[6] = "Sameer";

                for (int i = 0; i < IndexedNames.size; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.ReadKey();
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_estructura_nodos
{

    class Pila
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public int Extraer()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la pila.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        public bool Vacia()
        {
            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }

        //Para retornar el primer elemento de la pila
        public int retornar()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            pila1.Insertar(10);
            pila1.Insertar(40);
            pila1.Insertar(3);
            pila1.Imprimir();
            Console.WriteLine("La cantidad de nodos de la lista es:" + pila1.Cantidad());
            Console.WriteLine();
            Console.WriteLine("Retornar el primer elemento de la pila:" + pila1.retornar());
            while (pila1.Vacia() == false)
            {
                Console.WriteLine(pila1.Extraer());
            }
            Console.ReadKey();
        }
    }
}

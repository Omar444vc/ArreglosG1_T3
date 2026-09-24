using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;


        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _tope = 0;
            _arreglo = new int[N];
        }

        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Métodos
        //Método para llenar 
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);

            }
            _tope = N;
        }


        //metodo ordenar(Burbuja)
        public void Ordenar()
        {
            Ordenar(true);
        }

        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {



                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

            //Metodo Cambiar
            public void Cambiar(ref int a,ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }




        


        

        //Metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "El arreglo está vacío";
            }


            string cadena = string.Empty;
            int contador = 0;
            for (int i = 0; i < _tope; i++)
            {
                //cadena = cadena + _arreglo[i];
                cadena += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    cadena += "\n";
                    contador = 0;
                }

            }

            return cadena;
        }
    }
}

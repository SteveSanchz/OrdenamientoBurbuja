using System;

namespace OrdenamientoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.insertar_Numeros();
            burbuja.imprimir_resultado();
        }
    }
}

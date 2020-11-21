using System;
class Burbuja{
    private string [] cadenaDeNumeros;
    private int [] numeros;

    public string[] get_cadenaDeNumeros(){
        return this.cadenaDeNumeros;
    }
    public int[] get_Numeros(){
        return this.numeros;
    }
    public void insertar_Numeros(){
        Console.WriteLine("Escribe numeros al azar separandolos por un espacio entre cada numero y presionar la tecla enter para comenzar con el proceso de ordenamiento ");
        this.cadenaDeNumeros = Console.ReadLine().Split();
    }
    private void convertir_String_A_Int(string[] cadenaDeNumeros){
        this.numeros = new int[cadenaDeNumeros.Length];
        for(int x = 0; x < this.numeros.Length; x++){
            this.numeros[x] = Convert.ToInt32(cadenaDeNumeros[x]);
        }
    }
    private void ordenar_Numeros(){
        int temporal;
        for (int a = 1; a < this.numeros.Length; a++){
            for (int b = (this.numeros.Length - 1); b >= a; b--){
                if (this.numeros[(b - 1)] > this.numeros[b]){
                    temporal = this.numeros[(b - 1)];
                    this.numeros[(b - 1)] = this.numeros[b];
                    this.numeros[b] = temporal;
                }
            }
        }
    }
    public void imprimir_resultado(){
        convertir_String_A_Int(this.cadenaDeNumeros);
        ordenar_Numeros();
        string resultado="";
        int contador = 0;
        while(contador < numeros.Length){
            resultado += Convert.ToString(numeros[contador] + " ");
            contador++;
        }
        Console.WriteLine("\nLos numeros quedaron ordenados de la siguiente manera:");
        Console.WriteLine(resultado);
    }
}
/* Mover ceros al final
Dada la lista de enteros nums, mueve todos los ceros al final de la misma, manteniendo el orden relativo de los elementos no nulos.

Reto: reordena los valores “in place”, sin hacer una copia de la lista.

Ejemplo 1:

# Entrada:
	nums = [0, 1, 0, 3, 12]
# Salida:
    [1, 3, 12, 0, 0]
Ejemplo 2:

# Entrada:
	nums = [0]
# Salida:
    [0]*/
/*
int[] nums = {0, 1, 0, 3, 12};


Moviendo_los_Ceros_Al_final(nums);

for (int i= 0; i<nums.Length;i++) {

    Console.WriteLine(nums[i]);
}



static void Moviendo_los_Ceros_Al_final(int[] numeros) {

    if (numeros == null || numeros.Length <= 1) {

        return;
    }
    int indices_Ceros = 0;

    for (int i = 0; i < numeros.Length; i++) {

        if (numeros[i] != 0) {

            int tem = numeros[i];
            numeros[i] = numeros[indices_Ceros];
            numeros[indices_Ceros] = tem;

            indices_Ceros++;
        
        
        
        }



    }

}

*/
/*2.Invertir string
Escribe una función que invierta una cadena. La cadena de entrada se da como un arreglo de caracteres.

Reto: hacerlo modificando la lista de entrada con O(1) de memoria extra.

Ejemplo 1:

# Entrada:
	s = ["h", "e", "l", "l", "o"]
# Salida:
    ["o", "l", "l", "e", "h"]
Ejemplo 2:

# Entrada:
	s = ["H", "a", "n", "n", "a", "h"]
# Salida=["h", "a", "n", "n", "a", "H"]*/


//resolucion
/*
string[] s = { "h", "e", "l", "l", "o" };


inviertiendo_una_cadena(s);


for (int i = 0; i < s.Length; i++) {

    Console.WriteLine(s[i]);
}

static void inviertiendo_una_cadena(string[] cadena) {
   int  puntero_derecho = cadena.Length - 1;
    int puntero_izquierdo = 0;


    while (puntero_izquierdo<puntero_derecho) {

        string temp = cadena[puntero_izquierdo];
        cadena[puntero_izquierdo]= cadena[puntero_derecho];
        cadena[puntero_derecho]= temp;
        puntero_izquierdo++;
        puntero_derecho--;
    
    
    
    
    
    
    
    
    
    }







}

*/
/*using System.Diagnostics;

3.Reordenar colores
Dado un arreglo nums con n objetos de color rojo, blanco o azul, ordénalos en su lugar para que los objetos del mismo color sean adyacentes, con los colores en el orden rojo, blanco y azul.

Utilizaremos los enteros 0, 1 y 2 para representar el color rojo, blanco y azul, respectivamente.

Reto 1: debes resolver este problema sin utilizar la función de ordenación de la biblioteca.

Reto 2: ¿podrías idear un algoritmo de una sola pasada utilizando solo un espacio extra constante?

Ejemplo 1:

# Entrada:
	nums = [2, 0, 2, 1, 1, 0]
# Salida:
     [0, 0, 1, 1, 2, 2]
Ejemplo 2:

# Entrada:
	nums = [2, 0, 1]
# Salida:
    [0, 1, 2]*/



using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
/*int[] nums = { 2, 0, 2, 1, 1, 0 };

Ordenar_Colores(nums);
for (int i = 0; i < nums.Length; i++) {
    Console.WriteLine(nums[i]);
}


static void Ordenar_Colores(int[] num) {

    int puntero_izquierdo = 0;
    int puntero_derecho = num.Length - 1;
    int posicion_array = 0;

    while (posicion_array<puntero_derecho) {


        if (num[posicion_array] == 2)
        {

            int temp = num[posicion_array];
            num[posicion_array] = num[puntero_derecho];
            num[puntero_derecho] = temp;

            puntero_derecho--;


        }
        else if (num[posicion_array] == 0)
        {

            int temp = num[posicion_array];
            num[posicion_array] = num[puntero_izquierdo];
            num[puntero_izquierdo] = temp;
            puntero_izquierdo++;
            posicion_array++;




        }
        else {
            posicion_array++;
        
        
        
        }
        
        
    
    
    
    
    
    }




}*/
/*.Invertir vocales
Dada una cadena de caracteres, invierte solo todas las vocales de la cadena.
Las vocales son ‘a’, ‘e’, ‘i’, ‘o’ y ‘u’, ‘A’, ‘E’, ‘I’, ‘O’, ‘U’.

Ejemplo 1:

# Entrada:
	s = "hola"
# Salida:
	"halo"
Ejemplo 2:

# Entrada:
	s = s = "leetcode"
# Salida:
	"leotcede"*/


string s = "hola";
List<string> vocales = new List<string>{ "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

string palabra = intercambiar_vocales(s,vocales);
string modificacion ="";
Console.WriteLine(palabra);
static string intercambiar_vocales(string palabra, List<string>vocales) {
    char[] caracteres_de_palabra= palabra.ToCharArray();

    List<int> indices_vocales = encontrar_indices_vocales(caracteres_de_palabra, vocales);
   

    int indice_izquierda_vocal = 0;
    int indice_derecha_vocal = indices_vocales.Count-1;

    while (indice_izquierda_vocal<indice_derecha_vocal) {

        char temp =caracteres_de_palabra[indices_vocales[indice_izquierda_vocal]];
        caracteres_de_palabra[indices_vocales[indice_izquierda_vocal]] =caracteres_de_palabra[ indices_vocales[indice_derecha_vocal]];
        caracteres_de_palabra[indices_vocales[indice_derecha_vocal]]=temp;
        indice_derecha_vocal--;
        indice_izquierda_vocal++;
    
    
    
    
    }

    string palabra_modificada = new string(caracteres_de_palabra);


    return palabra_modificada;
    

    

}



static List<int> encontrar_indices_vocales(char[] caracteres_de_palabra, List<string>vocales) {
    List < int> indices_vocales= new List<int>();

    for (int i = 0; i < caracteres_de_palabra.Length; i++)
    {
        if (vocales.Contains(caracteres_de_palabra[i].ToString()))
        {
            indices_vocales.Add(i);

        }


    }


    return indices_vocales;





}
/*
static char verificar_vocales(int puntero_izquierda, int puntero_derecha, char[] caracteres,string[] vocales)
{

    if (vocales.Contains(caracteres[puntero_izquierda].ToString()) && vocales.Contains(caracteres[puntero_derecha].ToString())){
        char temp = caracteres[puntero_izquierda];
        caracteres[puntero_izquierda] = caracteres[puntero_derecha];
        caracteres[puntero_derecha] = temp;
        puntero_derecha--;
        puntero_izquierda++;
        string modified = new string(caracteres);

    


    }


}*/
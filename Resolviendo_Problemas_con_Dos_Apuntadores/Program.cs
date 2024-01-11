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


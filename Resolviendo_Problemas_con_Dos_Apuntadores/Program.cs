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





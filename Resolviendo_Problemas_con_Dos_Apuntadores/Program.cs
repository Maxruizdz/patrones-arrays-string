
/*5.Cuadrados de un arreglo ordenado
Dado un arreglo de números enteros ordenados en orden ascendente, devuelve una matriz de los cuadrados de cada número ordenados en orden no decreciente.*/

int[] nums = { -4, -1, 0, 3, 10 };


Cuadrados_de_Arreglos_Ordenados(nums);

for (int i = 0; i < nums.Length; i++) {


    Console.WriteLine(nums[i]);
}




static void Cuadrados_de_Arreglos_Ordenados(int[] nums) {

    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = nums[i] * nums[i];



    }

    Array.Sort(nums);



}
// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

int[] nums = { 4, 5, 6, 7, 0, 1, 2,3};
int objetivo = 3;
int numero =buscar_numero_Array_Rotado(nums, objetivo);

Console.WriteLine(numero);





static int buscar_numero_Array_Rotado(int[] nums, int numero_buscar) {
    int cont = 0;
        int puntero_izquierdo = 0;
        int puntero_derecho= nums.Length - 1;

    while (puntero_izquierdo <= puntero_derecho)
    {
        cont++;
        int puntero_intermedio =  puntero_izquierdo + (puntero_derecho -puntero_izquierdo) / 2;
        if (nums[puntero_intermedio] == numero_buscar)
        {
            return puntero_intermedio;
        }
        if (nums[puntero_intermedio] > nums[puntero_izquierdo])
        {
            if (nums[puntero_izquierdo] <= numero_buscar && nums[puntero_intermedio] >= numero_buscar)
            {

                puntero_derecho = puntero_intermedio - 1;

            }
            else
            {
                puntero_izquierdo = puntero_intermedio + 1;
            }
        }
        else {

            if (nums[puntero_izquierdo] <numero_buscar)
            {

                puntero_izquierdo++;

            }
            else { 
            
            puntero_izquierdo--;
            }
        
        
        }

        Console.WriteLine(cont);

    }



    return -1;
    }
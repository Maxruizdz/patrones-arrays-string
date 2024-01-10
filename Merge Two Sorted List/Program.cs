List<int> nums1 = new List<int> (){ 1, 2, 3, 0 ,0};
int m = 3;
List<int> nums2 = new List<int> (){ -4,2 };
int n = 2;
List<int> resultado = obtener_nueva_Lista(nums1, nums2,m,n);
Console.WriteLine("Nueva Lista:");

foreach (var elemento in resultado)
{
    Console.WriteLine(elemento);
}
static List<int> obtener_nueva_Lista(List<int>lista1, List<int>lista2, int m, int n) {

    int puntero_array1 = m-1;
    int puntero_final_array1 = m+n-1;
    int puntero_array2 = n-1;


    while (puntero_array2>=0) {

        if (puntero_array1 >=0 && lista1[puntero_array1] >lista2[puntero_array2])
        {


            lista1[puntero_final_array1] = lista1[puntero_array1];
            puntero_array1--;



        }
        else {

            lista1[puntero_final_array1]= lista2[puntero_array2];
            puntero_array2--;

        
        }
        puntero_final_array1--;

    
    
    
    
    
    
    }


    return lista1.ToList();







}


/*foreach (var elemento in resultado)
{
    Console.WriteLine(elemento);
}

static List<int> obtener_nueva_List(List<int> nums1, List<int> nums2, int m, int n) {
    int cont = n-1;


    limpiar_lista_Y_Agruparlas(nums1,nums2,m,n);

    ordenar_lista_Ascendentemente(nums1);


    return nums1.ToList();









}

static void ordenar_lista_Ascendentemente(List<int> nums1)
{
    nums1.Sort();
}

static void limpiar_lista_Y_Agruparlas(List<int> nums1, List<int> nums2, int m, int n)
{
    int cont = n - 1;

    for (int i = nums1.Count - 1; cont >= 0; i--)
    {

        nums1[i] = nums2[cont];
        cont--;
    }



    
}*/

/*Console.WriteLine("Nueva Lista:");
foreach (var elemento in resultado)
{
    Console.WriteLine(elemento);
}






static List<int> obtener_nueva_List(List<int> lista1, List<int> lista2)
{
    int m = lista1.Count - lista2.Count;
    List<int> lista_limpia = new List<int>();

    lista_limpia = limpiar_lista(lista1, m);
    


    return generar_Lista_nueva(lista_limpia, lista2);
}

    static List<int> limpiar_lista(List<int> lista1, int m)
    {
        var list_limpia = new List<int>();
        for (int i = 0; i < m; i++)
        {
            list_limpia.Add(lista1[i]);
        }

        return list_limpia.ToList();
    }

    static List<int> generar_Lista_nueva(List<int> lista1, List<int> lista2)
    {
        List<int> nuevaLista = new List<int>(lista1);
        nuevaLista.AddRange(lista2);
        nuevaLista.Sort();

        return nuevaLista;
    }

*/
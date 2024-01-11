// See https://aka.ms/new-console-template for more information
int[] alturas_lineas = { 0,1,0,2,1,0,1,3,2,1,2,1};

int cantidad_agua_atrapada = Traer_agua_Atrapada(alturas_lineas);
Console.WriteLine(cantidad_agua_atrapada.ToString());
static int Traer_agua_Atrapada(int[] Tamaño_Columnas)
{
    if (Tamaño_Columnas == null || Tamaño_Columnas.Length == 0)
        return 0;

    int puntero_izquierdo = 0;
    int puntero_derecho =Tamaño_Columnas.Length - 1;
    int izquierdo_tam_max = 0;
    int derecho_tam_max = 0;
    int Total_agua_Atrapada = 0;
    while (puntero_izquierdo < puntero_derecho)
    {

        if (Tamaño_Columnas[puntero_izquierdo] < Tamaño_Columnas[puntero_derecho])
        {
            izquierdo_tam_max = Math.Max(izquierdo_tam_max, Tamaño_Columnas[puntero_izquierdo]);
            Total_agua_Atrapada += izquierdo_tam_max - Tamaño_Columnas[puntero_izquierdo];
            puntero_izquierdo++;

        }
        else
        {
            derecho_tam_max = Math.Max(derecho_tam_max, Tamaño_Columnas[puntero_derecho]);
            Total_agua_Atrapada += derecho_tam_max - Tamaño_Columnas[puntero_derecho];
            puntero_derecho--;

        }

       
    }

    return Total_agua_Atrapada;
}
    




static void Columna_Derecha_Mayor_A_ColumnaIzquierda(int[] Tamaño_Columnas, int puntero_izquierdo, int puntero_derecho,  int izquierdo_tam_max, int Total_agua_Atrapada)
{
    izquierdo_tam_max = Math.Max(puntero_izquierdo, Tamaño_Columnas[puntero_izquierdo]);
    Total_agua_Atrapada += izquierdo_tam_max - Tamaño_Columnas[puntero_izquierdo];
    puntero_izquierdo++;

}

static void Columna_izquierda_Mayor_A_ColumnaDerecha(int derecho_tam_max, int[] Tamaño_Columnas, int puntero_derecho,int Total_agua_Atrapada)
{





    derecho_tam_max = Math.Max(derecho_tam_max, Tamaño_Columnas[puntero_derecho]);
    Total_agua_Atrapada += derecho_tam_max - Tamaño_Columnas[puntero_derecho];
    puntero_derecho--;


} 
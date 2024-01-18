// See https://aka.ms/net
using System.ComponentModel.Design;

int[,] matriz = {
     { 1, 3, 5, 7},
    { 10, 11, 16,20},
    { 23, 30, 34 ,60}
};

int objetivo = 3;


bool encontre= buscar_numero_Array(matriz, objetivo);
Console.WriteLine(encontre);

static bool buscar_numero_Array(int[,] matriz, int objetivo) {

    int puntero_izquierdo = 0;
    int columna_matriz= 0;
    int puntero_derecho = matriz.GetLength(1) - 1;
    while (puntero_izquierdo<=puntero_derecho ) {


        
       int valor_ultimo_elemento_de_fila = matriz[columna_matriz, puntero_derecho];
        
     
        if (valor_ultimo_elemento_de_fila < objetivo)
        {
            if (columna_matriz == matriz.GetLength(0) - 1)
            {
                puntero_izquierdo = puntero_derecho + 1;

            }
            else { columna_matriz++; }


        }
        else {



            int punto_intermedio = puntero_izquierdo + (puntero_derecho - puntero_izquierdo) / 2;
            if (matriz[columna_matriz, punto_intermedio] == objetivo)
            {

                return true;


            }

            if (matriz[columna_matriz, puntero_derecho] > objetivo && objetivo <= matriz[columna_matriz, punto_intermedio])
            {

                puntero_derecho = punto_intermedio - 1;

            }
            else
            {

                puntero_izquierdo = punto_intermedio + 1;
            }

        }
           


        
        

        }




    return false;



}







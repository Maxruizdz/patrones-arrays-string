// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");
int[] alturas = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int total_area = containerWithMostWater(alturas);
Console.WriteLine(total_area);
static int containerWithMostWater(int[] alturas) {
   
    int puntero_final =alturas.Length - 1;
    int puntero_inicial = 0;
    int area_conveniente = 0;
    while (puntero_inicial != puntero_final) {

       int area = (Math.Min(alturas[puntero_inicial], alturas[puntero_final]))*(puntero_final - puntero_inicial);
       
        if (area_conveniente < area) { 
        
        
        area_conveniente=area;
        }

        if (alturas[puntero_inicial] < alturas[puntero_final])
        {
            puntero_inicial++;



        }
        else {

            puntero_final--;
        
        }





    
    
    
    }
    return area_conveniente;

}

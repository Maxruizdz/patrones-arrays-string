string s = "pwwkew";


int tamaño_sub_String= LongitudSubcadenaSinRepetir(s);

Console.WriteLine(tamaño_sub_String);



static int LongitudSubcadenaSinRepetir(string s) {
    int puntero_izquierda = 0;
    int puntero_derecha = 0;
    string sub_string = "";
    int Tamaño_Mayor_substring = 0;
    s= s.ToLower();

    while (puntero_derecha < s.Length) {

        if (!sub_string.Contains(s[puntero_derecha]))
        {
            sub_string += s[puntero_derecha].ToString();
            puntero_derecha++;
            Tamaño_Mayor_substring = Math.Max(Tamaño_Mayor_substring, sub_string.Length);


        }
        else {
            
            puntero_izquierda++;
            puntero_derecha = puntero_izquierda;
            sub_string = "";
        }
       
       
    
    
    
    }

   

    return Tamaño_Mayor_substring;


}
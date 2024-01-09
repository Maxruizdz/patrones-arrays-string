using System.Collections.Generic;
using System.Data.SqlTypes;

var palabras1 = new List<string>{
    "auto", "aura"
};

var palabras2 = new List<string>{
    "habito", "hacer","lectura","sonrisa"
};

Console.WriteLine(estan_Ordenadas(palabras1, "abcdefghijklmnopqrstuvwxyz"));
Console.WriteLine(estan_Ordenadas(palabras2, "hlabcdefgijkmnopqrstuvwxyz"));



 bool estan_Ordenadas(List<string> palabra, string abecedario) {

    var abeced= crear_abecedario(abecedario);

    var dic = Descomponer_pala(palabra, abeced);


    for (int i = 0; i<dic.Length - 1; i++) {

        if (!compara_palabras(dic[i], dic[i + 1])) { 
        
        
        return false;
            break;
        
        }
    
    
    }


    return true;
}
static bool compara_palabras(Dictionary<int,(int,char)> palabra1, Dictionary<int,(int,char)>palabra2) {

    int tamaño= palabra1.Count + palabra2.Count;

    for (int i = 0; i < tamaño; i++) { 
    
    var pal1= palabra1.ElementAtOrDefault(i);
     var pal2= palabra2.ElementAtOrDefault(i);

        if (pal1.Value.Item1 > pal2.Value.Item1)
        {


            break;

        }
        if (pal1.Value.Item1<pal2.Value.Item1) {
        
        
        return true;
            break;
        }
    
    
    
    }


    return false;
}

Dictionary<char, int> crear_abecedario(string abecedario) {
    Dictionary<char, int> crear_=new Dictionary<char, int>();
    for (int i = 0; i < abecedario.Length; i++) {

        crear_.Add(abecedario[i], i+1);
    
    
    }


    return crear_;
}
static Dictionary<int, (int, char)>[] Descomponer_pala(List<string> palabras, Dictionary<char, int> ordenamiento)
{
    var palabras_dic= new Dictionary<int, (int, char)>[palabras.Count];

    for (int i = 0; i < palabras.Count; i++) {

        palabras_dic[i] = Obtener_dic_palabras(palabras[i],ordenamiento);
    
    
    
    }

    return palabras_dic;

    
}

static Dictionary<int, (int, char)> Obtener_dic_palabras(string palabra, Dictionary<char, int> ordenamiento)
{
    var dic = new Dictionary<int, (int, char)>();
    for (int i = 0; i < palabra.Length; i++)
    {
        if (ordenamiento.TryGetValue(palabra[i], out int value))
        {
            dic.Add(i, (value, palabra[i]));
        }
    }
    return dic;
}
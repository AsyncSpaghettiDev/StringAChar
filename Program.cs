using System;

class Program{
    /*Creacion de un método estático para hacerlo más fácil su implementacion,
    se especifica que el parametro a usar será String*/
    static char[] stringChar(string a){
        /*Se usa .ToCharArray para transformar la cadena a una lista de char*/
        return a.ToCharArray();
    }
    /*Creacion de un método estático para hacerlo más fácil su implementacion,
    se especifica que el parametro será una lista de char*/
    static String charString(char[] a){
        /*Se construye una cadena usando los char que usamos como parametro*/
        return new String(a); 
    }
    /*Creacion de un método estático para hacerlo más fácil su implementacion,
    se busca transformar una cadena en *** similar al formato de una contraseña*/
    static String ocultar(string a){
        /*Se crea una lista de tipo char y se rellena con la cadena que se pasó 
        como parámetro*/
        char[] ocultar=a.ToCharArray();
        /*Se usa un ciclo for para cambiar cada elemento de la lista por un asterisco*/
        for(int i=0;i<ocultar.Length;i++){
            ocultar[i]='*';
        }
        /*Se regresa una cadena con los char's que tiene la lista ocultar*/
        return new String(ocultar);
    }
    /*Creacion de un método estático para hacerlo más fácil su implementacion,
    se busca contar la cantidad de letras que tiene una palabra*/
    static void contar(string a){
        /*Se crea una lista de caracteres que tiene todas las letras del abecedario, además de una lista de numeros donde
        se almacenará la cantidad de veces que se repite una letra*/
        Char[] letras = new Char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        Int32[] cantidad=new Int32[letras.Length];
        /*Se transforma la cadena a una cadena de caracteres en mayusculas y se usa para rellenar la lista tipo Char*/
        Char[] texto=a.ToUpper().ToCharArray();
        /*Se ejecuta un for en el que si una letra de la lista texto es igual a una en la lista letras se aumentará la posición
        de la lista cantidad, se usa el doble for para que el primero recorra la lista texto y el segundo recorra lista de letras*/
        for(int i=0;i<texto.Length;i++){
            for(int k=0;k<letras.Length;k++){
                if(texto[i]==letras[k]) cantidad[k]++;
            }
        }
        /*Se imprime la palabra y la cantidad de letras que tiene, despues se imprimen la letra con su cantidad, siempre
        y cuando la letra por lo menos aparezca una vez. Se crea un if else para diferenciar de cuando sale 1 vez a
        cuando sale muchas veces la letra*/
        Console.WriteLine("Tu palabra {0} tiene {1} letras y son:",a,texto.Length);
        for(int i=0;i<letras.Length;i++){
            if(cantidad[i]!=0){
                if(cantidad[i]==1)Console.WriteLine("La letra {0} {1} vez.",letras[i],cantidad[i]);
                else Console.WriteLine("La letra {0} {1} veces.",letras[i],cantidad[i]);
            }
        }
    }
    static void Main(){
        /*Se crea una lista de tipo char que se llenará con los datos que regresa
        el método stringChar*/
        char[] text1=stringChar("Casa");

        /*Uso de un foreach para imprimir la lista de char*/
        foreach(char text in text1){
            Console.WriteLine(text);
        }

        /*Creacion de una string que se definirá con la cadena que regresa el método charString*/
        String cadena=charString(new char[]{'C','e','r','r','a','r'});
        Console.WriteLine(cadena);

        /*Impresión de la contraseña cambiada por asteriscos*/
        Console.WriteLine(ocultar("Hogar"));

        /*Llamada al método para contar las letras que tiene una palabra*/
        contar("Jonathan");
    }
}
using System;

class Program {
  public static void Main (string[] args) {
    // string: Guarda varios caracteres alfanumericos
    // int: Guarda numeros enteros
    // double, float, decimal: Guarda numeros decimales
    // bool: Guarda valores de verdad (true/false)
    // char: Guarda un solo caracter alfanumero
    
    //Feedback Laboratorio #1.
    /*1. La variable codigoPostal bien podria declararse como string, debido a que estos datos mayormente son números enteros y en ocasiones inician con 0.*/
    string codigoPostal = "01070";
    Console.WriteLine(codigoPostal);

    /*La variable numeroTelefono y DNI, es sugerido mejor colocarlo string.*/
    string numeroTelefono = "612345678";
    Console.WriteLine(numeroTelefono);

    /*La variable genero, el ejercicio mencionaba que solo habian 2 valores para guardar H y M, entonces como solo es un caracter seria un char.*/
    char genero  = 'H';
    Console.WriteLine(genero);

    /*El tipo de dato Boolean es correcto, pero mejor usemos la palabra reservada bool, al igual usemos string por String y no olvidar el punto y coma al final de cada instrucción.
*/
    Boolean mayorEdad = true;
    Console.WriteLine(mayorEdad);
    bool esSoltero = true;
    Console.WriteLine(esSoltero);

    /*En la variable tallaCamiseta debería declararse como string, debido que uno de los valores es XL y este ya no podria guardarse en un char. 
 */
    string tallaCamiseta = "XL";
    Console.WriteLine(tallaCamiseta);

    /*La variable alumnoRepetidos en la descripción menciona que solo aceptaría 2 opciones Si o No, y esta bien como lo hizo pero también lo hubieses declarado como bool, y pues siendo los valores true o false respectivamente.
    */
    string alumnoRepetido = "Si";
    Console.WriteLine(alumnoRepetido);
    bool alumnoRepetidor = true;
    Console.WriteLine(alumnoRepetidor);


    /*Nombrar variables*/
    int numeroDeHijos = 0;
    Console.WriteLine(numeroDeHijos);
    int numero_de_nietos = 0;
    Console.WriteLine(numero_de_nietos);
    int Numero_De_Hijos = 0;
    Console.WriteLine(Numero_De_Hijos);

    //Estructuras de Control
    //If - Else
    int edad = 10;
    /* CONDICION SIMPLE   
    if(condicion) {
        INSTRUCCIONES SI LA CONDICION ES VERDADERA
     }
    */

 /* if(condicion) {
      INSTRUCCIONES SI LA CONDICION ES VERDADERA
    }else{
      INSTRUCCIONES SI LA CONDICION ES FALSA
    }
  */

    int notaExamen = 23;
    if(notaExamen >= 23)
    {
      notaExamen = 25;
    }
    Console.WriteLine($"La nota del examen es: {notaExamen}%");

    if (edad >= 18)  
    {
      //TODO se ejecutara si la condicion es verdadera.
      Console.WriteLine("El usuario es mayor de edad");
    }
    else
    {
      //TODO se ejecutara si la condicion es falsa.
      Console.WriteLine("El usuario es menor de edad");
    }

    //Evaluando un booleano
    bool mayorDeEdad = edad >= 18;
    if(mayorDeEdad){
      Console.WriteLine("El usuario es mayor de edad");   
    }
    else{
      Console.WriteLine("El usuario es menor de edad");     
    }

    string estudiante = "Juan";
    if(estudiante == "Juan"){
      Console.WriteLine("El nombre del estudiante es Juan");
    }else{
      Console.WriteLine("El estudiante no se llama Juan");      
    }  

    if(genero == 'H'){
      Console.WriteLine("El genero de la persona es masculino");  
    }else{
      Console.WriteLine("El genero de la persona es femenino");   
    }
  }
}
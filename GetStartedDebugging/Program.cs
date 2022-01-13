using System; // Indica que las funciones que estamos usando pertenecen a la estructura básica de C# y de la plataforma .Net
class ArrayExample // Creamos la clase 'ArrayExample'
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' }; // Declaramos una variable de tipo char
        string name = ""; // Declaramos una variable de tipo String
        int[] a = new int[10]; // Declaramos una variable de tipo int
        for (int i = 0; i < letters.Length; i++) // Creamos un bucle for
        {
            name += letters[i]; // En cada ciclo añadimos a la variable name una de las letras almacenadas en el array 
            a[i] = i + 1; //  
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg); //Muestra un mensaje en la consola
    }
}
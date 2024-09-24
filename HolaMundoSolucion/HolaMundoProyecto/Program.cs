namespace HolaMundoProyecto
{
    internal class Program
    {
        // Version 1.0
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!!!!");
            Console.WriteLine("Bienvenidos a .Net !!!!!");

            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingresa tu edad:");
            string edadPersonaConsola = Console.ReadLine();

            // Convertir string a entero con Convert
            //                Convierte (Convert) a entero (ToInt32)
            //                lo que has pedido por pantalla (edadPersonaConsola)
            int edadPersona = Convert.ToInt32(edadPersonaConsola);

            //    int          int 
            if (edadPersona >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            } // Fin del if
            else
            {
                Console.WriteLine("Eres menor de edad");
            } // Fin del else

        } // Fin del método Main
    } // Fin de la clase Program
} // namespace HolaMundoProyecto

namespace MesesFunciones
{
    internal class Program
    {
        //Void metodo ()es el cuerpo del metodo
        //pedirle al usuario un numero y que te vuelva a pedir el numero, un siclo el do, while, hacer el uso del int y del if y ponerle color si es correcto o incorrecto
        static void Main(string[] args)
        {
            MostrarMensaje("Hello, World!");
            MostrarMensaje("Introducir un número");
            string mes = ObtenerMes(11);
            MostrarMensaje(mes);
        }

        static void MostrarMensaje(string mensaje)

        {
            Console.WriteLine(mensaje);

        }
        
        static string ObtenerMes(int NumeroMes)
        {
            switch (NumeroMes)
            {
                case 1:return "Enero";
                case 2:return "Febrero";
                case 3:return "Marzo";
                case 4:return "Abril";
                case 5:return "Mayo";
                case 6:return "Junio";
                case 7:return "Julio";
                case 8:return "Agosto";
                case 9:return "Septiembre";
                case 10:return "Octubre";
                case 11:return "Noviembre";
                case 12:return "Diciembre";
                default:return "Número Incorrecto";
            }
        } 
    }
}

using ejercicio3Bucles.servicios;

namespace ejercicio3Bucles.controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            operacionesInterfaz mi = new operacionesImplementacion();

            num = mi.PedirNumero();

            mi.MuestraNumero(num);
        }
    }
}

class Program
{

    //Creacion de la interfaz IJuegoMesa
    //de donde derivaran los juegos de mesa
    public interface IJuegoMesa
    {
        void Jugar();
    }

    //Creacion de la clase Damas que hereda de la interfaz IJuegoMesa
    public class Damas : IJuegoMesa 
    {
        public void Jugar()
        {
            Console.WriteLine("Jugando Damas");
        }
    }

    //Creacion de la clase Ajedrez que hereda de la interfaz IJuegoMesa
    public class Ajedrez : IJuegoMesa 
    {
        public void Jugar()
        {
            Console.WriteLine("Jugando Ajedrez");
        }
    }

    //Creacion de la clase Domino que hereda de la interfaz IJuegoMesa
    public class Domino : IJuegoMesa 
    {
        public void Jugar()
        {
            Console.WriteLine("Jugando Domino");
        }
    }

    //Creacion de la clase JuegoFactory que sera la clase abstracta 
    //de donde derivaran las clases concretas de los juegos de mesa
    //Esta clase tendra un metodo abstracto CrearJuego que sera implementado por
    //las clases concretas
    public abstract class JuegoFactory
    {
        public abstract IJuegoMesa CrearJuego();
    }

    //Se crea la clase concreta DamasFactory que hereda de la clase abstracta JuegoFactory
    //Esta clase implementa el metodo CrearJuego
    //y retorna una instancia de la clase Damas
    public class DamasFactory : JuegoFactory
    {
        public override IJuegoMesa CrearJuego()
        {             
            return new Damas();
        }
    }

    public class AjedrezFactory : JuegoFactory
    {
        public override IJuegoMesa CrearJuego()
        {
            return new Ajedrez();
        }
    }

    public class DominoFactory : JuegoFactory
    {
        public override IJuegoMesa CrearJuego()
        {
            return new Domino();
        }
    }


    static void Main(string[] args)
    {
        //Se crea una variable de tipo JuegoFactory que sera utilizada para crear los juegos de mesa
        JuegoFactory _juegofactory;

        //Se crea una instancia de la clase AjedrezFactory y se asigna a la variable _juegofactory
        _juegofactory = new AjedrezFactory();
        //Se crea una instancia de la clase Ajedrez y se asigna a la variable ajedrez
        IJuegoMesa ajedrez = _juegofactory.CrearJuego();
        //Se llama al metodo Jugar de la clase Ajedrez
        ajedrez.Jugar();

        _juegofactory = new DamasFactory();
        IJuegoMesa damas = _juegofactory.CrearJuego();
        damas.Jugar();

        _juegofactory = new DominoFactory();
        IJuegoMesa domino = _juegofactory.CrearJuego();
        domino.Jugar();
    }
}

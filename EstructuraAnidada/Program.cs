using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraAnidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            //Instanciamos a ListaReproduccion
            ListaReproduccion listareproduccion1 = new ListaReproduccion();
            //Nombramos la lista
            listareproduccion1.Nombre = "Salsa";

            //Agregamos informacion a las canciones contenidas en la lista de reproduccion
            listareproduccion1.cancion1.Titulo = "Te propongo";
            listareproduccion1.cancion1.Artista = "Jeremy Bosch";
            listareproduccion1.cancion1.Duracion = 455;

            listareproduccion1.cancion2.Titulo = "Jura";
            listareproduccion1.cancion2.Artista = "Paulito FG";
            listareproduccion1.cancion2.Duracion = 455;

            //Mostramos la informacion de la lista
            Console.WriteLine(listareproduccion1.ToString());

            





        }
    }
            
    struct Cancion
    {
        //Campos
        string titulo;
        string artista;
        int duracion;
        //Propiedades
        public string Titulo
        {
            get => titulo; set => titulo = value;
        }
        public string Artista { get => artista; set => artista = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        //Invalidamos el metodo ToString para mostrar la informacion de la struct
        public override string ToString()
        {
            
            {
                string mensaje = $"Titulo: {Titulo}\nArtista: {Artista}\nDuracion: {Duracion} segundos ";
                return mensaje;
            }
        }


        /*public string Artista
            {
                get => artista; set => artista = value;
            }
                public int Duracion
                {
                    get => duracion; set => duracion = value;
                    }*/

    }
    struct ListaReproduccion
    {

        //Campos
        string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        //Anidando a la struct "Cancion"
        public Cancion cancion1;
        public Cancion cancion2;

        public override string ToString()
        {
            string mensaje = $"Lista de reproduccion: {Nombre}\n\nCancion 1:\n{cancion1.ToString()}\n\nCancion 2 :\n{cancion2.ToString()}\n";
            return mensaje;
        }


    }
}

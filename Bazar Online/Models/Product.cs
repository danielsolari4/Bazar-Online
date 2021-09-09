using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bazar_Online.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public TipoProducto Tipo { get; set; }
        public State Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPublicacion { get; set; }



        public enum TipoProducto
        {
            Botellita,
            Mate
        }

        public enum State
        {
            Borrador,
            Publicada,
            Eliminada
        }

    }


    

}

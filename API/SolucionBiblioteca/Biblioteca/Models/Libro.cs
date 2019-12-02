using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre_Libro { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string ISBN { get; set; }
    }
}

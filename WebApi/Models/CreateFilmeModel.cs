using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class CreateFilmeModel
    {
        
        public string Titulo { get; set; }

        
        public string Genero { get; set; }

        
        public string Diretor { get; set; }

         
        public int Duracao { get; set; }
    }
}

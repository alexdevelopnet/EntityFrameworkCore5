using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [StringLength(30, ErrorMessage = "o campo genero não pode passar de 30 caracteres ")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "o campo diretor é obrigatório")]
        public string Diretor { get; set; }

        [Range(1, 600, ErrorMessage = "o campo diretor é obrigatório")]
        public int Duracao { get; set; }
    }
}

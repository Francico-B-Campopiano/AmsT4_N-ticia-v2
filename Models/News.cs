using System.ComponentModel.DataAnnotations.Schema;

namespace AmsT4_BLOG_2.Models
{
        public class News
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Author { get; set; }
            public string Category { get; set; }
            public string ImageUrl { get; set; } // Este campo pode ser mantido para o caminho da imagem
            public DateTime PublishedDate { get; set; }

            [NotMapped] // Adiciona esta anotação para não incluir este campo no banco de dados
            public IFormFile ImageFile { get; set; } // Novo campo para o arquivo de imagem
        }

    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace Aula03_Pokedex
{
    [Table("Jogador")]
    class Jogador
    {
        [PrimaryKey, AutoIncrement]
        public int JogadorId { get; set; }

        [MaxLength(10)]
        public string Login { get; set; }

        [MaxLength(40)]
        public string Senha { get; set; }

        public string Nome { get; set; }
    }
}

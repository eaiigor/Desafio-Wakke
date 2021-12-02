using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWakkeOficial
{
    public class Pessoa
    {
        public long ID { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }

    }
}

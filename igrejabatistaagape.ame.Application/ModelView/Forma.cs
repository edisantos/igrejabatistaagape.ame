using System.Collections.Generic;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class Forma
    {
        public string Nome { get; set; }
        public ICollection<membros> Membros { get; set; }

    }
}

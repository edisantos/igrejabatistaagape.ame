using System.Collections.Generic;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class Status
    {
        public string Nome { get; set; }

        public ICollection<membros> Membros { get; set; }

    }
}

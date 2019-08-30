using System.Collections.Generic;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class Parentesco
    {
        public string Nome { get; set; }
        public ICollection<membros> Membros { get; set; }
    }
}

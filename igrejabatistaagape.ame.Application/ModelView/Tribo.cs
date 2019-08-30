using System.Collections.Generic;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class Tribo
    {
        public string Nome { get; set; }
        public ICollection<Intercessor> Intercessor { get; set; }
    }
}
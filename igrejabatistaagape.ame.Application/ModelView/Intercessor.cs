using System;
using System.Collections.Generic;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class Intercessor : Generic
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public int TriboId { get; set; }
        public virtual Tribo Tribo { get; set; }
        public ICollection<membros> Membros { get; set; }
    }
}

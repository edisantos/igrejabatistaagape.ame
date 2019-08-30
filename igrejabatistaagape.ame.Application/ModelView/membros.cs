using System;

namespace igrejabatistaagape.ame.Application.ModelView
{
    public class membros:Generic
    {
      
       
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int StatusId { get; set; }
        public int FormaId { get; set; }
        public int ParentescoId { get; set; }
        public int EstadoCivilId { get; set; }
        public DateTime DataCasamento { get; set; }
        public string Endereco { get; set; }
        public int IntercessorId { get; set; }

       public virtual Status Status { get; set; }
        public virtual Forma Forma { get; set; }
        public virtual Parentesco Parentesco { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Intercessor Intercessor { get; set; }
      

    }
}

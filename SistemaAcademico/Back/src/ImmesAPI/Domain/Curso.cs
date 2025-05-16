using ImmesAPI.Enumerators;

namespace ImmesAPI.Domain
{
    public class Curso
    {
        public int Id { get; set; }
        public required string Nome { get; set; } 
        public EnumTipoPeriodo Periodo { get; set; }
    }
}

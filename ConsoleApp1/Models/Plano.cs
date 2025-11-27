
namespace ConexaoBanco.Models
{
    internal class Plano
    {
        public int Id_plano { get; set; }

        public string Descricao { get; set; }

        private decimal _valorSugerido;
        public decimal ValorSugerido
        {
            get
            {
                return _valorSugerido;
            }
            set
            {
                if (value > 0)
                {
                    _valorSugerido = value;
                }
                else
                {
                    throw new Exception("Valor Inválido");
                }
            }
        }
        public bool Atv { get; set; }
    }

    
}

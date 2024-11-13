namespace CadastroDeEventos.Models
{
    public class EventoFinal
    {
        public Local local_selecionado {  get; set; }
        public int Nparticipantes {  get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string NomeEvento { get; set; }

        public int Diaria
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_participante = Nparticipantes * local_selecionado.ValorParticipante;

                double total = valor_participante * Diaria;

                return total;
            }
        }
    }
}

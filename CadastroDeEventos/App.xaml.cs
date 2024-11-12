
using CadastroDeEventos.Models;

namespace CadastroDeEventos
{
    public partial class App : Application
    {
        public List<Local> lista_locais = new List<Local>
        {
            new Local()
            {
                Descricao = "Salão de Festas Pequeno",
                ValorParticipante = 50.0
            },
            new Local()
            {
                Descricao = "Salão de Festas Médio",
                ValorParticipante = 75.0
            },
            new Local()
            {
                Descricao = "Salão de Festas Grande",
                ValorParticipante = 110.0
            },
            new Local()
            {
                Descricao = "Casa com Piscina SEM Dormitório",
                ValorParticipante = 150.0
            },
            new Local()
            {
                Descricao = "Casa com Piscina, 2 Dormitórios",
                ValorParticipante = 200.0
            },
            new Local()
            {
                Descricao = "Casa com Piscina, 4 Dormitórios",
                ValorParticipante = 270.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CriaçãoDeEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 460;
            window.Height = 720;

            return window;
        }
    }
}

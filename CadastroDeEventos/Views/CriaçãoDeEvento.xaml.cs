using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views;

public partial class CriaçãoDeEvento : ContentPage
{
	App PropiedadesApp;

	public CriaçãoDeEvento()
	{
		InitializeComponent();

		PropiedadesApp = (App)Application.Current;

		pck_local.ItemsSource = PropiedadesApp.lista_locais;

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			EventoFinal h = new EventoFinal
			{
				local_selecionado = (Local)pck_local.SelectedItem,
				Nparticipantes = Convert.ToInt32(stp_part.Value),
				DataInicio = dtpck_inicio.Date,
				DataTermino = dtpck_termino.Date,
				NomeEvento = txt_nome.Text,
			};



			await Navigation.PushAsync(new EventoPronto()
			{
				BindingContext = h,
			});

		}catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(6);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new TabelaDePrecos());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
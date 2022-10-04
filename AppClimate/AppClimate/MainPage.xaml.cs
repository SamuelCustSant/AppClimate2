using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppClimate.Model;
using AppClimate.Services;

namespace AppClimate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Previsão do Tempo";
            this.BindingContext = new tempo();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                

                if (!string.IsNullOrEmpty(cidadeEntry.Text))
                {
                    btnPrevisao.Text = "Carregando...";
                    btnPrevisao.IsEnabled = false;

                    tempo previsaoDoTempo = await dataservice.GetPrevisaoDoTempo(cidadeEntry.Text);
                    this.BindingContext = previsaoDoTempo;

                    Console.WriteLine("Temperatura ======" + previsaoDoTempo.ToString());                  
                    
                }                  
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro ", ex.Message, "OK");
                
            } 
            
            finally
            {
                btnPrevisao.Text = "Nova Previsão";
                btnPrevisao.IsEnabled = true;
                cidadeEntry.Text = " ";
            }
        }
      
    }

}

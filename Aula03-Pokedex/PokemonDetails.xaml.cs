using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Aula03_Pokedex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PokemonDetails : Page
    {
        public PokemonDetails()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Pokemon pokemon = e.Parameter as Pokemon;
            Uri uri = new Uri("ms-appx:///" + pokemon.ImagePath);
            var bitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(uri);
            imgPokemon.Source = bitmap;
            txtNome.Text = pokemon.Name;
            txtTipo.Text = "Tipo: " + pokemon.Tipo;
            txtVida.Text = "Vida: " + pokemon.HP + " HP";
            txtAtaque.Text = "Ataque: " + pokemon.Ataque;
            txtDefesa.Text = "Defesa: " + pokemon.Defesa;

        }

        private void btnRetornar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PokemonList));
        }
    }
}

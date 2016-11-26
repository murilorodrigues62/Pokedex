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
    public sealed partial class PokemonList : Page
    {
        private List<Pokemon> elements;
        public PokemonList()
        {
            this.InitializeComponent();
            elements = new List<Pokemon>();
            elements.Add(new Pokemon() { Name = "Abra", ImagePath = "images/abra.png", Tipo = "PSYCHIC", HP = 50, Ataque = 110, Defesa = 76 });
            elements.Add(new Pokemon() { Name = "Alakazam", ImagePath = "images/alakazam.png", Tipo = "PSYCHIC", HP = 50, Ataque = 110, Defesa = 76 });
            elements.Add(new Pokemon() { Name = "Blastoise", ImagePath = "images/blastoise.png", Tipo = "WATER", HP = 158, Ataque = 186, Defesa = 222 });
            lstPokemon.DataContext = elements;
        }
              

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPokemon.SelectedIndex > -1)
            {
                Frame.Navigate(typeof(PokemonDetails), elements[lstPokemon.SelectedIndex]);
            }
        }
    }
}

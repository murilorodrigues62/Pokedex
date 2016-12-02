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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Aula03_Pokedex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();            
        }

        private async void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Jogador jogador = JogadorDB.GetJogador(txtLogin.Text, pwdSenha.Password);
            if (jogador != null)
            {
                Frame.Navigate(typeof(PokemonList));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Usuário/Senha Inválidos!!!");
                await dialog.ShowAsync();
            }
        }

        private void btnNovoUsua_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Cadastro));
        }
    }
}



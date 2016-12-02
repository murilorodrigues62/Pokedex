using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;

namespace Aula03_Pokedex
{
    class JogadorDB
    {
        public static SQLiteConnection conn;

        public static void LoadDatabase()
        {
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), "sqlitePokemon.db");
            conn.CreateTable<Jogador>();
        }
        // Internal é publico para o projeto
        internal static void SalvarJogador(Jogador jogador)
        {
            conn.Insert(jogador);
        }

        internal static void DeletarJogador(Jogador jogador)
        {
            conn.Delete(jogador);
        }

        internal static List<Jogador> ListaJogadores()
        {
            List<Jogador> retorno = new List<Jogador>();
            var result = conn.Query<Jogador>("Select JogadorId, Login, Senha, Nome FROM Jogador");

            foreach (var item in result)
            {
                retorno.Add(item);
            }
            return retorno;
        }

        internal static Jogador GetJogador(string login, string senha)
        {
            var result = conn.Query<Jogador>("Select JogadorId, Login, Senha, Nome FROM Jogador WHERE Login='" +
                            login + "' AND Senha='" + senha + "'");
            Jogador jogador = null;
            if (result.Count > 0)
                jogador = result[0];

            return jogador;
        }
    }
}

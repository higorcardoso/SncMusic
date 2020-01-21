using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SncMusic
{
    public static class Banco
    {
        static MySqlConnection cn;

        public static MySqlCommand Abrir()
        {
            cn = new MySqlConnection(Properties.Settings.Default.StrConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;

        }
        public static void Fechar()
        {
            // se o estado da conexão for aberto então fechar conexão
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
            // não é necessário utilizar chaves em comandos ou estruturas caso tenha apenas uma comando

        }

    }
}

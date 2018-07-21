using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklep {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Base baza = new Base();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "sklep";
            if (dbCon.IsConnect()) {
                string query = "SELECT * FROM users;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    baza.addUser(reader.GetInt32(3), reader.GetString(1), reader.GetString(2));
                }
                reader.Close();

                query = "SELECT * FROM Tabele;";
                cmd = new MySqlCommand(query, dbCon.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    baza.addTable(reader.GetString(1), reader.GetInt32(2));
                }
                reader.Close();
            }

            Logowanie main = new sklep.Logowanie(baza);
            main.FormClosed += new FormClosedEventHandler(close);
            main.Show();
            Application.Run();
        }

        public static void close(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

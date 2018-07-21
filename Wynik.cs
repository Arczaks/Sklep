using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklep {
    public partial class Wynik : Form {
        public Wynik(string zapytanie) {
            InitializeComponent();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "sklep";
            if (dbCon.IsConnect()) {
                string query = zapytanie;
                var cmd = new MySqlCommand(query, dbCon.Connection);
                try {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        string text = "";
                        for (int i = 0; i < reader.FieldCount; i++) {
                            text += reader.GetString(i) + " ; ";
                        }
                        text += '\n';
                        this.richTextBox1.AppendText(text);
                    }
                    reader.Close();
                }
                catch (MySqlException e) {
                    this.richTextBox1.AppendText(e.Message);
                }
            }
        }
    }
}

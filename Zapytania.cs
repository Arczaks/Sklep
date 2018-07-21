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
    public partial class Zapytania : Form {
        private User myUser;
        private Base myBase;
        public Zapytania(User u, Base b) {
            myUser = u;
            myBase = b;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string zapytanie = this.textBox1.Text;
            string tabela = parse(zapytanie);
            if (tabela.Equals("error")) {
                this.label2.Text = "błędne zapytanie";
            }
            else {
                try {
                    access a = myBase.checkAcces(tabela, myUser);
                    if (a.Equals(access.ACCESS)) {
                        Wynik wyniki = new Wynik(zapytanie);
                        wyniki.Show();
                    }
                    else {
                        this.label2.Text = "odmowa dostępu";
                    }
                } catch (NullReferenceException) {
                    this.label2.Text = "nie ma takiej tabeli";
                }
            }
        }

        private string parse(string zapytanie) {
            string tabela = "";
            string searchString1 = "FROM";
            string searchString2 = "INTO";
            string searchString3 = "ALTER TABLE";
            bool t = false;
            int startIndex = zapytanie.IndexOf(searchString1, StringComparison.OrdinalIgnoreCase);
            if (startIndex == -1) {
                startIndex = zapytanie.IndexOf(searchString2, StringComparison.OrdinalIgnoreCase);
                if (startIndex == -1) {
                    t = true;
                    startIndex = zapytanie.IndexOf(searchString3, StringComparison.OrdinalIgnoreCase);
                    if (startIndex == -1) {
                        return "error";
                    }
                }
            }
            int i = 5;
            if (t) {
                i = 12;
            }
            int lastIndex = zapytanie.IndexOf(" ", startIndex + i);
            if (lastIndex < startIndex) {
                lastIndex = zapytanie.Length - 1;
            }
            tabela = zapytanie.Substring(startIndex + i, lastIndex - startIndex - i);
            return tabela;
        }
    }
}

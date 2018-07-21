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
    public partial class Logowanie : Form {
        private Base myBase;
        public Logowanie(Base b) {
            myBase = b;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (myBase.login(this.textBox1.Text, this.textBox2.Text)) {
                this.Hide();
                int clear = myBase.findUser(this.textBox1.Text).clear;
                Zapytania z = new Zapytania(new User(clear, this.textBox1.Text, this.textBox2.Text), myBase);
                z.FormClosed += new FormClosedEventHandler(Program.close);
                z.Show();
            } else {
                this.label4.Text = "Błędny login lub/i hasło";
            }
        }
    }
}

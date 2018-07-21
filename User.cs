using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep {
    public class User {
        public int clear { get; }
        public string nazwa { get; }
        private string haslo;

        public User(int clear, string nazwa, string haslo) {
            this.clear = clear;
            this.nazwa = nazwa;
            this.haslo = haslo;
        }

        public bool login(string nazwa, string haslo) {
            if (this.nazwa.Equals(nazwa) && this.haslo.Equals(haslo)) {
                return true;
            } else {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep {
    public class Base {
        public Base() {
            this.listaT = new List<Table>();
            this.listaU = new List<User>();
        }
        private List<Table> listaT;
        private List<User> listaU;
        public void addTable(string name, int classO) {
            listaT.Add(new Table(classO, name));
        }

        public Table findTable(string name) {
            return listaT.Find(x => x.nazwa == name);
        }

        public User findUser(string name) {
            return listaU.Find(x => x.nazwa == name);
        }

        public void addUser(int clear, string name, string haslo) {
            listaU.Add(new User(clear, name, haslo));
        }

        public bool login(string nazwa, string haslo) {
            bool r = false;
            listaU.ForEach(x => {
                if (x.login(nazwa, haslo)) {
                    r = true;
                }
            });
            return r;
        }

        public access checkAcces(string table, User u) {
            access a;
            try {
                a = findTable(table).checkAccess(u);
            }
            catch (NullReferenceException e) {
                throw e;
            }
            return a;
        }
    }
}

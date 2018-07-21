using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep {

    public enum access {ACCESS, DENIED };

    public class Table {
        private int classO;
        public string nazwa { get; }

        public Table(int classO, string nazwa) {
            this.classO = classO;
            this.nazwa = nazwa;
        }

        public access checkAccess(User u) {
            if (u.clear >= this.classO) {
                return access.ACCESS;
            } else { 
                return access.DENIED;
            }
        }
    }
}

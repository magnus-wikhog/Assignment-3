using Assignment.ListManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Staff {
    public class Staff {
        private string name;
        private IListManager<string> mQualifications;




        public Staff() {
            mQualifications = new ListManager<string>();
        }


        public IListManager<string> Qualifications { get => mQualifications; }



        public string Name {
            get => name;
            set => name = value;
        }

        override
        public string ToString() {
            return Name + ", " + Qualifications.ToStringList().Aggregate((a, b) => a + ", " + b);
        }

    }
}

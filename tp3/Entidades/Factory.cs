using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factory
    {
        private List<Part> partsList;
        private List<Guitar> guitarsList;

        public Factory()
        {
            this.partsList = new List<Part>();
            this.guitarsList = new List<Guitar>();
        }

        public List<Part> PartsList 
        {
            get
            {
                return partsList;
            }
            set
            {
                this.partsList = value;
            }
        }
        public List<Guitar> GuitarsList
        {
            get
            {
                return guitarsList;
            }
            set
            {
                this.guitarsList = value;
            }
        }

        public bool addPart()
        {
            return true;
        }





        



    }
}

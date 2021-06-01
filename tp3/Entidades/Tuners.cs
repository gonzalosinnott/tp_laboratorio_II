using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tuners : Part
    {
        private TunersMakers tunersMaker;

        public Tuners()
        {
            this.tunersMaker = TunersMaker;
        }

        public TunersMakers TunersMaker
        {
            get 
            {
                return this.tunersMaker;
            } 
            set
            {
                this.tunersMaker = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class EventPublisher
    {

        public String TheVal;

        public event MiEventoHandler valueChanged;
        public String Val
        {
            set
            {
                this.TheVal = value;
                this.valueChanged(value);
            }
        }

    }
}

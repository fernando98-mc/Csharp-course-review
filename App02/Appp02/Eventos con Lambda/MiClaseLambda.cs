
namespace Eventos_con_Lambda
{
    public class MiClaseLambda
    {
        private string theVal;
        private event MiEventoHandler valueChange;

        public string val
        {
            set
            {
                // accionar el evento
                this.theVal = value;
                this.valueChange(theVal);
            }
        }

    }
}

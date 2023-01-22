using ClassLibrary1;

namespace AzureAdDemo.Controllers
{
    public class ConsumeLib
    {
        Algebra alg = new Algebra();
        public double addition()
        {
            double add = alg.Addition(1, 2);
            return add;
        }

    }
}

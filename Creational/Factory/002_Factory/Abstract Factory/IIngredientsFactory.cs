using System.Collections.Generic;

namespace _002_Factory
{
    interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}

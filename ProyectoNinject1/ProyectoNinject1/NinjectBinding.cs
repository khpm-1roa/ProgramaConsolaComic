using System;
namespace ProyectoNinject1
{
    public class NinjectBinding:Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ILibrero>().To<Libreria>();
        }
    }
}

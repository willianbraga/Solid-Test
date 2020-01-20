using System;
using SOLID.Services;

namespace SOLID.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (PAI)");
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerou o motor (PAI)");
        }
    }
}
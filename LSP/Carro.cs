using System;
using SOLID.Services;

namespace SOLID.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (FILHO)");
            base.LigarMotor();
        }
    }
}
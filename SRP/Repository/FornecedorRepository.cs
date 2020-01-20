using System;

namespace SOLID.SRP
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.WriteLine("Salvou");
        }
    }

}
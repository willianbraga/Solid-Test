using System;
using SOLID.DIP;
using SOLID.DIP.Contracts;
using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP

            // Fornecedor fornecedor = new Fornecedor();
            // fornecedor.ChangeName("Willian");

            // IFornecedorRepository rep = new FornecedorRepository();
            // rep.Salvar(fornecedor);
            
            #endregion
            #region OCP

            // Pessoa p = new Pessoa("Willian");
            // p.ChangeName("Willian Braga");

            // PessoaFisica pf = new PessoaFisica("Willian", "999.999.99-9");

            #endregion
            #region LSP

            // var veiculo = new Carro();
            // veiculo.LigarMotor();
            // Console.ReadLine();

            #endregion
            #region ISP

            // NotaFiscal nf = new NotaFiscal();
            // nf.RealizaPedido();

            #endregion
            #region DIP

            var rep  = new CustomerRepository();
            var customerService = new CustomerService(rep);
            customerService.Register("Willian");

            #endregion
        }
    }
}

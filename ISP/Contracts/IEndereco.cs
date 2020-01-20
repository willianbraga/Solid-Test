using System;

namespace SOLID.ISP.Contracts
{
    public interface IEndereco
    {
         string Cidade { get; set; }
         string Estado { get; set; }
         string Pais { get; set; }
    }
}
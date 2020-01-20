using SOLID.Services;

namespace SOLID.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            NotificationService.Notify("willian.kaeru@gmail.com");
        }
    }
}
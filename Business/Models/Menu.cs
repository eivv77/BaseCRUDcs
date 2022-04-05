namespace Business.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Menu(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }
}

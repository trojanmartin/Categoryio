namespace Categoryio.Destkop.Models
{
    public class Category : BaseModel
    {
        private string _name;
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    }
}

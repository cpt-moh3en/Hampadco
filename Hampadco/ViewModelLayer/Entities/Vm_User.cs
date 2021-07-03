using System.ComponentModel.DataAnnotations;

namespace ViewModelLayer.Entities
{
    public class Vm_User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }  
    }
}
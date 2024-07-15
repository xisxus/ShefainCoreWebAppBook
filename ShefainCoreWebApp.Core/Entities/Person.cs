using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShefainCoreWebApp.Core.Entities
{
    [Table("Persons", Schema = "dbo")]
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; } = string.Empty ;
        [Required]
        public string EmailAddress { get; set; } = string.Empty ;
        public List<Address> Addresses { get; set; } = new List<Address>();
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        public List<Person> Parents { get; set; } = new List<Person>();
        public List<Person> Children { get; set; } = new List<Person>();
        public DateTime CreatedOn { get; set; }

        //public bool  IsDeleted { get; set; }

        public  List<Person> Parent { get; set; } = new List<Person> ();
        public  List<Person> Childrens { get; set; } = new List<Person> () ;

    }
}
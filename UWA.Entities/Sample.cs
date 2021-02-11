using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWA.Entities
{
    public class Sample
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public string Name { get; set; }
    }
}

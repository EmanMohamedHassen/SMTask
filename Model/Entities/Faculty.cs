using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("tbl_Faculty")]
    public class Faculty
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

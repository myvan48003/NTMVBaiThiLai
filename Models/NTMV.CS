using System.ComponentModel.DataAnnotations;

namespace NTMVBaiThiLai.Models
{
    [Table("NTMV")]
    public class NTMV
    //  public class Employee : Person dành cho việc Employee kế thừa
    {
        [Key]
        public string PersonId { get; set; }
        public int FullName { get; set; }
        public int Address { get; set; }
    }
}
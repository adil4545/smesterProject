using System.ComponentModel.DataAnnotations;

namespace tour_and_travel.Models
{
    public class book
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string cname { get; set; }
        [Required]
        public string cdestination { get; set; }
        [Required]
        public int cadult {  get; set; }
        [Required]
        public int cchild{ get; set; }
        [Required]
        public int cstay { get; set; }
        

    }
}

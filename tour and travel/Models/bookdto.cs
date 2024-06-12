using System.ComponentModel.DataAnnotations;

namespace tour_and_travel.Models
{
    public class bookdto
    {
        public string cname { get; set; }
        [Required]
        public string cdestination { get; set; }
        [Required]
        public int cadult { get; set; }
        [Required]
        public int cchild { get; set; }
        [Required]
        public int cstay { get; set; }
        



    } }



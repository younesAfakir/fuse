using System;
using System.ComponentModel.DataAnnotations;

namespace Fuse.Model
{
    public class Costumer
    {
        public Costumer()
        {
        }

        [Key]
        public int IdCostumer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int NbrArticle { get; set; }

    }
}

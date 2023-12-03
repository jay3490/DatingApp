using System.ComponentModel.DataAnnotations.Schema;
using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Entities
{
    public class Photo
    {
        [Table("Photos")

        public int id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
    }
}
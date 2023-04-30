using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models {
    public class Tag 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Slug {get; set;}
        public List<Post> Posts { get; set; }
    }
}
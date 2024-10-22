using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]

        public int CommentID { get; set; }
        public string CommetUser { get; set; }
        public DateTime CommetDate { get; set; }
        public string CommetContent { get; set; }
        public bool CommetState { get; set; }
    }
}

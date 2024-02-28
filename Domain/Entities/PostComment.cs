using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostComment
    {
        public long PostId { get; set; }
        public Post Post { get; set; }
       
        public long CommentId { get; set; }
        public Comment Comment { get; set; }


    }
}

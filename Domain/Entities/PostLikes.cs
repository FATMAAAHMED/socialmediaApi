using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostLikes
    {
        public long PostId { get; set; }
        public Post Post { get; set; }

        public long LikeId { get; set; }
        public Like Like { get; set; }
    }
}

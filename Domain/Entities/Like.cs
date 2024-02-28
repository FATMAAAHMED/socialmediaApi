using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Like
    {
        public long Id { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        //public long PostId { get; set; }
        //public Post Post { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public ICollection<PostLikes>? PostLikes { get; set; }


    }
}

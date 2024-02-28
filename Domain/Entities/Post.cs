using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public DateTime timeStamp { get; set; } = DateTime.Now;
        public int Likes_count { get; set; }
        public int Comments_count { get; set; }
        public int Shares_count { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public ICollection<PostLikes>? PostLikes { get; set; }
        public ICollection<PostComment>? PostComments { get; set; }
        public ICollection<PostShares>? PostShares { get; set; }


    }
}

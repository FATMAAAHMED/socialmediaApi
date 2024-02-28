using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostShares
    {
        public long PostId { get; set; }
        public Post Post { get; set; }

        public long ShareId { get; set; }
        public Share Share { get; set; }
    }
}

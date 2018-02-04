using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
    public class Vote
    {
        public Vote()
        {
            UpVoteCount = 0;
            DownVoteCount = 0;
        }
        public int UpVoteCount { get; set; }
        public int DownVoteCount { get; set; }
        public int TotalPoint => UpVoteCount - DownVoteCount;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TamaguchiClient.DTO
{
    class ActivityDTO
    {
        public string ActivityName { get; set; }
        public int ImprovementHappiness { get; set; }
        public int ImprovementHunger { get; set; }
        public int ImprovementHygiene { get; set; }
        public int CategoryId { get; set; }



    }
}

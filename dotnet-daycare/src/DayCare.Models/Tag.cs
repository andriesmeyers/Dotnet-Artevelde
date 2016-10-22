using System;
using System.Collections.Generic;

namespace DayCare.Models
{
    public class Tag : BaseEntity<Int64>
    {
            public List<PostTag> Posts { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProjectMemberDTO
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int MemberId { get; set; }
    }
}

﻿using DAL.CodeFirst;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Member, int, bool> MemberData()
        {
            return new MemberRepoV2();
        }
    }
}

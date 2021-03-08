﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace YC.Students
{
    public static class StudentsQueryableExtensions //auto-generated
    {
        public static IQueryable<Student> IncludeDetails(this IQueryable<Student> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }
            return queryable
                .Include(x => x.Group);
        }
        public static IQueryable<Group> IncludeDetails(this IQueryable<Group> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }
            return queryable
                .Include(x => x.Students);
        }
    }
}
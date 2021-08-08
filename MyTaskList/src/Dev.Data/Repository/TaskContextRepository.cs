using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Repository
{
    public class TaskContextRepository : RepositoryBase<TaskContext>, ITaskContextRepository
    {
        public TaskContextRepository(EfContext context) : base(context) { }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FrameWork.Data
{
    public class GoalsSampleData : DropCreateDatabaseIfModelChanges<FrameWorkEntities>
    {
        protected override void Seed(FrameWorkEntities context)
        {
            context.Commit();
        }

    }
}
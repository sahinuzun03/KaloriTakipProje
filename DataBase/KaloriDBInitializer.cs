using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KaloriDeneme_1111.ModelCluster;

namespace KaloriDeneme_1111.DataBase
{
    public class KaloriDBInitializer : CreateDatabaseIfNotExists<KaloriDbContext>
    {

        protected override void Seed(KaloriDbContext context)
        {
            
            context.SaveChanges();

            base.Seed(context);
        }
    }
}

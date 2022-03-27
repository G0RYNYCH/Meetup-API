using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetups.Persistence
{
    //starts with the app and checks weather a database exists or not
    public class DbInitializer
    {
        public static void Initialize (MeetupsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

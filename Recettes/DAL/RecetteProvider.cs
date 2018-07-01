using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recettes.DAL
{
    public class RecetteProvider
    {
        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Recettes.Count();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}

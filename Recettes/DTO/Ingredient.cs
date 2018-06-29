using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recettes.DTO
{
    public class Ingredient
    {
        public int Id { get; set; }
        public double Quantite { get; set; }
        public string Unite { get; set; }
        public string Nom { get; set; }
    }
}

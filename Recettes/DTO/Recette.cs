using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recettes.DTO
{
    public class Recette
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int NbPersonnes { get; set; }
        public int TempsPreparation { get; set; }
        public int TempsCuisson { get; set; } 
    }
}

using LibTraitement.Business;
using LibTraitement.Domain;
using System.Collections.Generic;

namespace EBP_MVC.Models
{
    
    public class ModelView
    {
        #region Properties

        public string OriginalText { get; set; }

        public string FinalText { get; set; }

        public List<Traitement> DropDownTraitementItems { get; set; } 

        #endregion
              
        #region Constructor

        public ModelView()
        {
            var traitementCollection = new TraitementCollection();
            DropDownTraitementItems = traitementCollection.TraitementElements;
        }

        #endregion
               
    }
}
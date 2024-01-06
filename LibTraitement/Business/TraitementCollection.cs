using LibTraitement.Actions;
using LibTraitement.Domain;
using System.Collections.Generic;

namespace LibTraitement.Business
{
    public class TraitementCollection
    {
        #region Properties

        public List<Traitement> TraitementElements { get; private set; }

        #endregion

        #region Constructor
        public TraitementCollection()
        {
            TraitementElements = new List<Traitement>();

            TraitementElements.Add(
                new Traitement()
                {
                    KeyName = EnumTypeTraitement.Invertion,
                    LiteralName = "Inversion",
                     BaseTransformation = new Invertion()
                }
                );


            TraitementElements.Add(
               new Traitement()
               {
                   KeyName = EnumTypeTraitement.Numeration,
                   LiteralName = "Numeration",
                   BaseTransformation = new Numeration()
               }
               );

             TraitementElements.Add(
               new Traitement()
               {
                   KeyName = EnumTypeTraitement.CountElments,
                   LiteralName = "Count elements",
                   BaseTransformation = new CountElments()
               }
               );
            
        }

        #endregion

    }
}

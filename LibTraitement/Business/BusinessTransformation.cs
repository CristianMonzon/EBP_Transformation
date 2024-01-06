using LibTraitement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibTraitement.Business
{
    public class BusinessTransformation
    {

        public BusinessTransformation()
        {

        }

        public static BaseTransformation getClass(string keyname)
        {
            BaseTransformation baseTransf = null;

            try
            {
                var traitCollection = new TraitementCollection();

                if (!string.IsNullOrEmpty(keyname))
                {
                    EnumTypeTraitement result;

                    //Ver si se puede transformar el enumerator
                    if (Enum.TryParse<EnumTypeTraitement>(keyname, out result))
                    {
                        IEnumerable<Traitement> resultList = (from c in traitCollection.TraitementElements where c.KeyName == result select c);

                        if (resultList != null && resultList.Any())
                        {
                            //Asumo uno solo
                            baseTransf = resultList.Single().BaseTransformation;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO Log error
                baseTransf = null;
            }

            return baseTransf;
        }

        public static BaseTransformation getClass(Traitement traitement)
        {
            BaseTransformation baseTransf = null;

            try
            {
                var traitCollection = new TraitementCollection();

                if (traitement != null)
                {
                    IEnumerable<Traitement> resultList = (from c in traitCollection.TraitementElements where c.KeyName==traitement.KeyName select c);

                    if (resultList != null && resultList.Any())
                    {
                        //Asumo uno solo
                        baseTransf = resultList.Single().BaseTransformation;
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO Log error
                baseTransf = null;
            }

            return baseTransf;
        }


    }
}

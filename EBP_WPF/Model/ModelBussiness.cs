using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LibTraitement.Domain;

namespace EBP_WPF.Model
{
    public class ModelBussiness
    {

        #region Properties

        private string OriginalText;
        private string DestinationText;
        private object traitement;

        private bool? isValid;
        public bool? IsValid
        {
            get
            {
                if (isValid.HasValue)
                {
                    return isValid;
                }
                else
                {
                    SetIsValid();
                    return isValid;
                }
            }
        }

        public string ErrorMessage { get; private set; }

        public Traitement Traitement
        {
            get
            {
                return (traitement as Traitement);
            }
        }


        #endregion

        #region Constructor

        public ModelBussiness(string sourceFile, string destinationFile, object traitement)
        {
            this.OriginalText = sourceFile;
            this.DestinationText = destinationFile;
            this.traitement = traitement;
        }

        #endregion

        public void SetIsValid()
        {
            this.isValid = true;

            if (String.IsNullOrEmpty(this.OriginalText))
            {
                isValid = false;
                ErrorMessage = "Original text is empty";
                return;
            }

            if (Traitement == null)
            {
                isValid = false;
                ErrorMessage = "Type of transformation is not valid.";
                return;
            }

        }

    }
}

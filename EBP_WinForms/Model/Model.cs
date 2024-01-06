using LibTraitement.Domain;
using System;

namespace EBP_WinForms
{
    public class Model
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

        public Model(string sourceFile, string destinationFile, object traitement)
        {
            this.OriginalText = sourceFile;
            this.DestinationText = destinationFile;
            this.traitement = traitement;
        }

        #endregion

        #region Methods

        public void SetIsValid()
        {
            this.isValid = true;

            if (String.IsNullOrEmpty(this.OriginalText))
            {
                isValid = false;
                ErrorMessage = "Original text is empty";
                return;
            }

            if (traitement == null)
            {
                isValid = false;
                ErrorMessage = "Type of transformation is not valid.";
                return;
            }

        } 

        #endregion

    }
}

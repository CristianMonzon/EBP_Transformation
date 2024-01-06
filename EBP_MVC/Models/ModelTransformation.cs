using LibTraitement.Business;
using LibTraitement.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EBP_MVC.Models
{
    public class ModelTransformation : IValidatableObject
    {

        #region Properties

        //public BaseTransformation baseNumeration { get; set; }
        [Display(Name = "Original text:")]
        [Required(ErrorMessage = "Original text must be empty")]
        [DataType(DataType.MultilineText)]
        public string OriginalText { get; set; }

        [Display(Name = "Final text:")]
        public string FinalText { get; set; }

        [Required]
        public string DropDownTraitementField { get; set; }

        public List<Traitement> DropDownTraitementItems { get; set; }

        [Display(Name = "Type:")]
        public string DropDownTraitementLiteralName { get; set; }

        public string ErrorMessage { get; set; }

        #endregion

        #region Constructor

        public ModelTransformation()
        {
            var traitementCollection = new TraitementCollection();
            DropDownTraitementItems = traitementCollection.TraitementElements;

            if (DropDownTraitementItems != null && DropDownTraitementItems.Any())
            {
                DropDownTraitementField = DropDownTraitementItems.Last().LiteralName;
            }

            this.OriginalText = "Insert text to transform ...";
        }

        #endregion

        #region Methods

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var list = new List<ValidationResult>();

            if (string.IsNullOrEmpty(OriginalText))
            {
                list.Add(new ValidationResult("Original text must be empty", new string[] { "OriginalText" }));
            }

            return list;
        }

        #endregion

        
    }
}
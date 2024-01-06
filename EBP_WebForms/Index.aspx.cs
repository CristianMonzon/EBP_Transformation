using LibTraitement.Business;
using LibTraitement.Domain;
using System;

namespace EBP_WebForms
{
    public partial class Index : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.Page.IsPostBack)
                {
                    var traitementCollection = new TraitementCollection();
                    this.DropDownList.DataSource = traitementCollection.TraitementElements;
                    this.DropDownList.DataValueField = Traitement.KEYPROPERTY;
                    this.DropDownList.DataTextField = Traitement.VALUEPROPERTY;

                    LoadDefaultData();
                }

                this.DataBind();
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }


        /// <summary>
        /// Add default data
        /// </summary>
        private void LoadDefaultData()
        {
            this.txtOriginalText.Text = string.Concat("ABC", System.Environment.NewLine, "DEF");
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                BaseTransformation baseTransf = BusinessTransformation.getClass(this.DropDownList.SelectedValue);
                if (baseTransf != null)
                {
                    baseTransf.OriginalText = this.txtOriginalText.Text;

                    baseTransf.Transform();

                    this.txtDestinationText.Text = baseTransf.ResultFormatedText;

                }
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }
    }
}
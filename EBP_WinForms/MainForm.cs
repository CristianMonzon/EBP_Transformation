using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using LibTraitement.Business;
using LibTraitement.Domain;

namespace EBP_WinForms
{
    public partial class MainForm : Form
    {

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetTypeTransformation();
                LoadDefaultData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Are you sure you want to close the application", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No;
        }

        /// <summary>
        /// Handles the Click event of the btnExecute control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {

                Model uiMapping = new Model(this.txtOriginalText.Text
                                                    , this.txtDestinationText.Text
                                                    , this.comboTypeTransformation.SelectedValue);

                if (uiMapping.IsValid == true)
                {
                    BaseTransformation baseTransf = BusinessTransformation.getClass(this.comboTypeTransformation.SelectedItem as Traitement);

                    if (baseTransf == null)
                    {
                        ShowErrorMessage("It was not possible to select a transformation method");
                    }
                    else
                    {
                        baseTransf.OriginalText = this.txtOriginalText.Text;
                        baseTransf.Transform();
                        this.txtDestinationText.Text = baseTransf.ResultFormatedText;
                        ShowInformation("Operation executed");
                    }

                }
                else
                {
                    ShowErrorMessage(uiMapping.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }


        #endregion

        #region Methods

        /// <summary>
        /// Sets the type transformation.
        /// </summary>
        private void SetTypeTransformation()
        {
            TraitementCollection tc = new TraitementCollection();
            this.comboTypeTransformation.DataSource = tc.TraitementElements;
            this.comboTypeTransformation.DisplayMember = Traitement.VALUEPROPERTY;
            this.comboTypeTransformation.ValueMember = Traitement.KEYPROPERTY;
        }

        /// <summary>
        /// Add default data
        /// </summary>
        private void LoadDefaultData()
        {
            this.txtOriginalText.Text = string.Concat("ABC", System.Environment.NewLine, "DEF");            
        }

        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="error">The error.</param>
        private void ShowErrorMessage(string error)
        {
            MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInformation(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }
}

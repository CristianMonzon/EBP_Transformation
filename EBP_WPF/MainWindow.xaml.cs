using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EBP_MVC.Models;
using LibTraitement.Business;
using LibTraitement.Domain;

namespace EBP_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CommandBinding MyCommandBinding;
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "EBP - Informatique";
            this.DataContext = new ModelView()
            {
                OriginalText = "Write list of texts ..."
            };
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BaseTransformation baseTransf = BusinessTransformation.getClass(ListBoxName.SelectedItem as Traitement);

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
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ShowErrorMessage(string error)
        {
            MessageBox.Show(error, Window.TitleProperty.Name, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ShowInformation(string message)
        {
            MessageBox.Show(message, Window.TitleProperty.Name, MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}

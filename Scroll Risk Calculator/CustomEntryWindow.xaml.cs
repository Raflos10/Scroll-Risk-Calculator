using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Scroll_Risk_Calculator
{
    /// <summary>
    /// Interaction logic for CustomEntryWindow.xaml
    /// </summary>
    public partial class CustomEntryWindow : Window
    {
        public int SuccessChance { get; private set; } = 100;
        public int DestroyChance { get; private set; }

        public CustomEntryWindow(int successChance, int destroyChance)
        {
            InitializeComponent();

            this.SuccessChance = successChance;
            this.DestroyChance = destroyChance;
            this.Success_Chance_TextBox.Text = SuccessChance.ToString();
            this.Destroy_Chance_TextBox.Text = DestroyChance.ToString();

            this.KeyDown += new KeyEventHandler(CustomEntryWindow_KeyDown);
        }

        #region Events
        
        private void Success_Chance_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Success_Chance_TextBox.Text == "")
                Success_Chance_TextBox.Text = SuccessChance.ToString();
        }

        private void Destroy_Chance_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Destroy_Chance_TextBox.Text == "")
                Destroy_Chance_TextBox.Text = DestroyChance.ToString();
        }

        private void Success_Chance_TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.Handled = false;
        }

        private void Destroy_Chance_TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.Handled = false;
        }

        private void Success_Chance_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = AllowedText(Success_Chance_TextBox.Text + e.Text);
        }

        private void Destroy_Chance_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = AllowedText(Destroy_Chance_TextBox.Text + e.Text);
        }

        void CustomEntryWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                EndWithResult();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            EndWithResult();
        }

        #endregion

        private bool AllowedText(string text)
        {
            int value;
            return !(int.TryParse(text, out value) && value >= 0 && value <= 100);
        }

        private void EndWithResult()
        {
            SuccessChance = int.Parse(Success_Chance_TextBox.Text);
            DestroyChance = int.Parse(Destroy_Chance_TextBox.Text);

            DialogResult = true;
            Close();
        }
    }
}

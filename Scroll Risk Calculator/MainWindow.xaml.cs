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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scroll_Risk_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<int, RadioButton> radioButtons = new Dictionary<int, RadioButton>();

        public MainWindow()
        {
            InitializeComponent();

            radioButtons.Add(100, Button_100p);
            radioButtons.Add(70, Button_70p);
            radioButtons.Add(60, Button_60p);
            radioButtons.Add(30, Button_30p);
            radioButtons.Add(10, Button_10p);
        }

        #region Events

        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #region Radio Button Clicks

        private void Button_100p_Click(object sender, RoutedEventArgs e)
        {
            Update_Current_Scroll(100, 0);

            Update_Totals();
        }

        private void Button_70p_Click(object sender, RoutedEventArgs e)
        {
            Update_Current_Scroll(70, 15);

            Update_Totals();
        }

        private void Button_60p_Click(object sender, RoutedEventArgs e)
        {
            Update_Current_Scroll(60, 0);

            Update_Totals();
        }

        private void Button_30p_Click(object sender, RoutedEventArgs e)
        {
            Update_Current_Scroll(30, 35);

            Update_Totals();
        }

        private void Button_10p_Click(object sender, RoutedEventArgs e)
        {
            Update_Current_Scroll(10, 0);

            Update_Totals();
        }

        #endregion

        #region ScrollBox Button Clicks

        private void Up_Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int selectedIndex = Scroll_Listbox.SelectedIndex;
            if (selectedIndex > 0)
            {
                object item = Scroll_Listbox.SelectedItem;
                Scroll_Listbox.Items.Remove(item);
                Scroll_Listbox.Items.Insert(selectedIndex - 1, item);
                Scroll_Listbox.SelectedItem = item;
            }

            Scroll_Listbox.Focus();
        }

        private void Down_Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int selectedIndex = Scroll_Listbox.SelectedIndex;
            if (selectedIndex < Scroll_Listbox.Items.Count - 1 & selectedIndex != -1)
            {
                object item = Scroll_Listbox.SelectedItem;
                Scroll_Listbox.Items.Remove(item);
                Scroll_Listbox.Items.Insert(selectedIndex + 1, item);
                Scroll_Listbox.SelectedItem = item;
            }

            Scroll_Listbox.Focus();
        }

        private void Add_Scroll_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Scroll_Listbox.SelectedItem == null)
                Scroll_Listbox.Items.Add(new ScrollListBoxItem(100, 0));
            else
            {
                Scroll_Listbox.Items.Insert(Scroll_Listbox.SelectedIndex + 1, new ScrollListBoxItem(100, 0));
                Scroll_Listbox.SelectedIndex += 1;
            }

            Scroll_Listbox.Focus();
            Update_Totals();
        }

        private void Remove_Scroll_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Scroll_Listbox.SelectedItem != null)
            {
                int selection = Scroll_Listbox.Items.IndexOf(Scroll_Listbox.SelectedItem);
                Scroll_Listbox.Items.Remove(Scroll_Listbox.SelectedItem);
                if (selection < Scroll_Listbox.Items.Count - 1)
                    Scroll_Listbox.SelectedIndex = selection;
                else
                    Scroll_Listbox.SelectedIndex = Scroll_Listbox.Items.Count - 1;
            }

            Scroll_Listbox.Focus();
            Update_Totals();
        }

        private void Duplicate_Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Scroll_Listbox.SelectedItem is ScrollListBoxItem scrollListBoxItem)
            {
                Scroll_Listbox.Items.Insert(Scroll_Listbox.SelectedIndex, new ScrollListBoxItem(scrollListBoxItem.SuccessChance, scrollListBoxItem.DestroyChance));
            }

            Scroll_Listbox.Focus();
            Update_Totals();
        }

        #endregion

        private void Scroll_Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_Radio_Buttons();
        }

        private void Button_Custom_Click(object sender, RoutedEventArgs e)
        {
            if(Scroll_Listbox.SelectedItem is ScrollListBoxItem scrollListBoxItem)
            {
                CustomEntryWindow customEntryWindow = new CustomEntryWindow(scrollListBoxItem.SuccessChance, scrollListBoxItem.DestroyChance);
                customEntryWindow.Owner = this;
                if(customEntryWindow.ShowDialog() == true)
                {
                    Update_Current_Scroll(customEntryWindow.SuccessChance, customEntryWindow.DestroyChance);
                    Update_Totals();
                }
            }
        }

        #endregion

        #region Update Functions

        private void Update_Radio_Buttons()
        {
            if (Scroll_Listbox.SelectedItem is ScrollListBoxItem scrollListboxItem)
            {
                Unselect_All_RadioButtons();

                if (radioButtons.ContainsKey(scrollListboxItem.SuccessChance))
                    radioButtons[scrollListboxItem.SuccessChance].IsChecked = true;
            }
        }

        private void Unselect_All_RadioButtons()
        {
            foreach (KeyValuePair<int, RadioButton> entry in radioButtons)
                entry.Value.IsChecked = false;
        }

        private void Update_Current_Scroll(int successValue, int destroyValue)
        {
            if (Scroll_Listbox.SelectedItem is ScrollListBoxItem scrollListboxItem)
                scrollListboxItem.UpdateValues(successValue, destroyValue);
        }

        private void Update_Totals()
        {
            decimal CalculateChance(int[] chances, bool inverted)
            {
                decimal chance = 1;
                if (chances.Length < 1)
                    chance = 0;
                else
                {
                    for (int i = 0; i < chances.Length; i++)
                    {
                        decimal chanceAsDecimal = chances[i] * (decimal)0.01;
                        chance *= inverted ? 1 - chanceAsDecimal : chanceAsDecimal;
                    }
                    chance = inverted ? 1 - chance : chance;
                }
                return chance * 100;
            }

            List<int> successChances = new List<int>();
            List<int> destroyChances = new List<int>();
            foreach (ScrollListBoxItem scrollListBoxItem in Scroll_Listbox.Items)
            {
                successChances.Add(scrollListBoxItem.SuccessChance);
                destroyChances.Add(scrollListBoxItem.DestroyChance);
            }

            Perfect_Chance_Label.Content = Math.Round(CalculateChance(successChances.ToArray(), false), 2) + "%";

            Destroy_Chance_Label.Content = Math.Round(CalculateChance(destroyChances.ToArray(), true), 2) + "%";

            OnePlus_Chance_Label.Content = Math.Round(CalculateChance(successChances.ToArray(), true), 2) + "%";
        }

        #endregion
    }

    public class ScrollListBoxItem : ListBoxItem
    {
        private int successChance = 100;
        public int SuccessChance
        {
            get { return successChance; }
            private set
            {
                if (value >= 0 && value <= 100)
                    successChance = value;
            }
        }

        private int destroyChance = 0;
        public int DestroyChance
        {
            get { return destroyChance; }
            private set
            {
                if (value >= 0 && value <= 100)
                    destroyChance = value;
            }
        }

        public ScrollListBoxItem(int successChance, int destroyChance)
        {
            UpdateValues(successChance, destroyChance);
        }

        public void UpdateValues(int successChance, int destroyChance)
        {
            this.SuccessChance = successChance;
            this.DestroyChance = destroyChance;
            if (DestroyChance > 0)
                this.Content = SuccessChance + "% Dark Scroll (" + DestroyChance + "% Chance Destroy)";
            else this.Content = SuccessChance + "% Scroll";
        }
    }
}

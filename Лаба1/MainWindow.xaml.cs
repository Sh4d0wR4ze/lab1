using ConsoleApp8.Kontroller;
using ConsoleApp8.Model;
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

namespace Лаба1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OformlenieZakaza oformlenie = new OformlenieZakaza();
        Eda todayMenu;
        int Mode;
        public MainWindow()
        {
            todayMenu = new Eda();

            InitializeComponent();

            MenuView.ItemsSource = todayMenu.Edaa;
            SpisokZakaza.ItemsSource = oformlenie.MAX;
            SpisokVsehZakazov.ItemsSource = oformlenie.MAX2;

        }
        private void MenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ZurBestellunghinzufugen_Click(object sender, RoutedEventArgs e)
        {
            if (MenuView.SelectedItem == null)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
            try
            {
                oformlenie.Vybrat((Bludo)MenuView.SelectedItem, Convert.ToInt32(Kolvo.Text));
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Введите количество с помощью цифр");
            }
            SpisokZakaza.Items.Refresh();
        }

        private void Bestellungbeenden_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokZakaza.Items.Count == 0)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
                try
                {
                    oformlenie.Sozdat();
                }
                catch(Exception ax)
                {
                    MessageBox.Show("Выберите блюдо из меню");
                }
            SpisokVsehZakazov.Items.Refresh();
        }

        private void Zakaz_Click(object sender, RoutedEventArgs e)
        {
                SpisokZakaza.ItemsSource = oformlenie.MAX;
        }
        private void OldZakaz_Click(object sender, RoutedEventArgs e)
        {
            if (SpisokVsehZakazov.SelectedItem == null)
            {
                MessageBox.Show("Выберите заказ из списка");
            }
            else 
            try
            {
                SpisokZakaza.ItemsSource = ((ZakazDannie)SpisokVsehZakazov.SelectedItem).SpisokBlyud;
            }
            catch (Exception ix)
            {
                MessageBox.Show("Выберите заказ из списка");
            }

        }
    }
}

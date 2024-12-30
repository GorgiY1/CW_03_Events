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

namespace CW_03_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbInfo.Text = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbInfo.Text = "";
        }

        private void StackPanel_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "StackPanel_MouseRightButtonUp\n"; 
        }
        private void StackPanel_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "StackPanel_PreviewMouseRightButtonUp\n";
        }

        private void btnMain_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnMain_PreviewMouseRightButtonUp\n";
        }

        private void btnMain_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnMain_MouseRightButtonUp\n";
        }

        private void btnTwol_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnTwol_PreviewMouseRightButtonUp\n";
        }

        private void btnTwo_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnTwo_MouseRightButtonUp\n";
        }
        //=============================================================
        private void lblSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(lblSource, lblSource.Content, DragDropEffects.Copy);
        }

        private void lblDestination_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            //e.Effects = e.Data.GetDataPresent(DataFormats.Text)
        }

        private void lblDestination_Drop(object sender, DragEventArgs e)
        {
            lblDestination.Content = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}

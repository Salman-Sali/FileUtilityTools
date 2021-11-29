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

namespace FileUtilityTools.Presentation.IndexControls
{
    /// <summary>
    /// Interaction logic for SelectionControl.xaml
    /// </summary>
    public partial class SelectionControl : UserControl
    {
        private IndexHomeControl _indexHomeControl;
        public SelectionControl(IndexHomeControl indexHomeControl)
        {
            InitializeComponent();
            _indexHomeControl = indexHomeControl;
        }

        private void NewIndexButton_Click(object sender, RoutedEventArgs e)
        {
            _indexHomeControl.IndexerContent.Content = new StartIndexControl();
        }
    }
}

using FileUtilityTools.Presentation.IndexControls;
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

namespace FileUtilityTools.Presentation.HomeControls
{
    /// <summary>
    /// Interaction logic for HomeScreenControl.xaml
    /// </summary>
    public partial class HomeScreenControl : UserControl
    {
        private Shell _shell;
        public HomeScreenControl(Shell shell)
        {
            InitializeComponent();
            _shell = shell;
        }

        private void IndexButton_Click(object sender, RoutedEventArgs e)
        {
            _shell.Content = new IndexHomeControl(_shell);
        }
    }
}

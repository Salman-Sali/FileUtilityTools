using FileUtilityTools.Presentation.HomeControls;
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
    /// Interaction logic for IndexHomeControl.xaml
    /// </summary>
    public partial class IndexHomeControl : UserControl
    {
        private Shell _shell;
        public IndexHomeControl(Shell shell)
        {
            InitializeComponent();
            _shell = shell;
            this.IndexerContent.Content = new SelectionControl(this);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _shell.Content = new HomeScreenControl(_shell);
        }
    }
}

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

namespace _4_02_WPF.View
{
    /// <summary>
    /// Interaktionslogik für DemoView.xaml
    /// </summary>
    
    public partial class DemoView : Window
    {
        int schuelerCount = 1;
        public DemoView()
        {
            InitializeComponent();

            foreach(FontFamily font in Fonts.SystemFontFamilies)
            {
                TextBlock tb = new TextBlock();
                tb.FontFamily = font;
                tb.Text = font.ToString();
                this.AllFontsComboBox.Items.Add(tb);
            }
        }
        
        private void FillTree(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = "New Tree Item";
            Root.Items.Add(item);
        }

        private void DeleteTreeItems(object sender, RoutedEventArgs e)
        {
            Root.Items.Clear();
        }

        private void FillListBox(object sender, RoutedEventArgs e) {
            StackPanel stackPanel = new StackPanel();
            Image image = new Image();
            TextBlock textBlock = new TextBlock();

            image.Source = new BitmapImage(new Uri("/View/imposter.png", UriKind.RelativeOrAbsolute));
            textBlock.Text = "Mogus " + schuelerCount;
            schuelerCount++;

            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(image);
            stackPanel.Children.Add(textBlock);
            SchuelerListBox.Items.Add(stackPanel);
        }

        private void DeleteListBoxItems(object sender, RoutedEventArgs e)
        {
            SchuelerListBox.Items.Clear();
            schuelerCount = 1;
        }
    }
}

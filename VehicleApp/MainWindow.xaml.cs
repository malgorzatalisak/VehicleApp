using System.Collections.Generic;
using System.Windows;

namespace VehicleApp
{
    public partial class MainWindow : Window
    {
        private List<Category> categories;

        public MainWindow()
        {
            InitializeComponent();
            categories = DataLoader.LoadData("Resources/data.xml");
            CategoryListBox.ItemsSource = categories;
        }

        private void CategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CategoryListBox.SelectedItem != null)
            {
                var selectedCategory = (Category)CategoryListBox.SelectedItem;
                CategoryWindow categoryWindow = new CategoryWindow(selectedCategory);
                categoryWindow.Show();
            }
        }
    }
}

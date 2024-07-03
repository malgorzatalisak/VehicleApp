using System.Windows;

namespace VehicleApp
{
    public partial class CategoryWindow : Window
    {
        private Category category;

        public CategoryWindow(Category category)
        {
            InitializeComponent();
            this.category = category;
            CategoryDescription.Text = category.Description;
            SubCategoryListBox.ItemsSource = category.SubCategories;
        }

        private void SubCategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (SubCategoryListBox.SelectedItem != null)
            {
                var selectedSubCategory = (SubCategory)SubCategoryListBox.SelectedItem;
                SubCategoryWindow subCategoryWindow = new SubCategoryWindow(selectedSubCategory);
                subCategoryWindow.Show();
            }
        }
    }
}

using System.Windows;

namespace VehicleApp
{
    public partial class SubCategoryWindow : Window
    {
        private SubCategory subCategory;

        public SubCategoryWindow(SubCategory subCategory)
        {
            InitializeComponent();
            this.subCategory = subCategory;
            SubCategoryDetails.Text = $"Opis: {subCategory.Description}\nKraj: {subCategory.Country}\nData założenia: {subCategory.Founded}";
            ModelsDataGrid.ItemsSource = subCategory.Models;
        }
    }
}

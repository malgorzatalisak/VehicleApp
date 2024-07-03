using System.Collections.Generic;

public class Category
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<SubCategory> SubCategories { get; set; }
}

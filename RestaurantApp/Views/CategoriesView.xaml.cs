using RestaurantApp.Models;

namespace RestaurantApp.Views;

public partial class CategoriesView : ContentPage
{
	
	public List<CategoryModel> CategoriesList { get; set; }
	public CategoriesView()
	{
		InitializeComponent();

        this.CategoriesList = new List<CategoryModel>()
        {
            new CategoryModel()
            {
                CategoryName="Food Category",
                Foods=new List<FoodModel>()
                {
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_1.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_2.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_3.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_4.jpg"
                    }
                }
            },
            new CategoryModel()
            {
                CategoryName="Food Category",
                Foods=new List<FoodModel>()
                {
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_5.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_6.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_7.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_8.jpg"
                    }
                }
            },
            new CategoryModel()
            {
                CategoryName="Food Category",
                Foods=new List<FoodModel>()
                {
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_9.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_10.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_11.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_12.jpg"
                    }
                }
            },
            new CategoryModel()
            {
                CategoryName="Food Category",
                Foods=new List<FoodModel>()
                {
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_5.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_2.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_9.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="",
                        FoodPrice=300,
                        ImagePath="image_11.jpg"
                    }
                }
            }
        };

        this.BindingContext = this;
	}
}
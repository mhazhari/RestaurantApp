using RestaurantApp.Models;

namespace RestaurantApp.Views;

public partial class SearchView : ContentPage
{

	public List<FoodModel> FoodsList { get; set; }
	public SearchView()
	{
		InitializeComponent();

        this.FoodsList = new List<FoodModel>()
                {
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_1.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_2.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_3.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_4.jpg",
                        IsFavorite=true
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_5.jpg"
                    },
                    new FoodModel()
                    {
                        FoodName="Food Name",
                        FoodDescription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        FoodPrice=300,
                        ImagePath="image_6.jpg"
                    }
                };

        this.BindingContext = this;

    }
}
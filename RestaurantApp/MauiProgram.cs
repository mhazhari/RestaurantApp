namespace RestaurantApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

				fonts.AddFont("BeVietnamProBlack.ttf", "BeVietnamProBlack");
                fonts.AddFont("BeVietnamProBold.ttf", "BeVietnamProBold");
                fonts.AddFont("BeVietnamProExtraBold.ttf", "BeVietnamProExtraBold");
                fonts.AddFont("BeVietnamProMedium.ttf", "BeVietnamProMedium");
                fonts.AddFont("BeVietnamProLight.ttf", "BeVietnamProLight");
            });

		return builder.Build();
	}
}

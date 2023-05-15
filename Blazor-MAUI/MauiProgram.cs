using Microsoft.AspNetCore.Components.WebView.Maui;
using FitnessTracker.Data;
using Syncfusion.Blazor;

namespace FitnessTracker;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		builder.Services.AddScoped<FitnessService>();
        builder.Services.AddSyncfusionBlazor();

        return builder.Build();
	}
}

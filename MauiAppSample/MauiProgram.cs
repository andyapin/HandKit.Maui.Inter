using Microsoft.Extensions.Logging;
using Oryn.Maui.Font.Inter;

namespace MauiAppSample
{
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
                    fonts.AddInterFonts(); // <-- add this if using this font to global.
                    // using: FontFamily="Regular" (Italic, Medium, SemiBold, Bold, etc..)

                    // fonts.AddInterFontsPartial(); // <-- add this if using this font as partial.
                    // using: FontFamily="InterRegular" (InterItalic, InterMedium, InterSemiBold, InterBold, etc..)
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

namespace HandKit.Maui.Inter;

/// <summary>
/// Provides extension methods for adding Inter fonts to an IFontCollection.
/// </summary>
public static class FontExtensions
{
    /// <summary>
    /// Registers the Inter fonts in the MAUI application.
    /// <code>
    /// Font Family: Regular, Italic, Medium, SemiBold, Bold, MediumItalic, SemiBoldItalic, BoldItalic
    /// </code>
    /// </summary>
    /// <param name="builder">The <see cref="MauiAppBuilder"/> to configure.</param>
    /// <param name="name">Optional alias prefix. If provided (e.g., "Inter"), use FontFamily="InterRegular". If empty, use FontFamily="Regular".</param>
    /// <returns><see cref="MauiAppBuilder"/></returns>
    public static MauiAppBuilder UseInterFonts(this MauiAppBuilder builder, string name = "")
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("InterRegular.ttf", $"{name}Regular");
            fonts.AddFont("InterItalic.ttf", $"{name}Italic");
            fonts.AddFont("InterMedium.ttf", $"{name}Medium");
            fonts.AddFont("InterMediumItalic.ttf", $"{name}MediumItalic");
            fonts.AddFont("InterSemiBold.ttf", $"{name}SemiBold");
            fonts.AddFont("InterSemiBoldItalic.ttf", $"{name}SemiBoldItalic");
            fonts.AddFont("InterBold.ttf", $"{name}Bold");
            fonts.AddFont("InterBoldItalic.ttf", $"{name}BoldItalic");
        });
        return builder;
    }
}

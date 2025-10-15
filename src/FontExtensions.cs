namespace Oryn.Maui.Font.Inter;

/// <summary>
/// Provides extension methods for adding Inter fonts to an IFontCollection.
/// </summary>
public static class FontExtensions
{
    /// <summary>
    /// Add font to global. 
    /// <para>
    /// using: FontFamily="Regular"<br/>(Italic, Medium, SemiBold, Bold, etc..)
    /// </para>
    /// </summary>
    /// <param name="fonts">The IFontCollection to add the fonts to.</param>
    /// <returns>The updated IFontCollection.</returns>
    public static IFontCollection AddInterFonts(this IFontCollection fonts)
    {
        fonts.AddFont("Inter-Regular.ttf", FontAliases.InterRegular);
        fonts.AddFont("Inter-Italic.ttf", FontAliases.InterItalic);
        fonts.AddFont("Inter-Medium.ttf", FontAliases.InterMedium);
        fonts.AddFont("Inter-MediumItalic.ttf", FontAliases.InterMediumItalic);
        fonts.AddFont("Inter-SemiBold.ttf", FontAliases.InterSemiBold);
        fonts.AddFont("Inter-SemiBoldItalic.ttf", FontAliases.InterSemiBoldItalic);
        fonts.AddFont("Inter-Bold.ttf", FontAliases.InterBold);
        fonts.AddFont("Inter-BoldItalic.ttf", FontAliases.InterBoldItalic);
        return fonts;
    }

    /// <summary>
    /// Add font to partial. 
    /// <para>
    /// using: FontFamily="InterRegular"<br/>(InterItalic, InterMedium, InterSemiBold, InterBold, etc..)
    /// </para>
    /// </summary>
    /// <param name="fonts">The IFontCollection to add the fonts to.</param>
    /// <returns>The updated IFontCollection.</returns>
    public static IFontCollection AddInterFontsPartial(this IFontCollection fonts)
    {
        fonts.AddFont("Inter-Regular.ttf", nameof(FontAliases.InterRegular));
        fonts.AddFont("Inter-Italic.ttf", nameof(FontAliases.InterItalic));
        fonts.AddFont("Inter-Medium.ttf", nameof(FontAliases.InterMedium));
        fonts.AddFont("Inter-MediumItalic.ttf", nameof(FontAliases.InterMediumItalic));
        fonts.AddFont("Inter-SemiBold.ttf", nameof(FontAliases.InterSemiBold));
        fonts.AddFont("Inter-SemiBoldItalic.ttf", nameof(FontAliases.InterSemiBoldItalic));
        fonts.AddFont("Inter-Bold.ttf", nameof(FontAliases.InterBold));
        fonts.AddFont("Inter-BoldItalic.ttf", nameof(FontAliases.InterBoldItalic));
        return fonts;
    }
}

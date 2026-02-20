# HandKit.Maui.Inter

![icon](https://handityo.my.id/icon_nuget.png)

![NuGet Version](https://img.shields.io/nuget/v/HandKit.Maui.Inter)
![License](https://img.shields.io/github/license/andyapin/HandKit.Maui.Inter)
![Platform](https://img.shields.io/badge/Platform-MAUI-512BD4)

**Effortlessly integrate the Inter font family into your .NET MAUI applications.**

Inter is a typeface carefully crafted & designed for computer screens. It features a tall x-height to aid in readability of mixed-case and lower-case text.

This library simplifies the process of including the Inter font family in your .NET MAUI apps, providing pre-configured font aliases and automatic resource inclusion.

## Features

- **Easy Integration**: Add Inter fonts with a single line of code.
- **Multiple Weights**: Includes Regular, Medium, SemiBold, and Bold weights.
- **Italic Styles**: Includes Italic variants for all supported weights.
- **Customizable Alias**: Option to prefix font aliases to avoid conflicts.
- **Cross-Platform**: Works on Android, iOS, macOS, and Windows.

## Installation

Install the package via NuGet:

```bash
dotnet add package HandKit.Maui.Inter
```

Or via the Package Manager Console:

```powershell
Install-Package HandKit.Maui.Inter
```

## Usage

### 1. Initialize the Plugin

In your `MauiProgram.cs`, add the `UseInterFonts` method to your `MauiAppBuilder`:

```csharp
using HandKit.Maui.Inter; // Add this namespace

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseInterFonts(); // Registers the fonts with default aliases

        return builder.Build();
    }
}
```

### 2. Use Fonts in XAML

By default, the fonts are registered with the following aliases:

- `Regular`
- `Italic`
- `Medium`
- `MediumItalic`
- `SemiBold`
- `SemiBoldItalic`
- `Bold`
- `BoldItalic`

Example usage in XAML:

```xml
<StackLayout Spacing="10" Padding="20">
    <Label Text="Regular Text (Inter)" FontFamily="Regular" FontSize="16"/>
    
    <Label Text="Medium Text (Inter)" FontFamily="Medium" FontSize="16"/>
    
    <Label Text="SemiBold Text (Inter)" FontFamily="SemiBold" FontSize="16"/>
    
    <Label Text="Bold Text (Inter)" FontFamily="Bold" FontSize="16"/>
    
    <Label Text="Italic Text (Inter)" FontFamily="Italic" FontSize="16"/>
</StackLayout>
```

### Advanced Usage: Custom Alias Prefix

If you have meaningful font name conflicts (e.g., you already have a font aliased as "Regular"), you can provide a custom prefix:

```csharp
// In MauiProgram.cs
builder.UseInterFonts("Inter"); 
```

This will change the registered aliases to:

- `InterRegular`
- `InterItalic`
- `InterMedium`
- ...and so on.

Updated usage in XAML:

```xml
<Label Text="Hello Inter!" FontFamily="InterRegular" />
<Label Text="Bold Inter!" FontFamily="InterBold" />
```

## Included Fonts

The package includes the following font files from the Inter family:

- **Regular**: `Inter-Regular.ttf`
- **Italic**: `Inter-Italic.ttf`
- **Medium**: `Inter-Medium.ttf`
- **Medium Italic**: `Inter-MediumItalic.ttf`
- **SemiBold**: `Inter-SemiBold.ttf`
- **SemiBold Italic**: `Inter-SemiBoldItalic.ttf`
- **Bold**: `Inter-Bold.ttf`
- **Bold Italic**: `Inter-BoldItalic.ttf`

## License

This project is licensed under the MIT License.

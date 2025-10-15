
# Oryn.Maui.Font.Inter

![icon](https://handityo.my.id/icon_nuget.png)

[![NuGet](https://img.shields.io/nuget/v/Oryn.Maui.Font.Inter)](https://www.nuget.org/packages/Oryn.Maui.Font.Inter)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?style=flat&logo=dotnet&label=.NET%20MAUI)](https://dotnet.microsoft.com/en-us/apps/maui)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Platform](https://img.shields.io/badge/Platform-Android-green)](https://www.android.com/)
[![Platform](https://img.shields.io/badge/Platform-iOS-blue)](https://www.apple.com/ios/ios-16/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D7)](https://www.microsoft.com/en-us/windows)
[![Platform](https://img.shields.io/badge/Platform-macOS-00203a)](https://www.apple.com/macos/)

**Effortlessly integrate the Inter font family into your .NET MAUI applications.** 

Inter, a popular geometric sans-serif typeface, offers a clean and modern aesthetic, supporting a wide range of languages.

This plugin simplifies the process of including the Inter font family in your .NET MAUI apps, eliminating the need for manual font embedding and registration. It provides pre-configured font resources that can be easily accessed and applied to your UI elements.

## Key Features

*   Easy integration with .NET MAUI projects.
*   Includes various weights and styles of the Inter font (e.g., Regular, Bold, Italic, etc.).
*   Optimized for performance in mobile and desktop environments.
*   Cross-platform compatibility (iOS, Android, Windows, macOS).
*   Example project demonstrating usage.

## Installation

You can install the plugin via NuGet:

```bash
Install-Package Oryn.Maui.Font.Inter
```

## Usage

1.  **Register the font:**

    In your `MauiProgram.cs` file:

    ```csharp
    using Oryn.Maui.Font.Inter;

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
	                fonts.AddInterFonts(); // <-- add this if using this font to global. using: FontFamily="Regular" (Italic, Medium, SemiBold, Bold, MediumItalic, SemiBoldItalic, BoldItalic)

     		//fonts.AddInterFontsPartial(); // <-- add this if using this font as partial. using: FontFamily="InterRegular" (InterItalic, InterMedium, InterSemiBold, InterBold, InterMediumItalic, InterSemiBoldItalic, InterBoldItalic)
                });

            return builder.Build();
        }
    }
    ```

2.  **Use the font in XAML:**

    ```xml
    <Label Text="Hello Inter!" FontFamily="Regular" />
    <Label Text="This is Bold Inter!" FontFamily="Bold" />
    ```

    Or with *Style*:

    ```xml
    <Style TargetType="Label" x:Key="InterLabelStyle">
        <Setter Property="FontFamily" Value="SemiBold"/>
    </Style>

    <Label Text="Hello Inter with style!" Style="{StaticResource InterLabelStyle}"/>
    ```

## Example Project
The repository includes a sample MAUI project demonstrating the usage of the plugin. You can find it in the `samples` directory.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.

## Contact
If you have any questions or suggestions, please feel free to contact me at andyapin@gmail.com

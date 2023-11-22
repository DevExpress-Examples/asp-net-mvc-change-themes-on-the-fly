<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566145/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3825)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# ASP.NET MVC - How to change themes on the fly
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128566145/)**
<!-- run online end -->

This example illustrates how to change themes on the fly.

## Implementation Details

To apply a theme, specify the theme and its base settings in the _Global.asax_ file:

```csharp
protected void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
    DevExpressHelper.Theme = Utils.CurrentTheme;
    DevExpressHelper.GlobalThemeBaseColor = Utils.CurrentThemeColor;
    DevExpressHelper.GlobalThemeFont = Utils.CurrentFont;
}
```

## Files to Review

* [Global.asax.cs](./CS/DxWebApp/Global.asax.cs) (VB: [Global.asax.vb](./VB/DxWebApp/Global.asax.vb))
  
## Documentation

* [Applying Themes - The DevExpress Approach](https://docs.devexpress.com/AspNetMvc/14805/common-features/appearance-customization-theming/applying-themes/applying-themes-the-devexpress-approach)

## More Examples

* [ASP.NET Web Forms - How to change themes on the fly](https://github.com/DevExpress-Examples/asp-net-web-forms-change-themes-on-the-fly)

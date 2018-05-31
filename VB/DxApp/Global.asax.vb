' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
' visit http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Http
Imports DevExpress.Web.Mvc

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)

        ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

        AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
    End Sub

    Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
        'TODO: Handle Exception
    End Sub
    Protected Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        DevExpressHelper.Theme = Utils.CurrentTheme
        DevExpressHelper.GlobalThemeBaseColor = Utils.CurrentThemeColor
        DevExpressHelper.GlobalThemeFont = Utils.CurrentFont
    End Sub
End Class
﻿Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.Internal

Public NotInheritable Class Utils

    Private Sub New()
    End Sub
    Private Const CurrentThemeCookieKey As String = "ex3825_theme", CurrentThemeColorCookieKey As String = "ex3825_themeColor", CurrentFontCookieKey As String = "ex3825_utilsFont", DefaultTheme As String = "Moderno", DefaultThemeColor As String = "Blue", DefaultFont As String = "12px 'Times New Roman'"

    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property

    Private Shared ReadOnly Property Request() As HttpRequest
        Get
            Return Context.Request
        End Get
    End Property

    Public Shared ReadOnly Property CurrentTheme() As String
        Get
            If Request.Cookies(CurrentThemeCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentThemeCookieKey).Value)
            End If
            Return DefaultTheme
        End Get
    End Property
    Public Shared ReadOnly Property CurrentThemeColor() As String
        Get
            If Request.Cookies(CurrentThemeColorCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentThemeColorCookieKey).Value)
            End If
            Return DefaultThemeColor
        End Get
    End Property
    Public Shared ReadOnly Property CurrentFont() As String
        Get
            If Request.Cookies(CurrentFontCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentFontCookieKey).Value)
            End If
            Return DefaultFont
        End Get
    End Property
End Class
Imports System.IO.Path

Public Class ContextUtils
    ''Physical Path to Virtual Directory
    'Public Shared Function GetPhysicalWebPath(ByVal myForm As Control) As String
    '    Return myForm.Context.Server.MapPath(myForm.Context.HttpContext.Request.ApplicationPath)
    'End Function

    'Public Shared Function GetPhysicalPath(ByVal myForm As Control, ByVal myFolder As String, ByVal myFilename As String) As String
    '    'Returns Physical Directory of File on Server
    '    Return Combine(Combine(GetPhysicalWebPath(myForm), myFolder), myFilename)
    'End Function

    'Public Shared Function GetPhysicalPath(ByVal myForm As Control, ByVal myURL As String) As String
    '    'Returns Physical Directory of File on Server
    '    Return Combine(GetPhysicalWebPath(myForm), myURL)
    'End Function

    'Public Shared Function GetPhysicalPath(ByVal myForm As Control, ByVal myFolder As String, ByVal myFilename As String, ByVal myCustomRootPath As String) As String
    '    'Returns Physical Directory of File on Server

    '    Dim myRootPath As String
    '    Dim myPath As String

    '    If myCustomRootPath Is Nothing Then
    '        'Use Server's Entire Physical Path
    '        myRootPath = GetPhysicalWebPath(myForm)
    '        'Build Path
    '        myPath = Combine(Combine(myRootPath, myFolder), myFilename)
    '    Else
    '        'Custom Root Path - Attempt to read from web.config (ie, required for CrystalTech medium trust)
    '        'Build Path using Server.MapPath()
    '        myPath = myForm.Context.Server.MapPath(Combine(Combine(myCustomRootPath, myFolder), myFilename))
    '    End If

    '    Return myPath
    'End Function

End Class

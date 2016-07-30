Public Class Math

    ''' <summary>
    ''' Converts the bytes into megabytes.
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <returns>Int/Long</returns>
    ''' <remarks></remarks>
    Public Shared Function BytesToMb(val As Long) As Long
        Return (val / 1024) / 1024
    End Function


    ''' <summary>
    ''' Converts the bytes into megabytes. ULong only.
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <returns>UInt/ULong</returns>
    ''' <remarks></remarks>
    Public Shared Function BytesToMbUlong(val As ULong) As ULong
        Return (val / 1024) / 1024
    End Function


    ''' <summary>
    ''' Converts the bytes into gigabytes.
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <returns>Int/Long</returns>
    ''' <remarks></remarks>
    Public Shared Function BytesToGb(val As Long) As Long
        Return (val / 1024) / 1024 / 1024
    End Function

    ''' <summary>
    ''' Converts the bytes into gigabytes. ULong only.
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <returns>UInt/ULong</returns>
    ''' <remarks></remarks>
    Public Shared Function BytesToGbUlong(val As ULong) As ULong
        Return (val / 1024) / 1024 / 1024
    End Function

    ''' <summary>
    ''' Helper function for C#, because C# is a douchbag with formatting strings
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <param name="format">The format</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Shared Function FormatLong(val As Long, format As String) As String
        Return String.Format(val, format)
    End Function

    ''' <summary>
    ''' Helper function for C#, because C# is a douchbag with formatting strings - ULong only
    ''' </summary>
    ''' <param name="val">The value</param>
    ''' <param name="format">The format</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Shared Function FormatULong(val As ULong, format As String) As String
        Return String.Format(val, format)
    End Function
End Class

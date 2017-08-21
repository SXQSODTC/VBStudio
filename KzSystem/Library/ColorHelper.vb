Public Class KzColorHelper
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="red"></param>
    ''' <param name="green"></param>
    ''' <param name="blue"></param>
    ''' <returns></returns>
    Public Shared Function CreateColorFromRGB _
        (ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer) As Color

        'Corect Red element
        Dim r As Integer = red
        If r > 255 Then
            r = 255
        End If
        If r < 0 Then
            r = 0
        End If
        'Corect Green element
        Dim g As Integer = green
        If g > 255 Then
            g = 255
        End If
        If g < 0 Then
            g = 0
        End If
        'Correct Blue Element
        Dim b As Integer = blue
        If b > 255 Then
            b = 255
        End If
        If b < 0 Then
            b = 0
        End If
        Return Color.FromArgb(r, g, b)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="blendColor"></param>
    ''' <param name="baseColor"></param>
    ''' <param name="opacity"></param>
    ''' <returns></returns>
    Public Shared Function OpacityMix _
        (ByVal blendColor As Color, ByVal baseColor As Color, ByVal opacity As Integer) As Color

        Dim r1 As Integer
        Dim g1 As Integer
        Dim b1 As Integer
        Dim r2 As Integer
        Dim g2 As Integer
        Dim b2 As Integer
        Dim r3 As Integer
        Dim g3 As Integer
        Dim b3 As Integer
        r1 = blendColor.R
        g1 = blendColor.G
        b1 = blendColor.B
        r2 = baseColor.R
        g2 = baseColor.G
        b2 = baseColor.B
        r3 = CInt(Fix(((r1 * (CSng(opacity) / 100)) + (r2 * (1 - (CSng(opacity) / 100))))))
        g3 = CInt(Fix(((g1 * (CSng(opacity) / 100)) + (g2 * (1 - (CSng(opacity) / 100))))))
        b3 = CInt(Fix(((b1 * (CSng(opacity) / 100)) + (b2 * (1 - (CSng(opacity) / 100))))))
        Return CreateColorFromRGB(r3, g3, b3)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="baseColor"></param>
    ''' <param name="blendColor"></param>
    ''' <param name="opacity"></param>
    ''' <returns></returns>
    Public Shared Function SoftLightMix _
        (ByVal baseColor As Color, ByVal blendColor As Color, ByVal opacity As Integer) As Color

        Dim r1 As Integer
        Dim g1 As Integer
        Dim b1 As Integer
        Dim r2 As Integer
        Dim g2 As Integer
        Dim b2 As Integer
        Dim r3 As Integer
        Dim g3 As Integer
        Dim b3 As Integer
        r1 = baseColor.R
        g1 = baseColor.G
        b1 = baseColor.B
        r2 = blendColor.R
        g2 = blendColor.G
        b2 = blendColor.B
        r3 = SoftLightMath(r1, r2)
        g3 = SoftLightMath(g1, g2)
        b3 = SoftLightMath(b1, b2)
        Return OpacityMix(CreateColorFromRGB(r3, g3, b3), baseColor, opacity)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="baseColor"></param>
    ''' <param name="blendColor"></param>
    ''' <param name="opacity"></param>
    ''' <returns></returns>
    Public Shared Function OverlayMix _
        (ByVal baseColor As Color, ByVal blendColor As Color, ByVal opacity As Integer) As Color

        Dim r1 As Integer
        Dim g1 As Integer
        Dim b1 As Integer
        Dim r2 As Integer
        Dim g2 As Integer
        Dim b2 As Integer
        Dim r3 As Integer
        Dim g3 As Integer
        Dim b3 As Integer
        r1 = baseColor.R
        g1 = baseColor.G
        b1 = baseColor.B
        r2 = blendColor.R
        g2 = blendColor.G
        b2 = blendColor.B
        r3 = OverlayMath(baseColor.R, blendColor.R)
        g3 = OverlayMath(baseColor.G, blendColor.G)
        b3 = OverlayMath(baseColor.B, blendColor.B)
        Return OpacityMix(CreateColorFromRGB(r3, g3, b3), baseColor, opacity)
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ibase"></param>
    ''' <param name="blend"></param>
    ''' <returns></returns>
    Private Shared Function SoftLightMath _
        (ByVal ibase As Integer, ByVal blend As Integer) As Integer

        Dim dbase As Single
        Dim dblend As Single
        dbase = CSng(ibase) / 255
        dblend = CSng(blend) / 255
        If dblend < 0.5 Then
            Return CInt(Fix(((2 * dbase * dblend) + (Math.Pow(dbase, 2)) * (1 - (2 * dblend))) * 255))
        Else
            Return CInt(Fix(((Math.Sqrt(dbase) * (2 * dblend - 1)) + ((2 * dbase) * (1 - dblend))) * 255))
        End If
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ibase"></param>
    ''' <param name="blend"></param>
    ''' <returns></returns>
    Public Shared Function OverlayMath _
        (ByVal ibase As Integer, ByVal blend As Integer) As Integer

        Dim dbase As Double
        Dim dblend As Double
        dbase = CDbl(ibase) / 255
        dblend = CDbl(blend) / 255
        If dbase < 0.5 Then
            Return CInt(Fix((2 * dbase * dblend) * 255))
        Else
            Return CInt(Fix((1 - (2 * (1 - dbase) * (1 - dblend))) * 255))
        End If
    End Function

    ''' <summary>
    ''' Return a color name in KnownColorName else in Hex string.
    ''' </summary>
    ''' <param name="color"></param>
    ''' <returns></returns>
    Public Shared Function GetColorName(color As Color) As String
        If color.IsEmpty Then
            Return "[Empty]"
        ElseIf color.IsKnownColor Then
            Return color.Name
        Else
            Return ("&H" & Hex(color.ToArgb)).ToUpper
        End If
    End Function

    ''' <summary>
    ''' Return a color by name string both a KnownColorName and a Hex string.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Shared Function GetColorByName(ByVal name As String) As Color
        Try
            If name.StartsWith("&H") Then
                Return Color.FromArgb(name)
            Else
                Return Color.FromName(name)
            End If
        Catch ex As Exception
            Return Color.FromArgb(0)
        End Try
    End Function

    Public Shared Function GetColorDescription(color As Color, Optional byHex As Boolean = True) As String
        If color.IsSystemColor Then
            Return "SystemColors." & color.Name
        ElseIf color.IsKnownColor Then
            Return "Color." & color.Name
        Else
            If byHex Then
                Return "Color.FromARGB(&H" & Hex(color.ToArgb) & ")"
            Else
                Return "Color.FromARGB(" & color.ToArgb & ")"
            End If
        End If
    End Function

    Public Shared Function Add _
    (ByVal color1 As Color, ByVal color2 As Color,
     ByVal Optional plus As Boolean = True) As Color

        Dim a, r, g, b As Byte

        If plus Then
            a = Math.Min(255, color1.A + color2.A)
            r = Math.Min(255, color1.R + color2.R)
            g = Math.Min(255, color1.G + color2.G)
            b = Math.Min(255, color1.B + color2.B)
        Else
            a = Math.Max(0, CType(color1.A, Short) - CType(color2.A, Short))
            r = Math.Max(0, CType(color1.R, Short) - CType(color2.R, Short))
            g = Math.Max(0, CType(color1.G, Short) - CType(color2.G, Short))
            b = Math.Max(0, CType(color1.B, Short) - CType(color2.B, Short))
        End If

        Return Color.FromArgb(a, r, g, b)
    End Function

    Public Shared Function ReChannel _
        (ByVal color As Color, ByVal argb As Char, ByVal value As Byte,
         ByVal Optional updown As Boolean = False) As Color

        Dim a, r, g, b As Byte
        a = color.A
        r = color.R
        g = color.G
        b = color.B

        Select Case argb
            Case "a" : a = If(updown, Math.Max(0, Math.Min(255, color.A + value)), value)
            Case "r" : r = If(updown, Math.Max(0, Math.Min(255, color.R + value)), value)
            Case "g" : g = If(updown, Math.Max(0, Math.Min(255, color.G + value)), value)
            Case "b" : b = If(updown, Math.Max(0, Math.Min(255, color.B + value)), value)
            Case Else
        End Select

        Return Color.FromArgb(a, r, g, b)
    End Function
End Class


Public Structure KzColor
    Public Shared ReadOnly Property StonewareRed As Color '紫砂紅
        Get
            Return Color.FromArgb(&HFFA50017) '255,165,0,23
        End Get
    End Property

    Public Shared ReadOnly Property ChromeYellow As Color
        Get
            Return Color.FromArgb(255, 253, 208, 0)
        End Get
    End Property
End Structure 'KzColor

''' <summary>
''' Provides methods to convert from a color space to an other.
''' </summary>
Public NotInheritable Class ColorConvert

    Private Sub New()
        '
    End Sub

#Region "Color processing"

    ''' <summary>
    ''' Gets the given color based on a color and an alpha.
    ''' </summary>
    ''' <param name="c">Color applying the alpha channel.</param>
    ''' <param name="alpha">Alpha channel value.</param>
    Public Shared Function GetAlphaColor(ByVal c As Color, ByVal alpha As Integer) As Color

        If (c <> Color.Transparent And (alpha > -1 And alpha < 256)) Then
            Return Color.FromArgb(alpha, c)
        End If

        Return Color.Empty

    End Function


    ''' <summary>
    ''' Blends two colors.
    ''' </summary>
    ''' <param name="c1">First color to blend</param>
    ''' <param name="c2">Second color to blend</param>
    ''' <param name="ratio">Blend ratio. 0.5 will give even blend, 1.0 will return color1, 0.0 will return color2 and so on.</param>
    Public Shared Function GetBlendColor(ByVal c1 As Color, ByVal c2 As Color, ByVal ratio As Double) As Color

        Dim r As Single = CSng(ratio)
        Dim ir As Single = 1.0F - r

        Dim rgb1() As Single = {CSng(c1.R) / 255.0F,
                                CSng(c1.G) / 255.0F,
                                CSng(c1.B) / 255.0F}

        Dim rgb2() As Single = {CSng(c2.R) / 255.0F,
                                CSng(c2.G) / 255.0F,
                                CSng(c2.B) / 255.0F}

        Return Color.FromArgb(CInt(rgb1(0) * r + rgb2(0) * ir),
                              CInt(rgb1(1) * r + rgb2(1) * ir),
                              CInt(rgb1(2) * r + rgb2(2) * ir))

    End Function


    ''' <summary>
    ''' Makes an even blend between two colors.
    ''' </summary>
    ''' <param name="c1">First color to blend</param>
    ''' <param name="c2">Second color to blend</param>
    Public Shared Function GetBlendColor(ByVal c1 As Color, ByVal c2 As Color) As Color
        Return GetBlendColor(c1, c2, 0.5)
    End Function

    ''' <summary>
    ''' Gets the "distance" between two colors.
    ''' RGB colors must be normalized (eg. values in [0.0, 1.0]).
    ''' </summary>
    ''' <param name="r1">First color red component.</param>
    ''' <param name="g1">First color green component.</param>
    ''' <param name="b1">First color blue component.</param>
    ''' <param name="r2">Second color red component.</param>
    ''' <param name="g2">Second color green component.</param>
    ''' <param name="b2">Second color blue component.</param>
    Public Shared Function GetColorDistance(ByVal r1 As Double, ByVal g1 As Double, ByVal b1 As Double, ByVal r2 As Double, ByVal g2 As Double, ByVal b2 As Double) As Double

        Dim a As Double = r2 - r1
        Dim b As Double = g2 - g1
        Dim c As Double = b2 - b1

        Return Math.Sqrt(a * a + b * b + c * c)

    End Function

    ''' <summary>
    ''' Gets the "distance" between two colors.
    ''' RGB colors must be normalized (eg. values in [0.0, 1.0]).
    ''' </summary>
    ''' <param name="color1">First color [r,g,b]</param>
    ''' <param name="color2">Second color [r,g,b]</param>
    Public Shared Function GetColorDistance(ByVal color1() As Double, ByVal color2() As Double) As Double
        Return GetColorDistance(color1(0), color1(1), color1(2), color2(0), color2(1), color2(2))
    End Function

    ''' <summary>
    ''' Gets the "distance" between two colors.
    ''' </summary>
    ''' <param name="color1">First color.</param>
    ''' <param name="color2">Second color.</param>
    Public Shared Function GetColorDistance(ByVal color1 As Color, ByVal color2 As Color) As Double

        Dim rgb1() As Double = {CDbl(color1.R) / 255.0F,
                                CDbl(color1.G) / 255.0F,
                                CDbl(color1.B) / 255.0F}

        Dim rgb2() As Double = {CDbl(color2.R) / 255.0F,
                                CDbl(color2.G) / 255.0F,
                                CDbl(color2.B) / 255.0F}

        Return GetColorDistance(rgb1, rgb2)

    End Function


#End Region

#Region "Light Spectrum processing"

    ''' <summary>
    ''' Gets visible colors (color wheel).
    ''' </summary>
    ''' <param name="alpha">
    ''' The alpha value used for each colors.
    ''' </param>
    Public Shared Function GetWheelColors(ByVal alpha As Integer) As Color()

        Dim temp As Color
        Dim colorCount As Integer = 6 * 256
        Dim Colors(colorCount) As Color

        For i As Integer = 0 To colorCount - 1
            temp = HSBtoColor((CDbl(i) * 255.0) / CDbl(colorCount), 255.0, 255.0)
            Colors(i) = Color.FromArgb(alpha, temp.R, temp.G, temp.B)
        Next

        Return Colors

    End Function

    ''' <summary>
    ''' Gets visible spectrum colors.
    ''' </summary>
    ''' <param name="alpha">The alpha value used for each colors.</param>
    Public Shared Function GetSpectrumColors(ByVal alpha As Integer) As Color()

        Dim Colors(256 * 6) As Color

        For i As Integer = 0 To 255
            Colors(i) = Color.FromArgb(alpha, 255, i, 0)
            Colors(i + 256) = Color.FromArgb(alpha, 255 - i, 255, 0)
            Colors(i + 256 * 2) = Color.FromArgb(alpha, 0, 255, i)
            Colors(i + 256 * 3) = Color.FromArgb(alpha, 0, 255 - i, 255)
            Colors(i + 256 * 4) = Color.FromArgb(alpha, i, 0, 255)
            Colors(i + 256 * 5) = Color.FromArgb(alpha, 255, 0, 255 - i)
        Next

        Return Colors

    End Function

    ''' <summary>
    ''' Gets visible spectrum colors.
    ''' </summary>
    Public Shared Function GetSpectrumColors() As Color()
        Return GetSpectrumColors(255)
    End Function

#End Region

#Region "Hex Color Conversion"

    ''' <summary>
    ''' Converts a Hex color to a .net Color.
    ''' </summary>
    ''' <param name="hexColor">The desired hexadecimal color to convert.</param>
    Public Shared Function HEXtoColor(ByVal hexColor As String) As Color

        If hexColor Is String.Empty Then Return Color.Empty

        hexColor = hexColor.Trim

        If hexColor.Chars(0) = "#" Then hexColor = hexColor.Substring(1)
        If hexColor.Length < 6 Then hexColor = "000000".Substring(0, 6 - hexColor.Length) + hexColor

        Return Color.FromArgb(CInt("&h" + hexColor.Substring(0, 2)),
                              CInt("&h" + hexColor.Substring(2, 2)),
                              CInt("&h" + hexColor.Substring(4, 2)))

    End Function

    ''' <summary>
    ''' Converts a RGB color format to an hexadecimal color.
    ''' </summary>
    ''' <param name="r">The Red value.</param>
    ''' <param name="g">The Green value.</param>
    ''' <param name="b">The Blue value.</param>
    Public Shared Function RGBtoHEX(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As String
        Return String.Format("#{0:x2}{1:x2}{2:x2}", r, g, b).ToUpper
    End Function

    ''' <summary>
    ''' Converts a .Net Color format to an hexadecimal color.
    ''' </summary>
    ''' <param name="c">The .net color to convert.</param>
    Public Shared Function ColorToHEX(ByVal c As Color) As String
        Return RGBtoHEX(c.R, c.G, c.B)
    End Function

#End Region

#Region "HSB Convert"

#Region "HSBtoRGB"

    ''' <summary>
    ''' Converts HSB to RGB.
    ''' </summary>
    ''' <param name="hsb">The HSB structure to convert.</param>
    Public Shared Function HSBtoRGB(ByVal HSB As HSB) As RGB
        Return HSBtoRGB(HSB.Hue, HSB.Saturation, HSB.Brightness)
    End Function

    ''' <summary>
    ''' Converts HSB to RGB.
    ''' </summary>
    ''' <param name="H">Hue value. (must be between 0 and 360)</param>
    ''' <param name="S">Saturation value (must be between 0 and 100).</param>
    ''' <param name="b">Brigthness value (must be between 0 and 100).</param>
    Public Shared Function HSBtoRGB(ByVal h As Integer, ByVal s As Integer, ByVal b As Integer) As RGB
        Return HSBtoRGB(CDbl(h), CDbl(s / 100.0), CDbl(b / 100.0))
    End Function

    ''' <summary> 
    ''' Converts HSB to a RGB.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="b">Brightness value (must be between 0 and 1).</param>
    Public Shared Function HSBtoRGB(ByVal h As Double, ByVal s As Double, ByVal b As Double) As RGB

        Dim red As Double = 0.0
        Dim green As Double = 0.0
        Dim blue As Double = 0.0

        If (s = 0) Then

            red = b
            green = b
            blue = b

        Else

            ' the color wheel consists of 6 sectors. Figure out which sector you're in.
            Dim sectorPos As Double = h / 60.0
            Dim sectorNumber As Integer = CInt(Math.Floor(sectorPos))
            ' get the fractional part of the sector
            Dim fractionalSector As Double = sectorPos - sectorNumber

            ' calculate values for the three axes of the color. 
            Dim p As Double = b * (1.0 - s)
            Dim q As Double = b * (1.0 - (s * fractionalSector))
            Dim t As Double = b * (1.0 - (s * (1 - fractionalSector)))

            ' assign the fractional colors to r, g, and b based on the sector the angle is in.
            Select Case sectorNumber
                Case 0
                    red = b
                    green = t
                    blue = p
                Case 1
                    red = q
                    green = b
                    blue = p
                Case 2
                    red = p
                    green = b
                    blue = t
                Case 3
                    red = p
                    green = q
                    blue = b
                Case 4
                    red = t
                    green = p
                    blue = b
                Case 5
                    red = b
                    green = p
                    blue = q
            End Select

        End If

        'Return New RGB(cint((Math.Ceiling(T(0) * 255.0)), _
        '               cint((Math.Ceiling(T(1) * 255.0)), _
        '               cint((Math.Ceiling(T(2) * 255.0)))

        Return New RGB(CInt(Double.Parse(String.Format("{0:0.00}", red * 255.0))),
                       CInt(Double.Parse(String.Format("{0:0.00}", green * 255.0))),
                       CInt(Double.Parse(String.Format("{0:0.00}", blue * 255.0))))


    End Function

#End Region

#Region "HSBtoColor"

    ''' <summary>
    ''' Converts HSB to .Net Color.
    ''' </summary>
    ''' <param name="hsb">the HSB structure to convert.</param>
    Public Shared Function HSBtoColor(ByVal HSB As HSB) As Color
        Return HSBtoColor(HSB.Hue, HSB.Saturation, HSB.Brightness)
    End Function

    ''' <summary> 
    ''' Converts HSB to a .Net Color.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="b">Brightness value (must be between 0 and 1).</param>
    Public Shared Function HSBtoColor(ByVal h As Double, ByVal s As Double, ByVal b As Double) As Color
        Dim rgb As RGB = HSBtoRGB(h, s, b)
        Return Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)
    End Function

#End Region

#End Region

#Region "HSL Convert"

#Region "HSLtoRGB"
    ''' <summary>
    ''' Converts HSL to RGB.
    ''' </summary>
    ''' <param name="hsl">The HSL structure to convert.</param>
    Public Shared Function HSLtoRGB(ByVal hsl As HSL) As RGB
        Return HSLtoRGB(hsl.Hue, hsl.Saturation, hsl.Luminance)
    End Function

    ''' <summary>
    ''' Converts HSL to RGB.
    ''' </summary>
    ''' <param name="H">Hue value. (must be between 0 and 360)</param>
    ''' <param name="S">Saturation value (must be between 0 and 100).</param>
    ''' <param name="L">Luminance value (must be between 0 and 100).</param>
    Public Shared Function HSLtoRGB(ByVal h As Integer, ByVal s As Integer, ByVal l As Integer) As RGB
        Return HSLtoRGB(CDbl(h), CDbl(s / 100.0), CDbl(l / 100.0))
    End Function

    ''' <summary> 
    ''' Converts HSL to a .net Color.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="l">Luminance value (must be between 0 and 1).</param>
    Public Shared Function HSLtoRGB(ByVal h As Double, ByVal s As Double, ByVal l As Double) As RGB

        If (s = 0) Then

            ' achromatic color (gray scale)
            Return New RGB(CInt(Double.Parse(String.Format("{0:0.00}", l * 255.0))),
                           CInt(Double.Parse(String.Format("{0:0.00}", l * 255.0))),
                           CInt(Double.Parse(String.Format("{0:0.00}", l * 255.0))))

        Else

            Dim q As Double
            If l < 0.5 Then
                q = l * (1.0 + s)
            Else
                q = l + s - (l * s)
            End If

            Dim p As Double = (2.0 * l) - q

            Dim Hk As Double = h / 360.0
            Dim T(2) As Double
            T(0) = Hk + (1.0 / 3.0) ' Tr
            T(1) = Hk               ' Tb
            T(2) = Hk - (1.0 / 3.0) ' Tg

            For i As Integer = 0 To 2
                If (T(i) < 0) Then T(i) += 1.0
                If (T(i) > 1) Then T(i) -= 1.0

                If ((T(i) * 6) < 1) Then
                    T(i) = p + ((q - p) * 6.0 * T(i))
                ElseIf ((T(i) * 2.0) < 1) Then
                    T(i) = q
                ElseIf ((T(i) * 3.0) < 2) Then
                    T(i) = p + (q - p) * ((2.0 / 3.0) - T(i)) * 6.0
                Else
                    T(i) = p
                End If
            Next

            'Return New RGB(cint(Math.Ceiling(T(0) * 255.0)), _
            '               cint(Math.Ceiling(T(1) * 255.0)), _
            '               cint(Math.Ceiling(T(2) * 255.0)))

            Return New RGB(CInt(Double.Parse(String.Format("{0:0.00}", T(0) * 255.0))),
                           CInt(Double.Parse(String.Format("{0:0.00}", T(1) * 255.0))),
                           CInt(Double.Parse(String.Format("{0:0.00}", T(2) * 255.0))))

        End If

    End Function

#End Region

#Region "HSLtoColor"

    ''' <summary>
    ''' Converts HSL to .net Color.
    ''' </summary>
    ''' <param name="hsl">The HSL structure to convert.</param>
    Public Shared Function HSLtoColor(ByVal hsl As HSL) As Color
        Return HSLtoColor(hsl.Hue, hsl.Saturation, hsl.Luminance)
    End Function

    ''' <summary>
    ''' Converts HSL to .net Color.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="l">Luminance value (must be between 0 and 1).</param>
    Public Shared Function HSLtoColor(ByVal h As Double, ByVal s As Double, ByVal l As Double) As Color
        Dim rgb As RGB = HSLtoRGB(h, s, l)
        Return Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)
    End Function

#End Region

#End Region

#Region "RGB Convert"

#Region "RGBtoHSB"

    ''' <summary> 
    ''' Converts .Net Color to HSB.
    ''' </summary> 
    Public Shared Function RGBtoHSB(ByVal c As Color) As HSB
        Return RGBtoHSB(c.R, c.G, c.B)
    End Function

    ''' <summary> 
    ''' Converts RGB to HSB.
    ''' </summary> 
    Public Shared Function RGBtoHSB(ByVal rgb As RGB) As HSB
        Return RGBtoHSB(rgb.Red, rgb.Green, rgb.Blue)
    End Function

    ''' <summary> 
    ''' Converts RGB to HSB.
    ''' </summary> 
    Public Shared Function RGBtoHSB(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer) As HSB

        Dim h As Double = 0.0
        Dim s As Double = 0.0

        ' normalizes red-green-blue values
        Dim nRed As Double = CDbl(red) / 255.0
        Dim nGreen As Double = CDbl(green) / 255.0
        Dim nBlue As Double = CDbl(blue) / 255.0

        Dim max As Double = Math.Max(nRed, Math.Max(nGreen, nBlue))
        Dim min As Double = Math.Min(nRed, Math.Min(nGreen, nBlue))

        ' Hue
        If (max = nRed) And (nGreen >= nBlue) Then
            If (max - min = 0) Then
                h = 0.0
            Else
                h = 60 * (nGreen - nBlue) / (max - min)
            End If
        ElseIf (max = nRed) And (nGreen < nBlue) Then
            h = 60 * (nGreen - nBlue) / (max - min) + 360
        ElseIf (max = nGreen) Then
            h = 60 * (nBlue - nRed) / (max - min) + 120
        ElseIf (max = nBlue) Then
            h = 60 * (nRed - nGreen) / (max - min) + 240
        End If

        ' Saturation
        If (max = 0) Then
            s = 0.0
        Else
            s = 1.0 - (min / max)
        End If

        Return New HSB(h, s, max)

    End Function

#End Region

#Region "RGBtoHSL"

    ''' <summary> 
    ''' Converts .Net Color to HSL.
    ''' </summary>
    Public Shared Function RGBtoHSL(ByVal c As Color) As HSL
        Return RGBtoHSL(c.R, c.G, c.B)
    End Function

    ''' <summary> 
    ''' Converts RGB to HSL.
    ''' </summary>
    Public Shared Function RGBtoHSL(ByVal rgb As RGB) As HSL
        Return RGBtoHSL(rgb.Red, rgb.Green, rgb.Blue)
    End Function

    ''' <summary> 
    ''' Converts RGB to HSL.
    ''' </summary>
    ''' <param name="red">Red value (must be between 0 and 255).</param>
    ''' <param name="green">Green value (must be between 0 and 255).</param>
    ''' <param name="blue">Blue value (must be between 0 and 255).</param>
    Public Shared Function RGBtoHSL(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer) As HSL

        Dim h As Double = 0.0
        Dim s As Double = 0.0
        Dim l As Double = 0.0

        ' normalizes red-green-blue values
        Dim nRed As Double = CDbl(red) / 255.0
        Dim nGreen As Double = CDbl(green) / 255.0
        Dim nBlue As Double = CDbl(blue) / 255.0

        Dim max As Double = Math.Max(nRed, Math.Max(nGreen, nBlue))
        Dim min As Double = Math.Min(nRed, Math.Min(nGreen, nBlue))

        ' Hue
        If (max = min) Then
            h = 0 ' undefined
        ElseIf (max = nRed And nGreen >= nBlue) Then
            h = 60.0 * (nGreen - nBlue) / (max - min)
        ElseIf (max = nRed And nGreen < nBlue) Then
            h = 60.0 * (nGreen - nBlue) / (max - min) + 360.0
        ElseIf (max = nGreen) Then
            h = 60.0 * (nBlue - nRed) / (max - min) + 120.0
        ElseIf (max = nBlue) Then
            h = 60.0 * (nRed - nGreen) / (max - min) + 240.0
        End If

        ' Luminance
        l = (max + min) / 2.0

        ' Saturation
        If (l = 0 Or max = min) Then
            s = 0
        ElseIf (0 < l And l <= 0.5) Then
            s = (max - min) / (max + min)
        ElseIf (l > 0.5) Then
            s = (max - min) / (2 - (max + min))
        End If

        Return New HSL(h, s, l)

        '    Return New HSL(Double.Parse(String.Format("{0:0.##}", h)), _
        '                   Double.Parse(String.Format("{0:0.##}", s)), _
        '                   Double.Parse(String.Format("{0:0.##}", l)))

    End Function

#End Region

#Region "RGBtoCMYK"

    ''' <summary>
    ''' Converts RGB to CMYK
    ''' </summary >
    Public Shared Function RGBtoCMYK(ByVal rgb As RGB) As CMYK
        Return RGBtoCMYK(rgb.Red, rgb.Green, rgb.Blue)
    End Function

    ''' <summary>
    ''' Converts .Net Color to CMYK
    ''' </summary >
    Public Shared Function RGBtoCMYK(ByVal c As Color) As CMYK
        Return RGBtoCMYK(c.R, c.G, c.B)
    End Function

    ''' <summary>
    ''' Converts RGB to CMYK
    ''' </summary >
    ''' <param name="red">Red vaue must be in [0, 255].</param>
    ''' <param name="green">Green vaue must be in [0, 255].</param>
    ''' <param name="blue">Blue vaue must be in [0, 255].</param>
    Public Shared Function RGBtoCMYK(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer) As CMYK

        Dim c As Double = CDbl(255 - red) / 255.0
        Dim m As Double = CDbl(255 - green) / 255.0
        Dim y As Double = CDbl(255 - blue) / 255.0

        Dim min As Double = Math.Min(c, Math.Min(m, y))
        If (min = 1.0) Then
            Return New CMYK(0, 0, 0, 1)
        Else
            Return New CMYK((c - min) / (1 - min), (m - min) / (1 - min), (y - min) / (1 - min), min)
        End If

    End Function

#End Region

#Region "RGBtoYUV"

    ''' <summary>
    ''' Converts RGB to YUV.
    ''' </summary >
    Public Shared Function RGBtoYUV(ByVal rgb As RGB) As YUV
        Return RGBtoYUV(rgb.Red, rgb.Green, rgb.Blue)
    End Function

    ''' <summary>
    ''' Converts .Net Color to YUV.
    ''' </summary >
    Public Shared Function RGBtoYUV(ByVal c As Color) As YUV
        Return RGBtoYUV(c.R, c.G, c.B)
    End Function

    ''' <summary>
    ''' Converts RGB to YUV.
    ''' </summary >
    ''' <param name="red">red must be in [0, 255].</param>
    ''' <param name="green">green must be in [0, 255].</param>
    ''' <param name="blue">blue must be in [0, 255].</param>
    Public Shared Function RGBtoYUV(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer) As YUV

        Dim YUV As YUV

        ' normalizes red/green/blue values
        Dim nRed As Double = CDbl(red) / 255.0
        Dim nGreen As Double = CDbl(green) / 255.0
        Dim nBlue As Double = CDbl(blue) / 255.0

        ' converts
        YUV.Y = 0.299 * nRed + 0.587 * nGreen + 0.114 * nBlue
        YUV.U = -0.14713769751693 * nRed - 0.28886230248307 * nGreen + 0.436 * nBlue
        YUV.V = 0.615 * nRed - 0.51498573466476461 * nGreen - 0.10001426533523537 * nBlue

        Return YUV

    End Function

#End Region

#End Region

#Region "CMYK convert"

    ''' <summary>
    ''' Converts CMYK to RGB.
    ''' </summary >
    ''' <param name="c">Cyan value (must be between 0 and 1).</param>
    ''' <param name="m">Magenta value (must be between 0 and 1).</param>
    ''' <param name="y">Yellow value (must be between 0 and 1).</param>
    ''' <param name="k">Black value (must be between 0 and 1).</param>
    Public Shared Function CMYKtoColor(ByVal c As Single, ByVal m As Single, ByVal y As Single, ByVal k As Single) As Color
        Return CMYKtoColor(CDbl(c), CDbl(m), CDbl(y), CDbl(k))
    End Function

    ''' <summary>
    ''' Converts CMYK to RGB.
    ''' </summary >
    ''' <param name="c">Cyan value (must be between 0 and 1).</param>
    ''' <param name="m">Magenta value (must be between 0 and 1).</param>
    ''' <param name="y">Yellow value (must be between 0 and 1).</param>
    ''' <param name="k">Black value (must be between 0 and 1).</param>
    Public Shared Function CMYKtoColor(ByVal c As Double, ByVal m As Double, ByVal y As Double, ByVal k As Double) As Color
        Return CMYKtoColor(New CMYK(c, m, y, k))
    End Function

    ''' <summary>
    ''' Converts CMYK to RGB.
    ''' </summary >
    ''' <param name="cmyk"></param>
    Public Shared Function CMYKtoColor(ByVal cmyk As CMYK) As Color

        Dim red As Integer = CInt(((1 - cmyk.Cyan) * (1 - cmyk.Black) * 255))
        Dim green As Integer = CInt(((1 - cmyk.Magenta) * (1 - cmyk.Black) * 255))
        Dim blue As Integer = CInt(((1 - cmyk.Yellow) * (1 - cmyk.Black) * 255))

        Return Color.FromArgb(red, green, blue)

    End Function


    ''' <summary>
    ''' Converts CMYK to RGB.
    ''' </summary >
    ''' <param name="c">Cyan value (must be between 0 and 1).</param>
    ''' <param name="m">Magenta value (must be between 0 and 1).</param>
    ''' <param name="y">Yellow value (must be between 0 and 1).</param>
    ''' <param name="k">Black value (must be between 0 and 1).</param>
    Public Shared Function CMYKtoRGB(ByVal c As Double, ByVal m As Double, ByVal y As Double, ByVal k As Double) As RGB

        Dim red As Integer = CInt(((1.0 - c) * (1.0 - k) * 255.0))
        Dim green As Integer = CInt(((1.0 - m) * (1.0 - k) * 255.0))
        Dim blue As Integer = CInt(((1.0 - y) * (1.0 - k) * 255.0))

        Return New RGB(red, green, blue)

    End Function

    ''' <summary>
    ''' Converts CMYK to RGB.
    ''' </summary >
    ''' <param name="cmyk"></param>
    Public Shared Function CMYKtoRGB(ByVal cmyk As CMYK) As RGB
        Return CMYKtoRGB(cmyk.Cyan, cmyk.Magenta, cmyk.Yellow, cmyk.Black)
    End Function


#End Region

#Region "YUV convert"

    ''' <summary>
    ''' Converts YUV to RGB.
    ''' </summary >
    ''' <param name="y">Y (must be between 0 and 1).</param>
    ''' <param name="u">U (must be between -0.436 and 0.436).</param>
    ''' <param name="v">V (must be between -0.436 and 0.436).</param>
    Public Shared Function YUVtoRGB(ByVal y As Double, ByVal u As Double, ByVal v As Double) As RGB

        Dim rgb As RGB

        rgb.Red = CInt((y + 1.1398373983739838 * v) * 255)
        rgb.Green = CInt((y - 0.39465170435897035 * u - 0.58059860666749763 * v) * 255)
        rgb.Blue = CInt((y + 2.0321100917431192 * u) * 255)

        Return rgb

    End Function

    ''' <summary>
    ''' Converts YUV to RGB.
    ''' </summary >
    Public Shared Function YUVtoRGB(ByVal yuv As YUV) As RGB
        Return YUVtoRGB(yuv.Y, yuv.U, yuv.V)
    End Function

    ''' <summary>
    ''' Converts YUV to a .net Color.
    ''' </summary >
    ''' <param name="y">Y must be in [0, 1].</param>
    ''' <param name="u">U must be in [-0.436, +0.436].</param>
    ''' <param name="v">V must be in [-0.615, +0.615].</param>
    Public Shared Function YUVtoColor(ByVal y As Double, ByVal u As Double, ByVal v As Double) As Color
        Dim rgb As RGB = YUVtoRGB(y, u, v)
        Return Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)
    End Function

    ''' <summary>
    ''' Converts YUV to a .net Color.
    ''' </summary >
    Public Shared Function YUVtoColor(ByVal yuv As YUV) As Color
        Dim rgb As RGB = YUVtoRGB(yuv)
        Return Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)
    End Function

#End Region

#Region "CIE XYZ convert"
    ''' <summary>
    ''' Converts CIEXYZ to RGB structure.
    ''' </summary>
    Public Shared Function XYZtoRGB(ByVal x As Double, ByVal y As Double, ByVal z As Double) As RGB
        Dim Clinear(2) As Double
        Clinear(0) = x * 3.241 - y * 1.5374 - z * 0.4986 ' red
        Clinear(1) = -x * 0.9692 + y * 1.876 - z * 0.0416 ' green
        Clinear(2) = x * 0.0556 - y * 0.204 + z * 1.057 ' blue

        For i As Integer = 0 To 2
            If Clinear(i) <= 0.0031308 Then
                Clinear(i) = 12.92 * Clinear(i)
            Else
                Clinear(i) = (1 + 0.055) * Math.Pow(Clinear(i), (1.0 / 2.4)) - 0.055
            End If
        Next

        Return New RGB(
                    CInt(Double.Parse(String.Format("{0:0.00}", Clinear(0) * 255.0))),
                    CInt(Double.Parse(String.Format("{0:0.00}", Clinear(1) * 255.0))),
                    CInt(Double.Parse(String.Format("{0:0.00}", Clinear(2) * 255.0)))
                    )
    End Function

    ''' <summary>
    ''' Converts CIEXYZ to RGB structure.
    ''' </summary>
    Public Shared Function XYZtoRGB(ByVal xyz) As RGB
        Return XYZtoRGB(xyz.X, xyz.Y, xyz.Z)
    End Function

    ''' <summary>
    ''' XYZ to L*a*b* transformation function.
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Private Shared Function Fxyz(ByVal t As Double) As Double
        If t > 0.008856 Then
            Return Math.Pow(t, (1.0 / 3.0))
        Else
            Return (7.787 * t + 16.0 / 116.0)
        End If
    End Function

    ''' <summary>
    ''' Converts CIEXYZ to CIELab structure.
    ''' </summary>
    Public Shared Function XYZtoLab(ByVal x As Double, ByVal y As Double, ByVal z As Double) As CIELab
        Dim lab As CIELab
        Dim d65X As Double = 0.9505
        Dim d65Y As Double = 1.0
        Dim d65Z As Double = 1.089

        lab.L = 116.0 * Fxyz(y / d65Y) - 16
        lab.A = 500.0 * (Fxyz(x / d65X) - Fxyz(y / d65Y))
        lab.B = 200.0 * (Fxyz(y / d65Y) - Fxyz(z / d65Z))

        Return lab
    End Function

    ''' <summary>
    ''' Converts CIEXYZ to CIELab structure.
    ''' </summary>
    Public Shared Function XYZtoLab(ByVal xyz As CIEXYZ) As CIELab
        Return XYZtoLab(xyz.X, xyz.Y, xyz.Z)
    End Function

#End Region

#Region "CIE L*a*b* convert"
    ''' <summary>
    ''' Converts CIELab to CIEXYZ.
    ''' </summary>
    Public Shared Function LabtoXYZ(ByVal l As Double, ByVal a As Double, ByVal b As Double) As CIEXYZ
        Dim delta As Double = 6.0 / 29.0

        Dim fy As Double = (l + 16) / 116.0
        Dim fx As Double = fy + (a / 500.0)
        Dim fz As Double = fy - (b / 200.0)

        Dim d65X As Double = 0.9505
        Dim d65Y As Double = 1.0
        Dim d65Z As Double = 1.089

        Dim xyz As CIEXYZ

        ' x component
        If fx > delta Then
            xyz.X = d65X * (fx * fx * fx)
        Else
            xyz.X = (fx - 16.0 / 116.0) * 3 * (delta * delta) * d65X
        End If
        ' y component
        If fy > delta Then
            xyz.Y = d65Y * (fy * fy * fy)
        Else
            xyz.Y = (fy - 16.0 / 116.0) * 3 * (delta * delta) * d65Y
        End If
        ' z component
        If fz > delta Then
            xyz.Z = d65Z * (fz * fz * fz)
        Else
            xyz.Z = (fz - 16.0 / 116.0) * 3 * (delta * delta) * d65Z
        End If

    End Function

    ''' <summary>
    ''' Converts CIELab to CIEXYZ.
    ''' </summary>
    Public Shared Function LabtoXYZ(ByVal lab As CIELab) As CIEXYZ
        Return LabtoXYZ(lab.L, lab.A, lab.B)
    End Function


    ''' <summary>
    ''' Converts CIELab to RGB.
    ''' </summary>
    Public Shared Function LabtoRGB(ByVal l As Double, ByVal a As Double, ByVal b As Double) As RGB
        Return XYZtoRGB(LabtoXYZ(l, a, b))
    End Function
    ''' <summary>
    ''' Converts CIELab to RGB.
    ''' </summary>
    Public Shared Function LabtoRGB(ByVal lab As CIELab) As RGB
        Return XYZtoRGB(LabtoXYZ(lab))
    End Function


#End Region
End Class

''' <summary>
''' Structure to define CIELab.
''' </summary>
Public Structure CIELab
#Region "Fields"

    Private _l As Integer
    Private _a As Integer
    Private _b As Integer

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As CIELab, ByVal item2 As CIELab) As Boolean
        Return item1.L = item2.L AndAlso
               item1.A = item2.A AndAlso
               item1.B = item2.B
    End Operator

    Public Shared Operator <>(ByVal item1 As CIELab, ByVal item2 As CIELab) As Boolean
        Return item1.L <> item2.A OrElse
               item1.A <> item2.A OrElse
               item1.B <> item2.B
    End Operator

#End Region

#Region "Accessors"

    Public Property L()
        Get
            Return _l
        End Get
        Set(ByVal value)
            _l = value
        End Set
    End Property

    Public Property A()
        Get
            Return _a
        End Get
        Set(ByVal value)
            _a = value
        End Set
    End Property

    Public Property B()
        Get
            Return _b
        End Get
        Set(ByVal value)
            _b = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a CIELAB structure.
    ''' </summary>
    Public Sub New(ByVal l As Double, ByVal a As Double, ByVal b As Double)
        Me.L = l
        Me.A = a
        Me.B = b
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, CIELab))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return L.GetHashCode() ^ A.GetHashCode() ^ B.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define CIEXYZ.
''' </summary>
Public Structure CIEXYZ

#Region "Fields"

    Private _x As Double
    Private _y As Double
    Private _z As Double

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As CIEXYZ, ByVal item2 As CIEXYZ) As Boolean
        Return item1.X = item2.X AndAlso
               item1.Y = item2.Y AndAlso
               item1.Z = item2.Z
    End Operator

    Public Shared Operator <>(ByVal item1 As CIEXYZ, ByVal item2 As CIEXYZ) As Boolean
        Return item1.X <> item2.X OrElse
               item1.Y <> item2.Y OrElse
               item1.Z <> item2.Z
    End Operator

#End Region

#Region "Accessors"

    Public Property X()
        Get
            Return _x
        End Get
        Set(ByVal value)
            If value > 0.9505 Then
                _x = 0.9505
            Else
                If value < 0 Then
                    _x = 0
                Else
                    _x = value
                End If
            End If
        End Set
    End Property

    Public Property Y()
        Get
            Return _y
        End Get
        Set(ByVal value)
            If value > 1.0 Then
                _y = 1.0
            Else
                If value < 0 Then
                    _y = 0
                Else
                    _y = value
                End If
            End If
        End Set
    End Property

    Public Property Z()
        Get
            Return _z
        End Get
        Set(ByVal value)
            If value > 1.089 Then
                _z = 1.089
            Else
                If value < 0 Then
                    _z = 0
                Else
                    _z = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a CIEXYZ structure.
    ''' </summary>
    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, CIEXYZ))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define CMYK.
''' </summary>
Public Structure CMYK

#Region "Fields"

    Private _Cyan As Double
    Private _Magenta As Double
    Private _Yellow As Double
    Private _Black As Double

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As CMYK, ByVal item2 As CMYK) As Boolean
        Return item1.Cyan = item2.Cyan AndAlso
               item1.Magenta = item2.Magenta AndAlso
               item1.Yellow = item2.Yellow AndAlso
               item1.Black = item2.Black
    End Operator

    Public Shared Operator <>(ByVal item1 As CMYK, ByVal item2 As CMYK) As Boolean
        Return item1.Cyan <> item2.Cyan OrElse
               item1.Magenta <> item2.Magenta OrElse
               item1.Yellow <> item2.Yellow OrElse
               item1.Black <> item2.Black
    End Operator

#End Region

#Region "Accessors"

    Public Property Cyan()
        Get
            Return _Cyan
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Cyan = 1
            Else
                If value < 0 Then
                    _Cyan = 0
                Else
                    _Cyan = value
                End If
            End If
        End Set
    End Property

    Public Property Magenta()
        Get
            Return _Magenta
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Magenta = 1
            Else
                If value < 0 Then
                    _Magenta = 0
                Else
                    _Magenta = value
                End If
            End If
        End Set
    End Property

    Public Property Yellow()
        Get
            Return _Yellow
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Yellow = 1
            Else
                If value < 0 Then
                    _Yellow = 0
                Else
                    _Yellow = value
                End If
            End If
        End Set
    End Property

    Public Property Black()
        Get
            Return _Black
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Black = 1
            Else
                If value < 0 Then
                    _Black = 0
                Else
                    _Black = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a CMYK structure.
    ''' </summary>
    ''' <param name="c">Cyan value (must be between 0 and 1).</param>
    ''' <param name="m">Magenta value (must be between 0 and 1).</param>
    ''' <param name="y">Yellow value (must be between 0 and 1).</param>
    ''' <param name="k">Black value (must be between 0 and 1).</param>
    Public Sub New(ByVal c As Double, ByVal m As Double, ByVal y As Double, ByVal k As Double)
        Me.Cyan = c
        Me.Magenta = m
        Me.Yellow = y
        Me.Black = k
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, CMYK))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Cyan.GetHashCode() ^ Magenta.GetHashCode() ^ Yellow.GetHashCode() ^ Black.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define HSB.
''' </summary>
Public Structure HSB

#Region "Fields"

    Private _Hue As Double
    Private _Saturation As Double
    Private _Brightness As Double

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As HSB, ByVal item2 As HSB) As Boolean
        Return item1.Hue = item2.Hue AndAlso
               item1.Saturation = item2.Saturation AndAlso
               item1.Brightness = item2.Brightness
    End Operator

    Public Shared Operator <>(ByVal item1 As HSB, ByVal item2 As HSB) As Boolean
        Return item1.Hue <> item2.Hue OrElse
               item1.Saturation <> item2.Saturation OrElse
               item1.Brightness <> item2.Brightness
    End Operator

#End Region

#Region "Accessors"

    Public Property Hue()
        Get
            Return _Hue
        End Get
        Set(ByVal value)
            If value > 360 Then
                _Hue = 360
            Else
                If value < 0 Then
                    _Hue = 0
                Else
                    _Hue = value
                End If
            End If
        End Set
    End Property

    Public Property Saturation()
        Get
            Return _Saturation
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Saturation = 1
            Else
                If value < 0 Then
                    _Saturation = 0
                Else
                    _Saturation = value
                End If
            End If
        End Set
    End Property

    Public Property Brightness()
        Get
            Return _Brightness
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Brightness = 1
            Else
                If value < 0 Then
                    _Brightness = 0
                Else
                    _Brightness = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a HSB structure.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="b">Brightness value (must be between 0 and 1).</param>
    Public Sub New(ByVal h As Double, ByVal s As Double, ByVal b As Double)
        Me.Hue = h
        Me.Saturation = s
        Me.Brightness = b
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, HSB))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Hue.GetHashCode() ^ Saturation.GetHashCode() ^ Brightness.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define HSL.
''' </summary>
Public Structure HSL

#Region "Fields"

    Private _Hue As Double
    Private _Saturation As Double
    Private _Luminance As Double

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As HSL, ByVal item2 As HSL) As Boolean
        Return item1.Hue = item2.Hue AndAlso
               item1.Saturation = item2.Saturation AndAlso
               item1.Luminance = item2.Luminance
    End Operator

    Public Shared Operator <>(ByVal item1 As HSL, ByVal item2 As HSL) As Boolean
        Return item1.Hue <> item2.Hue OrElse
               item1.Saturation <> item2.Saturation OrElse
               item1.Luminance <> item2.Luminance
    End Operator

#End Region

#Region "Accessors"

    Public Property Hue()
        Get
            Return _Hue
        End Get
        Set(ByVal value)
            If value > 360 Then
                _Hue = 360
            Else
                If value < 0 Then
                    _Hue = 0
                Else
                    _Hue = value
                End If
            End If
        End Set
    End Property

    Public Property Saturation()
        Get
            Return _Saturation
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Saturation = 1
            Else
                If value < 0 Then
                    _Saturation = 0
                Else
                    _Saturation = value
                End If
            End If
        End Set
    End Property

    Public Property Luminance()
        Get
            Return _Luminance
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Luminance = 1
            Else
                If value < 0 Then
                    _Luminance = 0
                Else
                    _Luminance = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a HSL structure.
    ''' </summary>
    ''' <param name="h">Hue value (must be between 0 and 360).</param>
    ''' <param name="s">Saturation value (must be between 0 and 1).</param>
    ''' <param name="l">Luminance value (must be between 0 and 1).</param>
    Public Sub New(ByVal h As Double, ByVal s As Double, ByVal l As Double)
        Me.Hue = h
        Me.Saturation = s
        Me.Luminance = l
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, HSL))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Hue.GetHashCode() ^ Saturation.GetHashCode() ^ Luminance.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define RGB.
''' </summary>
Public Structure RGB
#Region "Fields"

    Private _Red As Integer
    Private _Green As Integer
    Private _Blue As Integer

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As RGB, ByVal item2 As RGB) As Boolean
        Return item1.Red = item2.Red AndAlso
               item1.Green = item2.Green AndAlso
               item1.Blue = item2.Blue
    End Operator

    Public Shared Operator <>(ByVal item1 As RGB, ByVal item2 As RGB) As Boolean
        Return item1.Red <> item2.Red OrElse
               item1.Green <> item2.Green OrElse
               item1.Blue <> item2.Blue
    End Operator

#End Region

#Region "Accessors"

    Public Property Red()
        Get
            Return _Red
        End Get
        Set(ByVal value)
            If value > 255 Then
                _Red = 255
            Else
                If value < 0 Then
                    _Red = 0
                Else
                    _Red = value
                End If
            End If
        End Set
    End Property

    Public Property Green()
        Get
            Return _Green
        End Get
        Set(ByVal value)
            If value > 255 Then
                _Green = 255
            Else
                If value < 0 Then
                    _Green = 0
                Else
                    _Green = value
                End If
            End If
        End Set
    End Property

    Public Property Blue()
        Get
            Return _Blue
        End Get
        Set(ByVal value)
            If value > 255 Then
                _Blue = 255
            Else
                If value < 0 Then
                    _Blue = 0
                Else
                    _Blue = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a RGB structure.
    ''' </summary>
    ''' <param name="r">Red value (must be between 0 and 255).</param>
    ''' <param name="g">Green value (must be between 0 and 255).</param>
    ''' <param name="b">Blue value (must be between 0 and 255).</param>
    Public Sub New(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer)
        Me.Red = r
        Me.Green = g
        Me.Blue = b
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, RGB))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Red.GetHashCode() ^ Green.GetHashCode() ^ Blue.GetHashCode()
    End Function

#End Region

End Structure

''' <summary>
''' Structure to define YUV.
''' </summary>
Public Structure YUV

#Region "Fields"

    Private _Y As Double
    Private _U As Double
    Private _V As Double

#End Region

#Region "Operators"

    Public Shared Operator =(ByVal item1 As YUV, ByVal item2 As YUV) As Boolean
        Return item1.Y = item2.Y AndAlso
               item1.U = item2.U AndAlso
               item1.V = item2.V
    End Operator

    Public Shared Operator <>(ByVal item1 As YUV, ByVal item2 As YUV) As Boolean
        Return item1.Y <> item2.Y OrElse
               item1.U <> item2.U OrElse
               item1.V <> item2.V
    End Operator

#End Region

#Region "Accessors"

    Public Property Y()
        Get
            Return _Y
        End Get
        Set(ByVal value)
            If value > 1 Then
                _Y = 1
            Else
                If value < 0 Then
                    _Y = 0
                Else
                    _Y = value
                End If
            End If
        End Set
    End Property

    Public Property U()
        Get
            Return _U
        End Get
        Set(ByVal value)
            If value > 0.436 Then
                _U = 0.436
            Else
                If value < -0.436 Then
                    _U = -0.436
                Else
                    _U = value
                End If
            End If
        End Set
    End Property

    Public Property V()
        Get
            Return _V
        End Get
        Set(ByVal value)
            If value > 0.615 Then
                _V = 0.615
            Else
                If value < -0.615 Then
                    _V = -0.615
                Else
                    _V = value
                End If
            End If
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Creates an instance of a YUV structure.
    ''' </summary>
    ''' <param name="y">Y (must be between 0 and 1).</param>
    ''' <param name="u">U (must be between -0.436 and 0.436).</param>
    ''' <param name="v">V (must be between -0.436 and 0.436).</param>
    Public Sub New(ByVal y As Double, ByVal u As Double, ByVal v As Double)
        Me.Y = y
        Me.U = u
        Me.V = v
    End Sub

#Region "Methods"

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If (obj Is Nothing) Or (Me.GetType() IsNot obj.GetType()) Then Return False
        Return (Me = CType(obj, YUV))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Y.GetHashCode() ^ U.GetHashCode() ^ V.GetHashCode()
    End Function

#End Region

End Structure

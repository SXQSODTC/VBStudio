Public Class KzColorConverter

    Private updating As Boolean = False
#Region "Handlers"
    Private Sub RGBValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueUD.ValueChanged, redUD.ValueChanged, greenUD.ValueChanged
        If updating = False Then
            preview.BackColor = Color.FromArgb(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value))
            hexBox.Text = ColorConvert.RGBtoHEX(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value))

            updating = True
            UpdateHSL(ColorConvert.RGBtoHSL(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateHSB(ColorConvert.RGBtoHSB(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateCMYK(ColorConvert.RGBtoCMYK(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateYUV(ColorConvert.RGBtoYUV(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            updating = False
        End If
    End Sub

    Private Sub HSLValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hueUD.ValueChanged, satUD.ValueChanged, lumUD.ValueChanged
        If updating = False Then
            updating = True
            UpdateRGB(ColorConvert.HSLtoRGB(Convert.ToDouble(hueUD.Value), Convert.ToDouble(satUD.Value / 100.0), Convert.ToDouble(lumUD.Value / 100.0)))
            UpdateHSB(ColorConvert.RGBtoHSB(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateCMYK(ColorConvert.RGBtoCMYK(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateYUV(ColorConvert.RGBtoYUV(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            updating = False
        End If
    End Sub

    Private Sub HSBValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sUD.ValueChanged, hUD.ValueChanged, bUD.ValueChanged
        If updating = False Then
            updating = True
            UpdateRGB(ColorConvert.HSBtoRGB(Convert.ToDouble(hUD.Value), Convert.ToDouble(sUD.Value / 100.0), Convert.ToDouble(bUD.Value / 100.0)))
            UpdateHSL(ColorConvert.RGBtoHSL(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateCMYK(ColorConvert.RGBtoCMYK(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateYUV(ColorConvert.RGBtoYUV(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            updating = False
        End If
    End Sub

    Private Sub CMYKValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowUD.ValueChanged, magentaUD.ValueChanged, cyanUD.ValueChanged, blackUD.ValueChanged
        If updating = False Then
            updating = True
            UpdateRGB(ColorConvert.CMYKtoRGB(Convert.ToDouble(cyanUD.Value / 100.0), Convert.ToDouble(magentaUD.Value / 100.0), Convert.ToDouble(yellowUD.Value / 100.0), Convert.ToDouble(blackUD.Value / 100.0)))
            UpdateHSL(ColorConvert.RGBtoHSL(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateHSB(ColorConvert.RGBtoHSB(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateYUV(ColorConvert.RGBtoYUV(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            updating = False
        End If
    End Sub

    Private Sub YUVValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yUD.ValueChanged, vUD.ValueChanged, uUD.ValueChanged
        If updating = False Then
            updating = True
            UpdateRGB(ColorConvert.YUVtoRGB(Convert.ToDouble(yUD.Value / 100.0), (-0.436 + (Convert.ToDouble(uUD.Value / 100.0))), (-0.615 + (Convert.ToDouble(vUD.Value / 100.0)))))
            UpdateCMYK(ColorConvert.RGBtoCMYK(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateHSL(ColorConvert.RGBtoHSL(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            UpdateHSB(ColorConvert.RGBtoHSB(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
            updating = False
        End If
    End Sub

#End Region

#Region "Updates"
    Private Sub UpdateRGB(ByVal rgb As RGB)
        If CInt(redUD.Value) <> rgb.Red Then
            redUD.Value = rgb.Red
        End If
        If CInt(greenUD.Value) <> rgb.Green Then
            greenUD.Value = rgb.Green
        End If
        If CInt(blueUD.Value) <> rgb.Blue Then
            blueUD.Value = rgb.Blue
        End If

        preview.BackColor = Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)
        hexBox.Text = ColorConvert.RGBtoHEX(rgb.Red, rgb.Green, rgb.Blue)
    End Sub

    Private Sub UpdateHSL(ByVal hsl As HSL)
        If CInt(hsl.Hue) <> CInt(hueUD.Value) Then
            hueUD.Value = CInt(hsl.Hue)
        End If
        If CInt(hsl.Saturation * 100) <> CInt(satUD.Value) Then
            satUD.Value = CInt(hsl.Saturation * 100)
        End If
        If CInt(hsl.Luminance * 100) <> CInt(lumUD.Value) Then
            lumUD.Value = CInt(hsl.Luminance * 100)
        End If
    End Sub

    Private Sub UpdateHSB(ByVal hsb As HSB)
        If CInt(hsb.Hue) <> CInt(hUD.Value) Then
            hUD.Value = CInt(hsb.Hue)
        End If
        If CInt(hsb.Saturation * 100) <> CInt(sUD.Value) Then
            sUD.Value = CInt(hsb.Saturation * 100)
        End If
        If CInt(hsb.Brightness * 100) <> CInt(bUD.Value) Then
            bUD.Value = CInt(hsb.Brightness * 100)
        End If
    End Sub

    Private Sub UpdateCMYK(ByVal cmyk As CMYK)
        If CInt(cmyk.Cyan * 100) <> CInt(magentaUD.Value) Then
            magentaUD.Value = CInt(cmyk.Cyan * 100)
        End If
        If CInt(cmyk.Magenta * 100) <> CInt(magentaUD.Value) Then
            magentaUD.Value = CInt(cmyk.Magenta * 100)
        End If
        If CInt(cmyk.Yellow * 100) <> CInt(yellowUD.Value) Then
            yellowUD.Value = CInt(cmyk.Yellow * 100)
        End If
        If CInt(cmyk.Black * 100) <> CInt(blackUD.Value) Then
            blackUD.Value = CInt(cmyk.Black * 100)
        End If
    End Sub

    Private Sub UpdateYUV(ByVal yuv As YUV)
        If CInt(yuv.Y * 100) <> CInt(yUD.Value) Then
            yUD.Value = CInt(yuv.Y * 100)
        End If
        If CInt((yuv.U + 0.436) * 100) <> CInt(uUD.Value) Then
            uUD.Value = CInt((yuv.U + 0.436) * 100)
        End If
        If CInt((yuv.V + 0.615) * 100) <> CInt(vUD.Value) Then
            vUD.Value = CInt((yuv.V + 0.615) * 100)
        End If
    End Sub

#End Region

    ''' <summary>
    ''' Testing Application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updating = True
        UpdateHSL(ColorConvert.RGBtoHSL(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
        UpdateHSB(ColorConvert.RGBtoHSB(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
        UpdateCMYK(ColorConvert.RGBtoCMYK(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
        UpdateYUV(ColorConvert.RGBtoYUV(CInt(redUD.Value), CInt(greenUD.Value), CInt(blueUD.Value)))
        updating = False
    End Sub

End Class
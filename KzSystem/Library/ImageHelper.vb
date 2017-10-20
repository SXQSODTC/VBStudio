Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class KzImg
    Public Shared Sub GetThumbnail(sourceImgFile As String, destinationImgFile As String, Optional thumbWidth As Integer = 128)
        '//利用Image对象装载源图像
        Dim image As Image = Image.FromFile(sourceImgFile)
        '//接着创建一个System.Drawing.Bitmap对象，并设置你希望的缩略图的宽度和高度。
        Dim srcWidth = image.Width
        Dim srcHeight = image.Height
        Dim thumbHeight As Integer = (srcHeight / srcWidth) * thumbWidth
        Dim bmp As Bitmap = New Bitmap(thumbWidth, thumbHeight)
        '//从Bitmap创建一个System.Drawing.Graphics对象，用来绘制高质量的缩小图。
        Dim g As Graphics = Graphics.FromImage(bmp)
        '//设置 System.Drawing.Graphics对象的SmoothingMode属性为HighQuality
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        '//下面这个也设成高质量
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        '//下面这个设成High
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High
        '//把原始图像绘制成上面所设置宽高的缩小图
        Dim rectDestination As Rectangle = New Rectangle(0, 0, thumbWidth, thumbHeight)
        g.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel)
        '//保存图像，大功告成！
        bmp.Save(destinationImgFile)
        '//最后别忘了释放资源
        bmp.Dispose()
        image.Dispose()
    End Sub

    Public Shared Sub SaveImage(ByVal fileName As String, ByVal quality As Integer)
        Dim myBitmap As Bitmap = New Bitmap(fileName)
        Dim myEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
        Dim myEncoderParameter As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality)

        myEncoderParameters.Param(0) = myEncoderParameter

        Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
        myImageCodecInfo = GetEncoderInfo("image/jpeg")

        Dim ext As String = myImageCodecInfo.FilenameExtension.Split(";"c)(0)
        ext = System.IO.Path.GetExtension(ext).ToLower()

        Dim saveName As String =
        System.IO.Path.ChangeExtension(fileName, ext)

        '保存
        myBitmap.Save(saveName, myImageCodecInfo, myEncoderParameters)
    End Sub

    '获取MimeType
    Private Shared Function GetEncoderInfo(ByVal mineType As String) As System.Drawing.Imaging.ImageCodecInfo
        Dim myEncoders() As System.Drawing.Imaging.ImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim myEncoder As System.Drawing.Imaging.ImageCodecInfo
        For Each myEncoder In myEncoders
            If myEncoder.MimeType = mineType Then
                Return myEncoder
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function GetThumbnail(OriginFilePath As String, TargetFilePath As String, DestWidth As Integer, DestHeight As Integer) As Boolean
        Dim OriginImage As Image = Image.FromFile(OriginFilePath)
        Dim thisFormat = OriginImage.RawFormat
        '按比例缩放 
        Dim sW As Integer = 0
        Dim sH As Integer = 0
        Dim ImageWidth As Integer = OriginImage.Width
        Dim ImageHeight As Integer = OriginImage.Height

        If ImageWidth > DestWidth Or ImageHeight > DestHeight Then
            If (ImageWidth * DestWidth) > (ImageHeight * DestHeight) Then
                sW = DestWidth
                sH = (DestHeight * ImageHeight) / ImageWidth
            Else
                sH = DestHeight
                sW = (DestWidth * ImageWidth) / ImageHeight
            End If

        Else
            sW = ImageWidth
            sH = ImageHeight
        End If

        Dim bt As Bitmap = New Bitmap(DestWidth, DestHeight) '//根据指定大小创建Bitmap实例 
        Using g As Graphics = Graphics.FromImage(bt)
            g.Clear(Color.White)
            '//设置画布的描绘质量  
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(OriginImage, New Rectangle((DestWidth - sW) / 2, (DestHeight - sH) / 2, sW, sH))
            g.Dispose()
        End Using

        Dim EncoderParams As Imaging.EncoderParameters = New Imaging.EncoderParameters() '//取得内置的编码器  
        Dim Quality(1) As Long
        Dim EncoderParam As Imaging.EncoderParameter = New Imaging.EncoderParameter(Imaging.Encoder.Quality, Quality)
        EncoderParams.Param(0) = EncoderParam

        Try
            '//获得包含有关内置图像编码解码器的信息的ImageCodecInfo 对象  
            Dim arrayICI As Imaging.ImageCodecInfo() = Imaging.ImageCodecInfo.GetImageEncoders()
            Dim jpegICI As Imaging.ImageCodecInfo = Nothing

            For i As Integer = 0 To arrayICI.Length
                If arrayICI(i).FormatDescription.Equals("JPEG") Then
                    jpegICI = arrayICI(i) '//设置为JPEG编码方式 
                    Exit For
                End If
            Next

            If jpegICI IsNot Nothing Then '//保存缩略图
                'bt.Save(TargetFilePath + "/" + this.OriginFileName.ToString() + ".jpg", jpegICI, EncoderParams)
            Else
                'bt.Save(TargetFilePath + "/" + this.OriginFileName.ToString() + ".jpg", thisFormat)
            End If

            'this.OriginFileName++
            OriginImage.Dispose()
            Return True
        Catch ex As System.Runtime.InteropServices.ExternalException
            MsgBox("错误信息:" & ex.Message, MessageBoxButtons.OK, "系统提示")
            Return False
        Catch ex As Exception
            MsgBox("错误信息:" & ex.Message, MessageBoxButtons.OK, "系统提示")
            Return False
        End Try
    End Function
End Class


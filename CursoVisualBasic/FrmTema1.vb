Imports AxWMPLib

Public Class FrmTema1



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Atras()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim path As String = My.Application.Info.DirectoryPath

        PnlImagen.Visible = False
        WebBrowser1.Visible = False
        WebBrowser1.Navigate("about:blank")
        ExpandirPanel()
        lblSlider.Visible = True

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If

        Select Case TabControl1.SelectedIndex
            Case 0
                MostrarImagen(My.Resources.IDE_001)
            Case 2
                MostrarUrl("https://www.youtube.com/watch?v=zt29PaBvyTw")
            Case 1
                ReproducirVideo(IO.Path.Combine(path, "imagenes\modulos.mp4"))
                ExpandirPanel(2)
                lblSlider.Visible = False
            Case 3
                MostrarUrl("https://docs.microsoft.com/es-es/dotnet/visual-basic/programming-guide/concepts/object-oriented-programming")
                ExpandirPanel(1)
                lblSlider.Visible = False

        End Select

    End Sub

    Private Sub ExpandirPanel(Optional v As Integer = 0)

        Select Case v
            Case 1

                SplitContainer1.Panel2Collapsed = True
            Case 2
                SplitContainer1.Panel1Collapsed = True
            Case 0
                SplitContainer1.Panel1Collapsed = False
                SplitContainer1.Panel2Collapsed = False


        End Select

    End Sub

    Private Sub ReproducirVideo(v As String)
        PnlImagen.Visible = False
        WebBrowser1.Visible = False
        AxWindowsMediaPlayer1.URL = v

    End Sub

    Private Sub AxWindowsMediaPlayer1_MediaError(ByVal sender As Object,
    ByVal e As _WMPOCXEvents_MediaErrorEvent)
        Try
            ' If the file is corrupt or missing, show the 
            ' hexadecimal error code and URL.
            Dim errSource As WMPLib.IWMPMedia2 = e.pMediaObject
            Dim errorItem As WMPLib.IWMPErrorItem = errSource.Error
            MessageBox.Show("Media error " + errorItem.errorCode.ToString("X") _
                            + " in " + errSource.sourceURL)
        Catch ex As InvalidCastException
            ' In case pMediaObject is not an IWMPMedia item.
            MessageBox.Show("Player error.")
        End Try
    End Sub

    Private Sub MostrarUrl(v As String)
        PnlImagen.Visible = False
        WebBrowser1.Navigate(New Uri(v))
        WebBrowser1.Visible = True
    End Sub

    Private Sub MostrarImagen(imagen As Bitmap)

        WebBrowser1.Visible = False
        PictureBox1.Image = imagen
        PnlImagen.Visible = True

    End Sub

    Private Sub FrmTema1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarImagen(My.Resources.IDE_001)

    End Sub
    Private Sub Atras()
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
        End If
    End Sub

    Private Sub Adelante()
        If TabControl1.SelectedIndex < TabControl1.TabPages.Count - 1 Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Adelante()
    End Sub

    Private Sub FrmTema1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Me.AxWindowsMediaPlayer1.close()
        Catch
        End Try

        Me.AxWindowsMediaPlayer1.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ejercicio_3.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ejercicio_6.ShowDialog()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CaidaLibre.ShowDialog()


    End Sub
End Class
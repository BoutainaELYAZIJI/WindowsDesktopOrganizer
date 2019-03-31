Imports System.IO

Public Class Form1
    Dim FN As String



    Function OrganizeArchives()
        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES")
        End If


        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".zip", ".rar", ".7z"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If





            End Select

        Next


    End Function






    Function OrganizeMultimedias()

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\MUSICS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\MUSICS")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\VIDEOS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\VIDEOS")
        End If








        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()

                Case ".mp3", ".mp2", ".wav", ".m2a", ".wma"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\MUSICS\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If


                Case ".mp4", ".flv", ".mpeg"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\MULTIMEDIAS\VIDEOS\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If














            End Select

        Next
        Return 0
    End Function
    Function OrganizePictures()
        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PHOTOS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PHOTOS")
        End If


        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".png", ".psd", ".jpg", ".gif", ".jpeg", "tif", ".bmp", ".ico"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PHOTOS\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If





            End Select

        Next
    End Function



    Function OrganizeDocuments()
        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS")
        End If






        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\PDFs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\PDFs")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\DOCs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\DOCs")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\PPTs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\PPTs")
        End If

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\XLSs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\XLSs")
        End If

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\TXTs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\TXTs")
        End If

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\HTMLs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\HTMLs")
        End If

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\DOCS\ISOs") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\DOCS\ISOs")
        End If



        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".pdf"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\PDFs\" + Path.GetFileName(f), True)

                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If

                    ' Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")

                Case ".docx", ".doc"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\DOCs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If


                Case ".pptx", ".ppt"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\PPTs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If





                Case ".xlsx", ".xls"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\XLSs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If




                Case ".txt"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\TXTs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If


                Case ".iso"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\ISOs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If



                Case ".htm", ".html"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\HTMLs\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If




            End Select



        Next










        Return 0
    End Function

    Function OrganizeProjects()

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\C") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\C")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\CPP") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\CPP")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\VB") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\VB")
        End If


        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\PY") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\PY")
        End If

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\EXE") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\EXE")
        End If







        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()

                Case ".o", ".dev", ".ini", ".layout", ".win", ".h", ".rc", ".res"


                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If


                Case ".c"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\C\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If




                Case ".cpp"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\CPP\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If




            End Select

        Next
        Return 0
    End Function


    Function OrganizePrograms()

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PROGRAMS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PROGRAMS")
        End If





        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()

               



                Case ".exe"
                    File.SetAttributes(f, FileAttributes.Normal)
                    File.SetAttributes(f, FileAttributes.Temporary)

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROGRAMS\" + Path.GetFileName(f), True)
                    If File.Exists(f) = True Then
                        System.IO.File.Delete(f)
                    End If





            End Select

        Next
        Return 0
    End Function







    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OrganizeDocuments()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OrganizePictures()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        OrganizeArchives()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OrganizeProjects()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OrganizeMultimedias()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OrganizeArchives()
        OrganizeDocuments()
        OrganizeMultimedias()
        OrganizePictures()
        OrganizeProjects()
        OrganizePrograms()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OrganizePrograms()
    End Sub
End Class

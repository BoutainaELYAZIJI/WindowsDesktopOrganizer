Imports System.IO

Public Class Form1
    Dim FN As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


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



        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".pdf"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\PDFs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")

                Case ".docx", ".doc"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\DOCs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")


                Case ".pptx", ".ppt"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\PPTs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")





                Case ".xlsx", ".xls"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\XLSs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")




                Case ".txt"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\TXTs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")



                Case ".htm", ".html"

                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\DOCS\HTMLs\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")




            End Select



        Next
















    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\PHOTOS") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\PHOTOS")
        End If


        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".png", ".psd", ".jpg", ".gif", ".jpeg", "tif", ".bmp"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PHOTOS\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")





            End Select

        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Not Directory.Exists("C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES") Then
            Directory.CreateDirectory("C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES")
        End If


        Dim files() As String = Directory.GetFiles("C:\Users\" + Environment.UserName + "\Desktop\")

        For Each f As String In files
            FN = f
            Select Case Path.GetExtension(f).ToLower()
                Case ".zip", ".rar", ".7z"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\ARCHIVES\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")





            End Select

        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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

                Case ".o", ".dev", ".ini", ".layout", ".win"


                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")

              
                Case ".c"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\C\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")




                Case ".cpp"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\CPP\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")




                Case ".exe"


                    File.Copy(Path.GetFullPath(f), "C:\Users\" + Environment.UserName + "\Desktop\PROJECTS\EXE\" + Path.GetFileName(f), True)
                    Process.Start("cmd.exe", "/c " + "del " + """" + Path.GetFullPath(FN) + """")





            End Select

        Next
    End Sub
End Class

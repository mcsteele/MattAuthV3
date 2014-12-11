
''A program for assisting a Human Resources department.
'Matt Steele
'Josh Rogers
'Kevin Karel
'10 December 2014


Imports MySql.Data.MySqlClient

Public Class auth
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim LoginTry As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MySqlConn = New MySqlConnection
        'Because I'm lazy, the database box doesn't need to be entered.
        If TextBox_DB.Text = "" Then
            TextBox_DB.Text = "cs445"
        End If
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid='" & TextBox_UN.Text & "';password='" & TextBox_Pwd.Text & "';database='" & TextBox_DB.Text & "'"
        Try
            MySqlConn.Open()
            Form2.Show()
            'reset the LoginTry attempted login counter to initial state, due to valid login.
            LoginTry = 0


            Me.Hide()


            MySqlConn.Close()
            MySqlConn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show("Connection Refused. Please Check your login information, and try again.")
            LoginTry += 1
            'You get 3 login attempts and thats it, buddy
            If LoginTry > 2 Then
                MessageBox.Show("You are obviously an evil Hacker. DENIED!!!!")
                'close out everything.
                Me.Close()
                Me.Dispose()
            End If
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub


End Class

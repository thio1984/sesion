Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.UsuarioTableAdapter.FillByUsuario(Me.DS_Sesion.Usuario, UsernameTextBox.Text, PasswordTextBox.Text)
        If UsernameTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
            Try
                'MessageBox.Show(System.Net.Dns.GetHostName)
                Me.UsuarioTableAdapter.InicioSesion(UsernameTextBox.Text, System.Net.Dns.GetHostName)
                Me.Visible = False
                Form1.ShowDialog()
                Me.UsuarioTableAdapter.CerrarSesion(UsernameTextBox.Text, System.Net.Dns.GetHostName)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Su sesión se encuetra activada", "Error")
                Me.UsuarioTableAdapter.CerrarSesion(UsernameTextBox.Text, System.Net.Dns.GetHostName)
            End Try
           
        Else
            MessageBox.Show("Usuario o contraseña invalido", "Error")
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_Sesion.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.DS_Sesion.Usuario)

    End Sub
End Class

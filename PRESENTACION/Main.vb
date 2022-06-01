Imports CLSEDatos
Module Main
    'Variables Globales
    Public BResultadoLogin As Boolean = False 'Resultado del proceso de Login
    Public StrConexion As String  'Contendra la cadena de conexion Resultado del Login
    Public Usuario As String = "FGUZMAN" 'Usuario de BD
    Public password As String = "EXFGUZMAN" 'Contraseña

    Public Basedatos As String = "sigmades"

    Public flag As Integer 'bandera para reutilizar catalogo empleados
    Public AccionFreeDay As Integer 'bandera accion 
    Public IdEmpleado As Integer
    Public Sub Main()



        Application.EnableVisualStyles()
        Application.DoEvents()

        Usuario = "rrhh"
        password = "exrh"
        'Empresa = "MACESA"
        StrConexion = "user id=fguzman;password=exfguzman;data source=sigmades"
        'StrConexion = "Provider=MSDAORA;Data Source=" & Basedatos & ";Persist Security Info=True;User ID=" & Usuario & ";Password=" & password & ";"

        'LLamada al formulario Inicial de la aplicacion Login
        'Dim LoginForm As New FrmLogin
        'Application.Run(frmLog)

        'If BResultadoLogin Then
        Dim MDIForm As New MDIPrincipal
        Application.Run(MDIForm)
        ''''''''''''''''''''''''''''''''''''''''''''''''
        'Else
        'nothing
        'End If
    End Sub

End Module

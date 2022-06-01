Imports CLSEDatos
Module Main
    'Variables Globales
    Public BResultadoLogin As Boolean = False 'Resultado del proceso de Login
    Public StrConexion As String  'Contendra la cadena de conexion Resultado del Login
    Public Usuario As String = "FGUZMAN" 'Usuario de BD
    Public password As String = "EXFGUZMAN" 'Contraseña

    Public vUsuario As String  '"MACESA" 'Variable Verificacion Permisos'
    Public vID_User As Integer  '23
    Public vEmpresa As String 'Variable Verificacion Empresa'
    Public vDB As String 'Variable Verificacion DB

    Public Empresa As String 'Nombre de la Empresa
    Public Idempresa As Integer
    Public Basedatos As String = "sigmades"
    Public Control As String = ""


    Public varCloseSoli As Integer

    '---------------VARIABLE VALIDACION ARTICULOS ESPECIALES----------------
    Public vEMPLEADO As String
    Public frmEmpVar As Int16

    '------------variables globales catalogo precios------------
    Public ID_PRICE As Integer

    Public trimArt As String
    Public vIntAct As Integer

    '------------------------Variable valida articulo Repetido-----------------------------------'
    Public cerrar As Int16

    '-----------------------------
    Public varBlockMsOpciones As Integer = 1

    '-----------------------------
    Public varSwitchCortes As Integer = 1
    '-----------------------------

    '-------------------------Variable valida tipo de microprestamo (normal - cambio de nomina)
    Public varTipoMicroP As Integer

    Public Sub Main()

        'Datos de los articulos disponibles

        Application.EnableVisualStyles()
        Application.DoEvents()
        'Modulo Global para cargar variables globales
        Usuario = "rrhh"
        password = "exrh"
        Empresa = "MACESA"
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
    Public Function fn_verifica_permiso(ByVal usuario As String, ByVal idpermiso As Integer) As Boolean
        Dim ad As New ClsAccesoBD(StrConexion)
        Dim resultado As Boolean = ad.ExecuteScalar("select COUNT(1) from RRHH.TBL_PERMISO_USUARIO A INNER JOIN RRHH.TBL_USUARIOS B ON B.ID_USUARIOS=A.ID_USUARIO WHERE B.USUARIO='" & usuario & "' AND A.ID_PERMISO=" & idpermiso & "")
        Return resultado
    End Function

    Public Function fn_verifica_ADMIN(ByVal usuario As String, ByVal TIPO As String) As Boolean
        Dim ad As New ClsAccesoBD(StrConexion)
        Dim resultado As Boolean = ad.ExecuteScalar("select COUNT(1) from RRHH.TBL_USUARIOS WHERE USUARIO='" & usuario & "' AND TIPOUSUARIO=" & TIPO & "")
        Return resultado
    End Function

End Module

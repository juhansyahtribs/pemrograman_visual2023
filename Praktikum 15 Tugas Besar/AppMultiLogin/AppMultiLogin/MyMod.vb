Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833876.xsph.ru/" & api_folder & "/users_api.php"
    Public datapengguna_api As String = "http://f0833876.xsph.ru/" & api_folder & "/datapengguna_api.php"
    Public Dashboard As New Form1
    Public FormDatapengguna As New Datapengguna
    Public LoginForm As New Login
    Public datapengguna_baru As Boolean = False
    Public user_baru As Boolean = False
    Public admin_role As Boolean = False
    Public datapengguna_role As Boolean = False
    Public login_valid As Boolean = False

End Module

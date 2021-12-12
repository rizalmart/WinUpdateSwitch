Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AutoCreateKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", 1, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", 0, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "AllowMUUpdateService", 1, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers", 1, RegistryValueKind.DWord)

        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Services\7971F918-A847-4430-9279-4A52D1EFE18D", "RegisteredWithAU", 1, RegistryValueKind.DWord)

        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update", "AUOptions", 1, RegistryValueKind.DWord)

        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload", 4, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsStore\WindowsUpdate", "AutoDownload", 4, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsStore", "AutoDownload", 4, RegistryValueKind.DWord)

        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "RestartNotificationsAllowed2", 1, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "AllowAutoWindowsUpdateDownloadOverMeteredNetwork", 1, RegistryValueKind.DWord)
        AutoCreateKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "IsExpedited", 0, RegistryValueKind.DWord)

        Me.chkautoupdateapps.Checked = CBool((Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload")) / 2) - 1)

        Me.chkautoupdate.Checked = Not CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate")))

        Me.cboupdateopt.SelectedIndex = Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update", "AUOptions")) - 1

        Me.chkincludedrv.Checked = Not CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate")))

        Me.chknotifyrestart.Checked = CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "RestartNotificationsAllowed2")))

        Me.chknoautoreboot.Checked = CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers")))

        Me.chkwuserver.Checked = CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "UseWUServer")))

        Me.chkupdatems.Checked = CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AllowMUUpdateService")))

        Me.chkdownloadmetered.Checked = CBool(Val(ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "AllowAutoWindowsUpdateDownloadOverMeteredNetwork")))

        Me.txtwuserver.Text = ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUServer")

        Me.txtwustatusserver.Text = ReadRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUStatusServer")


    End Sub


    Sub AutoCreateKey(ByVal Hive As RegistryHive, ByVal key1 As String, ByVal value1 As Object, ByVal data1 As Object, ByVal regkind As RegistryValueKind)

        Dim regkey As RegistryKey

        If System.Environment.Is64BitOperatingSystem = True Then
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default)
        End If

        Dim boolRet As Boolean

        Try

            boolRet = Array.IndexOf(regkey.OpenSubKey(key1, False).GetValueNames, value1) > -1

            If boolRet = False Then
                regkey.OpenSubKey(key1, True).SetValue(value1, data1, regkind)
                regkey.Close()
            End If

        Catch ex As Exception
            regkey.CreateSubKey(key1)
            regkey.OpenSubKey(key1, True).SetValue(value1, data1, regkind)
            regkey.Close()
        End Try



    End Sub

    Function ReadRegKey(ByVal Hive As RegistryHive, ByVal key1 As String, ByVal value1 As Object) As Object

        Dim regkey As RegistryKey

        If System.Environment.Is64BitOperatingSystem = True Then
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default)
        End If

        Dim x1 As Object

        Try
            x1 = regkey.OpenSubKey(key1, False).GetValue(value1)
            Return x1
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Sub WriteRegKey(ByVal Hive As RegistryHive, ByVal key1 As String, ByVal value1 As Object, ByVal data1 As Object, ByVal regkind As RegistryValueKind)

        Dim regkey As RegistryKey

        If System.Environment.Is64BitOperatingSystem = True Then
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default)
        End If

        Try
            regkey.OpenSubKey(key1, True).SetValue(value1, data1, regkind)
            regkey.Close()
        Catch ex As Exception
            regkey.CreateSubKey(key1)
            regkey.OpenSubKey(key1, True).SetValue(value1, data1, regkind)
            regkey.Close()
        End Try

    End Sub


    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click

        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsStore\WindowsUpdate", "AutoDownload", (Convert.ToInt32(Me.chkautoupdateapps.Checked) * 2) + 2, RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsStore", "AutoDownload", (Convert.ToInt32(Me.chkautoupdateapps.Checked) * 2) + 2, RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload", (Convert.ToInt32(Me.chkautoupdateapps.Checked) * 2) + 2, RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", Convert.ToInt32(Not Me.chkautoupdate.Checked), RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update", "AUOptions", cboupdateopt.SelectedIndex + 1, RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", cboupdateopt.SelectedIndex + 1, RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate", Convert.ToInt32(Not Me.chkincludedrv.Checked), RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", Convert.ToInt32(Not Me.chkincludedrv.Checked), RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "RestartNotificationsAllowed", Convert.ToInt32(Me.chknotifyrestart.Checked), RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "RestartNotificationsAllowed2", Convert.ToInt32(Me.chknotifyrestart.Checked), RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "AllowAutoWindowsUpdateDownloadOverMeteredNetwork", Convert.ToInt32(Me.chkdownloadmetered.Checked), RegistryValueKind.DWord)


        WriteRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers", Convert.ToInt32(Me.chknoautoreboot.Checked), RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "IsExpedited", 1 - Convert.ToInt32(Me.chknoautoreboot.Checked) / 1, RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "UseWUServer", Convert.ToInt32(Me.chkwuserver.Checked), RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsUpdate\AU", "AllowMUUpdateService", Convert.ToInt32(Me.chkupdatems.Checked), RegistryValueKind.DWord)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Services\7971F918-A847-4430-9279-4A52D1EFE18D", "RegisteredWithAU", Convert.ToInt32(Me.chkupdatems.Checked), RegistryValueKind.DWord)

        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUServer", Me.txtwuserver.Text, RegistryValueKind.String)
        WriteRegKey(RegistryHive.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUStatusServer", Me.txtwustatusserver.Text, RegistryValueKind.String)

        Me.Close()

    End Sub
End Class

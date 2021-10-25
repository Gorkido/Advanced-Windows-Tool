$ErrorActionPreference = 'SilentlyContinue'

	Write-Host "Showing tray icons..."
	Set-ItemProperty -Path "HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer" -Name "EnableAutoTray" -Type DWord -Value 0
	Write-Host "Done - Now showing all tray icons"
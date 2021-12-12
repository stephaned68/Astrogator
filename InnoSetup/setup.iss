; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Astrogator 2022"
#define MyAppVersion "1.0"
#define MyAppPublisher "Guilde Navyborg"
#define MyAppExeName "Astrogator.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0219126A-93FA-448F-B5FB-00D96746EA16}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=D:\projects\csharp\Astrogator\InnoSetup\output
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "..\bin\Publish\Astrogator.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Publish\Astrogator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Publish\Astrogator.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Publish\Astrogator.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Publish\Astrogator.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Publish\Data\starships.json"; DestDir: "{app}\Data"; Flags: ignoreversion
Source: "..\bin\Publish\Data\star-catalog.json"; DestDir: "{app}\Data"; Flags: ignoreversion
Source: "..\bin\Publish\Data\ship-classes.json"; DestDir: "{app}\Data"; Flags: ignoreversion
Source: "..\bin\Publish\Data\encounter-tables.json"; DestDir: "{app}\Data"; Flags: ignoreversion
Source: "C:\Windows\Fonts\GOTHIC.TTF"; DestDir: "{fonts}"; FontInstall: "Century Gothic"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\Windows\Fonts\GOTHICB.TTF"; DestDir: "{fonts}"; FontInstall: "Century Gothic Gras"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\Windows\Fonts\GOTHICBI.TTF"; DestDir: "{fonts}"; FontInstall: "Century Gothic Gras Italique"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\Windows\Fonts\GOTHICI.TTF"; DestDir: "{fonts}"; FontInstall: "Century Gothic Italique"; Flags: onlyifdoesntexist uninsneveruninstall

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


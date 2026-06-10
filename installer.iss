[Setup]
AppName=Gerador de E-mail
AppVersion=1.0
DefaultDirName={autopf}\Gerador de E-mail
DefaultGroupName=Gerador de E-mail

OutputDir=output
OutputBaseFilename=GeradorEmailSetup

Compression=lzma
SolidCompression=yes

WizardStyle=modern

SetupIconFile=icone.ico

[Files]
Source: "publish\GeradorEmail.exe"; DestDir: "{app}"
Source: "config.json"; DestDir: "{app}"

[Icons]
Name: "{group}\Gerador de E-mail"; Filename: "{app}\GeradorEmail.exe"

Name: "{autodesktop}\Gerador de E-mail"; Filename: "{app}\GeradorEmail.exe"

[Run]
Filename: "{app}\GeradorEmail.exe"; Description: "Abrir Gerador de E-mail"; Flags: nowait postinstall skipifsilent
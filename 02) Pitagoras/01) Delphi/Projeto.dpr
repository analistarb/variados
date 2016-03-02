program Projeto;

uses
  Forms,
  uModulo in 'uModulo.pas' {frmDados};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TfrmDados, frmDados);
  Application.Run;
end.

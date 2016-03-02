program Projeto;

uses
  Forms,
  uModulo in 'uModulo.pas' {frmDados},
  uLado in 'uLado.pas',
  uPoligono in 'uPoligono.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TfrmDados, frmDados);
  Application.Run;
end.

unit uModulo;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls, Math;

type
  TfrmDados = class(TForm)
    imgFundo: TImage;
    Panel2: TPanel;
    cmdVerificar: TButton;
    Panel1: TPanel;
    Label3: TLabel;
    Label1: TLabel;
    edtCompromisso: TEdit;
    procedure cmdVerificarClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmDados: TfrmDados;

implementation

{$R *.dfm}



procedure Verifica_Compromisso(dtDia: integer);
  var
  strCompromisso: string;
  wYear, wMonth, wDay: Word;
  dt : TDateTime;
  begin
    DecodeDate(Date, wYear, wMonth, wDay);
    dt := EncodeDate(wYear, wMonth, dtDia);

    if (dtDia = 5) then
    begin
      strCompromisso := 'Dia do rodizio';
    end;

    if ((dayofweek(dt) = 2) or (dayofweek(dt) = 4)) then
    begin
      if not (length(strCompromisso) = 0) then
      begin
        strCompromisso := strCompromisso + ', ';
      end;
      strCompromisso := strCompromisso + 'Aula de Tae Kwon Do';
     end;

    if (length(strCompromisso) = 0) then
      begin
      strCompromisso := 'Não existem agendamentos';
      end;
      ShowMessage(strCompromisso);
    end;


procedure TfrmDados.cmdVerificarClick(Sender: TObject);
begin
  Verifica_Compromisso(StrToInt(frmDados.edtCompromisso.Text));
end;



end.

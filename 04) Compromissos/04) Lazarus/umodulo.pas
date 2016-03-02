unit uModulo;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls,
  StdCtrls, Math;

type

  { TfrmDados }

  TfrmDados = class(TForm)
    cmdVerificar: TButton;
    edtCompromisso: TEdit;
    imgFundo: TImage;
    Label1: TLabel;
    Label3: TLabel;
    Panel1: TPanel;
    Panel2: TPanel;
    procedure cmdVerificarClick(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  frmDados: TfrmDados;

implementation

{$R *.lfm}

{ TfrmDados }



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




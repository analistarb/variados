unit uModulo;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls,
  StdCtrls, Math;

type

  { TfrmDados }

  TfrmDados = class(TForm)
    cmdCalcular: TButton;
    edtCateto1: TEdit;
    edtCateto2: TEdit;
    edtHipotenusa: TEdit;
    imgFundo: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Panel1: TPanel;
    Panel2: TPanel;
    procedure cmdCalcularClick(Sender: TObject);
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


function Pitagoras(cateto1: integer; cateto2: integer; hipotenusa: integer): Boolean;
var
  Valor1, Valor2: Double;

begin
  Valor1 := Power(cateto1, 2) + Power(cateto2, 2);
  Valor2 := Power(hipotenusa, 2);

  if (Valor1 = Valor2) then
  begin
    result := true;
  end
  else
  begin
    result := false;
  end;
end;


procedure TfrmDados.cmdCalcularClick(Sender: TObject);
begin
  ShowMessage(BoolToStr(Pitagoras(StrToInt(edtCateto1.Text), StrToInt(edtCateto2.Text), StrToInt(edtHipotenusa.Text)),True));
end;

end.




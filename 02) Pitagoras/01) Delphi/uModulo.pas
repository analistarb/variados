unit uModulo;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls, Math;

type
  TfrmDados = class(TForm)
    imgFundo: TImage;
    Panel2: TPanel;
    cmdCalcular: TButton;
    Panel1: TPanel;
    Label3: TLabel;
    Label2: TLabel;
    Label1: TLabel;
    edtHipotenusa: TEdit;
    edtCateto2: TEdit;
    edtCateto1: TEdit;
    procedure cmdCalcularClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmDados: TfrmDados;

implementation

{$R *.dfm}

function Pitagoras(cateto1: integer; cateto2: integer; hipotenusa: integer): bool;
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

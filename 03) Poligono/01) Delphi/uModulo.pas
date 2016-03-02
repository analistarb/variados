unit uModulo;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls, Math, uLado, uPoligono;

type
  TfrmDados = class(TForm)
    imgFundo: TImage;
    Panel2: TPanel;
    cmdCalcular: TButton;
    Panel1: TPanel;
    Label3: TLabel;
    Label2: TLabel;
    Label1: TLabel;
    edtTamanhoLados: TEdit;
    edtNomeLados: TEdit;
    edtPoligono: TEdit;
    procedure cmdCalcularClick(Sender: TObject);
  private
    Lado: TLado;
    Poligono: TPoligono;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmDados: TfrmDados;

implementation

{$R *.dfm}




Function SplitString(Texto, Separador : String) : TStrings;
var
    strItem       : String;
    ListaAuxUTILS : TStrings;
    NumCaracteres,
    TamanhoSeparador,
    I : Integer;
Begin
    ListaAuxUTILS    := TStringList.Create;
    strItem          := '';
    NumCaracteres    := Length(Texto);
    TamanhoSeparador := Length(Separador);
    I                := 1;
    While I <= NumCaracteres Do
      Begin
        If (Copy(Texto,I,TamanhoSeparador) = Separador) or (I = NumCaracteres) Then
          Begin
            if (I = NumCaracteres) then strItem := strItem + Texto[I];
            ListaAuxUTILS.Add(trim(strItem));
            strItem := '';
            I := I + (TamanhoSeparador-1);
          end
        Else
            strItem := strItem + Texto[I];

        I := I + 1;
      End;
    SplitString := ListaAuxUTILS;
end;




procedure TfrmDados.cmdCalcularClick(Sender: TObject);
var
i: Integer;
strMensagem: String;
StrArray: TStrings;
StrArray2: TStrings;

begin

StrArray := SplitString(frmDados.edtNomeLados.Text, ',');
StrArray2 := SplitString(frmDados.edtTamanhoLados.Text, ',');


if (StrArray.Count = StrArray2.Count) then
begin

Poligono := TPoligono.Create;
Poligono.Nome := edtPoligono.Text;


for i := 0 to StrArray.Count-1 do
begin
  Lado := TLado.Create;
  Lado.Nome := StrArray[i];
  Lado.Tamanho := StrToInt(StrArray2[i]);
  Poligono.setItens(i,Lado);
  strMensagem := strMensagem + #13 + ' (Lado: ' + Poligono.Itens[i].Nome + ', tamanho: ' + IntToStr(Poligono.Itens[i].Tamanho) + ')';
end;


strMensagem := 'Poligono: ' + Poligono.Nome + #13 + strMensagem;
strMensagem := strMensagem + #13 + #13 + 'Quantidade de Lados: ' + IntToStr(Poligono.GetQtdLados);
ShowMessage(strMensagem);

end

Else
begin
ShowMessage('Atenção, favor preencher as duas listas com a mesma quantidade de itens');
end;


end;




end.

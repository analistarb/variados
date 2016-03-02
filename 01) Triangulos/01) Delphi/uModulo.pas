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
    edtZ: TEdit;
    edtY: TEdit;
    edtX: TEdit;
    imgBox: TImage;
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




procedure Limpar();
begin
            frmDados.edtX.Text := '';
            frmDados.edtY.Text := '';
            frmDados.edtZ.Text := '';
            frmDados.imgBox.Visible := False;
            ShowMessage('Atenção, estas medidas não formam um triângulo');
end;




procedure ImagemTriangulo(Indice: Integer);
  var
  strDiretorio : string;
         begin
            strDiretorio := GetCurrentDir;

            if (Indice = 0) then
            begin
              frmDados.imgBox.Picture.LoadFromFile(strDiretorio + '\equilatero.jpg');
              frmDados.imgBox.Left := 336;
              frmDados.imgBox.Top := 64;
            end
            else if (Indice = 1) then
            begin
              frmDados.imgBox.Picture.LoadFromFile(strDiretorio + '\escaleno.jpg');
              frmDados.imgBox.Left := 306;
              frmDados.imgBox.Top := 81;
            end
            else if (Indice = 2) then
            begin
              frmDados.imgBox.Picture.LoadFromFile(strDiretorio + '\isosceles.jpg');
              frmDados.imgBox.Left := 375;
              frmDados.imgBox.Top := 56;
            end;
            frmDados.imgBox.Visible := True;
        end;



procedure Triangulos(X: integer ; Y: integer ; Z: integer);
begin
            if ((X < Y + Z) and (Y < X + Z) and (Z < X + Y)) then
            begin
                if ((X = Y) and (X = Z)) then
                begin
                    ShowMessage('Triângulo Equilátero');
                    ImagemTriangulo(0);
                end
                else if ((X <> Y) and (X <> Z) and (Y <> Z)) then
                begin
                    ShowMessage('Triângulo Escaleno');
                    ImagemTriangulo(1);
                end
                else
                begin
                    ShowMessage('Triângulo Isósceles');
                    ImagemTriangulo(2);
                end
            end
            else
            begin
                Limpar();
            end
end;





procedure TfrmDados.cmdCalcularClick(Sender: TObject);
begin
  Triangulos(StrToInt(edtX.Text), StrToInt(edtY.Text), StrToInt(edtZ.Text));
end;


end.

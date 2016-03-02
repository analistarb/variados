unit uPoligono;

interface
 
uses Classes, Variants, uLado,
  Dialogs, Forms, StrUtils;

type
  TPoligono = class(TLado)
  private
    FNome: string;

    FItens: TList;
    function getItens(index: Integer): TLado;

  public
    property Nome      :String  read FNome  write FNome;
    procedure setItens(index: Integer; const value: TLado);
    property Itens[index: Integer]: TLado read getItens
      write setItens; default;

    function GetQtdLados: Integer;
    constructor Create;
    
  end;

implementation

{ TPoligono }


 

constructor TPoligono.Create;
begin
  inherited Create;
  FItens := TList.Create;
end;
 
function TPoligono.getItens(index: Integer): TLado;
begin
  result := FItens.Items[index];
end;
 
procedure TPoligono.setItens(index: Integer; const value: TLado);
begin
  FItens.Insert(index,value);
end;




function TPoligono.GetQtdLados: Integer;
begin
  result := FItens.Count;
end;









end.

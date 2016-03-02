unit uLado;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

type
  TLado = class(TObject)
  private
    FNome: string;
    FTamanho: integer;

  public
    property Nome      :String  read FNome  write FNome;
    property Tamanho   :integer  read FTamanho  write FTamanho;
  end;

implementation

{ TLado }



end.


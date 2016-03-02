select 
max("Valor") valor_maximo, min("Valor") valor_minimo

from "TbHistoricoPreco"

group by "IdProduto"
having (max("Valor") - min("Valor")) > 10
order by (max("Valor") - min("Valor")) ASC


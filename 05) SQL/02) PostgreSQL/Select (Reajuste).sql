select 
t1."Nome",t1."Tipo",t2."Valor",t2."Data"
from "TbProduto" t1
inner join "TbHistoricoPreco" t2
on t1."IdProduto"=t2."IdProduto"
where 
t2."Data" > '01/01/2014'
order by
t2."Data" desc,t1."Tipo",t1."Nome"


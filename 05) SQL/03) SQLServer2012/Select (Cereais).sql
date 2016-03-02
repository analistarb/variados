select 
t1.IdProduto,t1.Nome,t1.Tipo,t2.Data,t2.Valor

from TbProduto t1
inner join TbHistoricoPreco t2
on t1.IdProduto=t2.IdProduto

where 
t1.Tipo = 'Cereais'

order by
t2.Data,t1.Nome,t2.Valor

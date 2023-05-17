select
p.Name
, c.Name
from Products p
left join ProductCategory pc on pc.IDProduct = p.IDProduct
left join Categories c on c.IDCategory = pc.IDCategory
order by p.Name, c.Name
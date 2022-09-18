use Products;
select p.Name as ProductName, c.Name as Category 
from dbo.Products as p
	left join dbo.Product_ProductCategory as pc on pc.ProductId = p.Id	
	left join dbo.ProductCategories as c on pc.ProductCategoryId = c.Id;
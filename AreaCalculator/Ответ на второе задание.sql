USE ProdsCategories;
GO
SELECT p.Name, c.Name
FROM Category c
JOIN Prod_Categ pc on c.ID = pc.Category_ID
RIGHT JOIN Product p on pc.Prod_ID = p.ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllProducts
AS
BEGIN
    select products.product_id, products.product_name, brand_name, category_name, products.model_year, products.list_price
    from production.products as products, production.brands as brands, production.categories as categories 
    where products.category_id = categories.category_id and products.brand_id = brands.brand_id
END
GO
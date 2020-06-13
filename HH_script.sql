SELECT Name.Product, Name.Category FROM Product, Category
WHERE ((Id_Category.Product = Id_Category.Category) or (Id_Category.Product = NULL) 
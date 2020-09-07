       CREATE TABLE products(
    int product_id NOT NULL PRIMARY KEY,
    varchar(255) product_name,
    int price,
    varchar(255) creationDate
                );
                
//Table used to break many to many relationship
CREATE TABLE product_categories(
    int product_categories_key NOT NULL PRIMARY KEY,
    int product_id,
    int  category_id,
        product_id int FOREIGN KEY REFERENCES products(product_id),
        category_id int FOREIGN KEY REFERENCES categories(category_id)
);

CREATE TABLE categories(
    int category_id NOT NULL PRIMARY KEY,
    varchar(255) category_name,
    varchar(10) flag_name NOT NULL CHECK (flag_name IN('public', 'private'))
);


SELECT DISTINCT
        p.product_id,
        p.product_name,
        p.price,
        p.creationDate,
FROM product_categories pc
JOIN product p
        ON pc.product_id = p.product_id
WHERE pc.category_id IN
(SELECT category_id FROM categories WHERE flag_name = "public") HAVING COUNT(*) > 5
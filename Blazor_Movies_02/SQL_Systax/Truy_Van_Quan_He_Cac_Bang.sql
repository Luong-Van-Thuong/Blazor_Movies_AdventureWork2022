SELECT  
    fk.name AS Khoa_Chinh,
    tp.name AS Bang_Chua_Khoa_Chinh,
    cp.name AS Cot_Chua_Khoa_Chinh,
    tr.name AS Bang_Chua_Khoa_Ngoai,
    cr.name AS Cot_Chua_Khoa_Ngoai
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
INNER JOIN 
    sys.tables AS tp ON fkc.parent_object_id = tp.object_id
INNER JOIN 
    sys.columns AS cp ON fkc.parent_object_id = cp.object_id AND fkc.parent_column_id = cp.column_id
INNER JOIN 
    sys.tables AS tr ON fkc.referenced_object_id = tr.object_id
INNER JOIN 
    sys.columns AS cr ON fkc.referenced_object_id = cr.object_id AND fkc.referenced_column_id = cr.column_id
ORDER BY 
    tp.name, cp.name;
-------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------

SELECT  
    fk.name AS Khoa_Chinh,
    tp.name AS Bang_Chua_Khoa_Chinh,
    cp.name AS Cot_Chua_Khoa_Chinh,
    tr.name AS Bang_Chua_Khoa_Ngoai,
    cr.name AS Cot_Chua_Khoa_Ngoai
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
INNER JOIN 
    sys.tables AS tp ON fkc.parent_object_id = tp.object_id
INNER JOIN 
    sys.columns AS cp ON fkc.parent_object_id = cp.object_id AND fkc.parent_column_id = cp.column_id
INNER JOIN 
    sys.tables AS tr ON fkc.referenced_object_id = tr.object_id
INNER JOIN 
    sys.columns AS cr ON fkc.referenced_object_id = cr.object_id AND fkc.referenced_column_id = cr.column_id
	WHERE tp.name = 'Product'
ORDER BY 
    tp.name, cp.name;



-- se selecciona la bd
use proyectoing
SELECT * FROM usuario
-- creacion de usuarios --
insert into usuario (nombre,password,rol,permisos) VALUES ("ProdeinAdmin","admin123","admin","todos");
insert into usuario (nombre,password,rol,permisos) VALUES ("JoseYepes","jose123","user","todos");
insert into usuario (nombre,password,rol,permisos) VALUES ("JuanYepes","juan123","user","consultar");

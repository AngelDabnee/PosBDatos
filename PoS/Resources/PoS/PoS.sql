CREATE DATABASE IF NOT EXISTS pos;
USE pos;
CREATE TABLE IF NOT EXISTS productos(codigo VARCHAR(20) NOT NULL UNIQUE, nombre VARCHAR(255) NOT NULL, precio FLOAT(6,2) UNSIGNED NOT NULL);
INSERT INTO productos (codigo, nombre, precio) VALUES
("0","Iphone 13","199.99"),
("1","Laptop","155.55"),
("2","Mouse","14.55"),
("3","CPU","500.00"),
("4","Monitor","468.58"),
("5","Monster","34.59"),
("6","Coca Cola","19.95"),
("7","Sabritones","65.66"),
("8","Tarjeta del Yugio","100.10"),
("9","Agua Purificada","13.99");

INSERT INTO productos (codigo,nombre,precio) VALUES
("10", "Hamburguesa Clasica", "7.99"),
("11", "Hamburguesa con Queso", "8.99"),
('12', 'Hamburguesa Doble', "9.99"),
('13', 'Hamburguesa con Tocino', "9.99"),
('14', 'Hamburguesa Vegetariana', "6.99"),
('15', 'Hamburguesa de Pollo', "7.99"),
('16', 'Hamburguesa Picante', "8.99"),
('17', 'Hamburguesa BBQ', "8.99"),
('18', 'Hamburguesa Hawaiana', "9.99"),
('19', 'Hamburguesa Mexicana', "9.99"),
('20', 'Hamburguesa con Champinones', "8.99"),
('21', 'Hamburguesa con Cebolla Caramelizada', "8.99"),
('21', 'Hamburguesa con Huevo Frito', "8.99"),
('22', 'Hamburguesa de Pavo', "7.99"),
('23', 'Hamburguesa con Salsa Especial',"8.99");


CREATE TABLE ventas (
	id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE,
	fecha DATE,
	hora TIME
);

CREATE TABLE ventas_detalle(id_venta BIGINT UNSIGNED NOT NULL, cantidad INT UNSIGNED NOT NULL, nombre varchar(255) NOT NULL, precio FLOAT(6,2) UNSIGNED NOT NULL, FOREIGN KEY(id_venta) REFERENCES ventas(id));
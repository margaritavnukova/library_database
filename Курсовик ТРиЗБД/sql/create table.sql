CREATE TABLE Библиотекарь 
(
	id_библиотекаря INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ФИО	VARCHAR(100) NOT NULL,
	Должность VARCHAR(25)
)

CREATE TABLE Читатель
(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Телефон VARCHAR(16) NOT NULL,
	ФИО	VARCHAR(100) NOT NULL
)

CREATE TABLE Карточка_выдачи_печатного_издания
(
	id_выдачи INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_библиотекаря INT NOT NULL,
	id_издания INT NOT NULL,
	id_читателя INT NOT NULL,
	Дата_и_время_выдачи DATETIME NOT NULL,
	Срок_выдачи INT NOT NULL
)

CREATE TABLE Печатное_издание
(
	id_издания INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Название VARCHAR(100) NOT NULL,
	Автор VARCHAR(100) NOT NULL,
	Издательство VARCHAR(100),
	Год_издания DATE
)

CREATE TABLE Размещение_печатного_издания
(
	id_издания INT NOT NULL,
	Номер_зала INT NOT NULL,
	Номер_полки INT
)

CREATE TABLE Пользователь
(
	Логин VARCHAR(25) PRIMARY KEY NOT NULL,
	Пароль VARCHAR(25) NOT NULL
)
CREATE TABLE ������������ 
(
	id_������������ INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	���	VARCHAR(100) NOT NULL,
	��������� VARCHAR(25)
)

CREATE TABLE ��������
(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	������� VARCHAR(16) NOT NULL,
	���	VARCHAR(100) NOT NULL
)

CREATE TABLE ��������_������_���������_�������
(
	id_������ INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_������������ INT NOT NULL,
	id_������� INT NOT NULL,
	id_�������� INT NOT NULL,
	����_�_�����_������ DATETIME NOT NULL,
	����_������ INT NOT NULL
)

CREATE TABLE ��������_�������
(
	id_������� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	�������� VARCHAR(100) NOT NULL,
	����� VARCHAR(100) NOT NULL,
	������������ VARCHAR(100),
	���_������� DATE
)

CREATE TABLE ����������_���������_�������
(
	id_������� INT NOT NULL,
	�����_���� INT NOT NULL,
	�����_����� INT
)

CREATE TABLE ������������
(
	����� VARCHAR(25) PRIMARY KEY NOT NULL,
	������ VARCHAR(25) NOT NULL
)
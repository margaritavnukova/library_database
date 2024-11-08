ALTER TABLE Читатель
ADD CONSTRAINT READER_PHONENUMBER
CHECK 
	(Телефон like 
	'+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]')

ALTER TABLE ��������
ADD CONSTRAINT READER_PHONENUMBER
CHECK 
	(������� like 
	'+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]')

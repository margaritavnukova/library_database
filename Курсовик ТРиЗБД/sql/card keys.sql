ALTER TABLE ��������_������_���������_�������
ADD CONSTRAINT CARD_LIBRERIAN
FOREIGN KEY (id_������������)
REFERENCES ������������ (id_������������)

ALTER TABLE ��������_������_���������_�������
ADD CONSTRAINT CARD_BOOK
FOREIGN KEY (id_�������)
REFERENCES ��������_������� (id_�������)

ALTER TABLE ��������_������_���������_�������
ADD CONSTRAINT CARD_READER
FOREIGN KEY (id_��������)
REFERENCES �������� (id)
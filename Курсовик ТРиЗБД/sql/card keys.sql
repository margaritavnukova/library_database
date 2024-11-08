ALTER TABLE Карточка_выдачи_печатного_издания
ADD CONSTRAINT CARD_LIBRERIAN
FOREIGN KEY (id_библиотекаря)
REFERENCES Библиотекарь (id_библиотекаря)

ALTER TABLE Карточка_выдачи_печатного_издания
ADD CONSTRAINT CARD_BOOK
FOREIGN KEY (id_издания)
REFERENCES Печатное_издание (id_издания)

ALTER TABLE Карточка_выдачи_печатного_издания
ADD CONSTRAINT CARD_READER
FOREIGN KEY (id_читателя)
REFERENCES Читатель (id)
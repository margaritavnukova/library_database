ALTER TABLE Размещение_печатного_издания
ADD CONSTRAINT PLACE_BOOK
FOREIGN KEY (id_издания)
REFERENCES Печатное_издание (id_издания)

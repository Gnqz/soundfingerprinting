use FingerprintsDb
go
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME ='CK_ISRC_NotEmpty')
BEGIN
	ALTER TABLE Tracks DROP CONSTRAINT CK_ISRC_NotEmpty
END
GO
ALTER TABLE Tracks ALTER COLUMN ISRC VARCHAR(50) NULL
GO

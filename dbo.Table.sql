CREATE TABLE [dbo].[PCTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PC Name] NCHAR(100) NULL, 
    [OS Name] NCHAR(100) NULL, 
    [OS Version] FLOAT NULL, 
    [RAM] INT NULL, 
    [CPU Model] NCHAR(100) NULL, 
    [CPU Cores] INT NULL, 
    [CPU Clock] FLOAT NULL, 
    [GFX Model] NCHAR(100) NULL, 
    [GFX Ram] INT NULL, 
    [MB Manufacturer] NCHAR(100) NULL, 
    [MB Model] NCHAR(100) NULL, 
    [MB Chipset] NCHAR(100) NULL, 
    [BIOS Model] NCHAR(100) NULL, 
    [BIOS Version] NCHAR(100) NULL, 
    [BIOS Date] DATE NULL, 
    [Date] DATE NULL, 
    [USER] NCHAR(100) NULL
)

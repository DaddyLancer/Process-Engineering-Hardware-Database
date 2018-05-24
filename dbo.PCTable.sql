CREATE TABLE [dbo].[PCTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PC Name] NCHAR(100) NOT NULL, 
    [OS Name] NCHAR(100) NOT NULL, 
    [OS Version] FLOAT NULL, 
    [RAM] INT NOT NULL, 
    [CPU Model] NCHAR(100) NOT NULL, 
    [CPU Cores] INT NULL, 
    [CPU Clock] FLOAT NOT NULL, 
    [GFX Model] NCHAR(100) NOT NULL, 
    [GFX Ram] INT NULL, 
    [MB Manufacturer] NCHAR(100) NULL, 
    [MB Model] NCHAR(100) NULL, 
    [MB Chipset] NCHAR(100) NULL, 
    [BIOS Model] NCHAR(100) NULL, 
    [BIOS Version] NCHAR(100) NULL, 
    [BIOS Date] DATE NULL, 
    [Date] DATE NOT NULL, 
    [USER] NCHAR(100) NULL
)

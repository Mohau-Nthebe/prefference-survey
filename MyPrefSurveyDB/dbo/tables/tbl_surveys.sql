CREATE TABLE [dbo].[tbl_surveys]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[surname]    NVARCHAR (50) NOT NULL,
    [firstnames] NVARCHAR (50) NOT NULL,
    [contact]    NVARCHAR (50) NOT NULL,
    [date]       NVARCHAR (50) NOT NULL,
    [age]        INT           NOT NULL,
	[pizza]       BIT NOT NULL,
    [pasta]       BIT NOT NULL,
    [papwors]     BIT NOT NULL,
    [chickenstir] BIT NOT NULL,
    [beefstir]    BIT NOT NULL,
    [other]       BIT NOT NULL,
	[eatOut]      INT NOT NULL,
    [watchMovies] INT NOT NULL,
    [watchTv]     INT NOT NULL,
    [radio]       INT NOT NULL,
)

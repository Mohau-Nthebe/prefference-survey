CREATE TABLE [dbo].[tbl_results]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[totsurv] INT        NOT NULL,
    [aveage]  FLOAT (53) NOT NULL,
    [maxage]  INT        NOT NULL,
    [minage]  INT        NOT NULL,
	[pizza] FLOAT (53) NULL,
    [pasta] FLOAT (53) NULL,
    [paw]   FLOAT (53) NULL,
	[eatout] FLOAT (53) NOT NULL,
    [movies] FLOAT (53) NOT NULL,
    [tv]     FLOAT (53) NOT NULL,
    [radio]  FLOAT (53) NOT NULL,
)

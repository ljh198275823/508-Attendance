if not exists (SELECT * FROM dbo.syscolumns WHERE name ='ShortName' AND id = OBJECT_ID(N'[dbo].[TAShifts]')) 
BEGIN
	exec ('alter table TAShifts add ShortName nvarchar(50)')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='ShiftDuration' AND id = OBJECT_ID(N'[dbo].[TAShifts]')) 
BEGIN
	exec ('alter table TAShifts add ShiftDuration int')
    exec ('update TAShifts set ShiftDuration=480')
    exec ('alter table TAShifts alter column ShiftDuration int not null')
end
go

--add by bruce 2013-9-12
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Memo' AND id = OBJECT_ID(N'[dbo].[TAOperator]')) 
BEGIN
	exec ('alter table TAOperator add Memo nvarchar(200)')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Memo' AND id = OBJECT_ID(N'[dbo].[TARoles]')) 
BEGIN
	exec ('alter table TARoles add Memo nvarchar(200)')
end
go

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShifts]') AND type in (N'U'))
Begin
    exec ('delete TAShifts where ShiftID=''FREE''')
	exec ('alter table TAShifts alter column AllowLate int not null')
	exec ('alter table TAShifts alter column BeforeStartTime int not null')
	exec ('alter table TAShifts alter column AllowEarly int not null')
	exec ('alter table TAShifts alter column AfterEndTime int not null')
	exec ('alter table TAShifts alter column MinOTTime int not null')
	exec ('alter table TAShifts alter column MaxOTTime int not null')
end
go

--增加几个表和视图
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAHoliday]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAHoliday](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[WeekendToWorkDay1] [datetime] NULL,
	[WeekendToWorkDay2] [datetime] NULL,
	[WeekendToWorkDay3] [datetime] NULL,
	[WeekendToWorkDay4] [datetime] NULL,
	[WeekendToWorkDay5] [datetime] NULL,
	[WeekendToWorkDay6] [datetime] NULL,
	[Memo] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAVacationType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAVacationType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAVacationType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAOTType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAOTType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Multiple] [decimal](10, 2) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAOTType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAAttendanceResult]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAAttendanceResult](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NOT NULL,
	[StaffName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ShiftDate] [datetime] NOT NULL,
	[ShiftID] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ShiftName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[SheetType] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Category] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[OnDutyTime] [datetime] NULL,
	[OffDutyTime] [datetime] NULL,
	[ShiftTime] [decimal](10, 4) NOT NULL,
	[Present] [decimal](10, 4) NOT NULL,
	[Absent] [decimal](10, 4) NOT NULL,
	[BeLate] [decimal](10, 4) NOT NULL,
	[LeaveEarly] [decimal](10, 4) NOT NULL,
	[OTTime] [decimal](10, 4) NOT NULL,
	[Result] [tinyint] NOT NULL,
	[Modified] [bit] NOT NULL,
	[Modifier] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[ModifiedTime] [datetime] NULL,
	[Approval] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Memo] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_TAStaffAttendanceResult] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAManualLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAManualLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[ReadDateTime] [datetime] NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[IsManual] [bit] NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAManualLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TATripType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TATripType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TATripType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TASheet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TASheet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SheetID] [uniqueidentifier] NOT NULL,
	[SheetType] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[StaffID] [int] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[StartTime] [nvarchar](50) NOT NULL,
	[EndTime] [nvarchar](50) NOT NULL,
    [Duration][int] not null,
	[Category] [nvarchar](50) NOT NULL,
	[Header] [nvarchar](50) NULL,
	[Manager] [nvarchar](50) NULL,
	[HR] [nvarchar](50) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAVacationSheet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_TAAttendanceLog]'))
begin
	drop view View_TAAttendanceLog
end
go
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_TAAttendanceLog]
AS
SELECT DISTINCT a.LogID AS ID, b.UserID AS StaffID, a.UserName AS StaffName, a.ReadDateTime, a.ReaderID, a.ReaderName, ''False'' AS IsManual, NULL AS Memo
FROM         dbo.FullLog AS a INNER JOIN
                      dbo.Card AS b ON a.CardID = b.CardID
UNION
SELECT     ID, StaffID, StaffName, ReadDateTime, ReaderID, NULL AS Expr1, IsManual, Memo
FROM         dbo.TAManualLog
' 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_TAStaff]'))
begin 
	drop view View_TAStaff
end
go
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_TAStaff]
AS
SELECT     a.UserID AS ID, a.UserName AS Name, RIGHT(''000'' + RTRIM(LTRIM(STR(a.DepartmentID, 3))), 3) AS ACSDepartmentID, c.DepartmentID, b.DepartmentName AS Memo, 
                      a.UserPosition
FROM         dbo.UserList AS a INNER JOIN
                      dbo.Department AS b ON a.DepartmentID = b.DepartmentID LEFT OUTER JOIN
                      dbo.TAUserDept AS c ON a.UserID = c.UserID
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[View_TAShiftArrange]'))
begin 
	drop view View_TAShiftArrange
end
go
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[View_TAShiftArrange]
AS
SELECT     UserID, ShiftID, CONVERT(datetime, SUBSTRING(ShiftDate, 1, 4) + ''-'' + SUBSTRING(ShiftDate, 5, 2) + ''-'' + SUBSTRING(ShiftDate, 7, 2), 20) AS ShiftDate
FROM         dbo.TAShiftArrange
' 
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShiftArrangeTemplate]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShiftArrangeTemplate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
    [Options] [tinyint] not null,
	[Value] [nvarchar](4000) NULL,
    [Memo] [nvarchar](200) null,
 CONSTRAINT [PK_ShiftArrangeTemplate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAParameter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAParameter](
	[ID] [nvarchar](200) NOT NULL,
	[Value] [nvarchar](4000) NULL,
 CONSTRAINT [PK_TAParameter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
go





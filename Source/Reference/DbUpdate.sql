
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAAbsentItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAAbsentItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ResultID] [uniqueidentifier] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TAAbsentItem] PRIMARY KEY CLUSTERED 
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
	[ID] [uniqueidentifier] NOT NULL,
	[StaffID] [int] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[ShiftDate] [datetime] NOT NULL,
	[ShiftID] [nvarchar](50) NOT NULL,
	[ShiftName] [nvarchar](50) NULL,
	[SheetType] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
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
	[Modifier] [nvarchar](50) NULL,
	[ModifiedTime] [datetime] NULL,
	[Approval] [nvarchar](50) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAAttendanceResult] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TASheetItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TASheetItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SheetID] [uniqueidentifier] NOT NULL,
	[StartTime] [nvarchar](50) NOT NULL,
	[NextDay] [bit] NOT NULL,
	[EndTime] [nvarchar](50) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TASheetItem] PRIMARY KEY CLUSTERED 
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
SELECT     row_number() over(order by StaffID asc)as ID, StaffID, StaffName, ReadDateTime, ReaderID, ReaderName, IsManual, Memo
FROM         (SELECT DISTINCT b.UserID AS StaffID, a.UserName AS StaffName, a.ReadDateTime, a.ReaderID, a.ReaderName, convert(bit,0) as IsManual, NULL AS Memo
                       FROM          dbo.FullLog AS a INNER JOIN
                                              dbo.Card AS b ON a.CardID = b.CardID) AS derivedtbl_1
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShiftItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShiftItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShiftID] [nvarchar](50) NOT NULL,
	[StartTime] [varchar](6) NOT NULL,
	[NextDay] [bit] NOT NULL,
	[EndTime] [varchar](6) NOT NULL,
	[AllowLateTime] [decimal](10, 4) NOT NULL,
	[AllowLeaveEarlyTime] [decimal](10, 4) NOT NULL,
	[BeforeStartTime] [decimal](10, 4) NOT NULL,
	[AfterEndTime] [decimal](10, 4) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TAShiftItem] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShift]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShift](
	[ShiftID] [varchar](4) NOT NULL,
	[ShiftName] [varchar](50) NOT NULL,
	[ShortName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAShift] PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAResignStaff]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAResignStaff](
	[StaffID] [int] NOT NULL,
 CONSTRAINT [PK_TAResignStaff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
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
                      a.UserPosition,  CONVERT(BIT, (CASE WHEN d .staffID IS NULL THEN 0 ELSE 1 END)) AS Resigned
FROM         dbo.UserList AS a INNER JOIN
                      dbo.Department AS b ON a.DepartmentID = b.DepartmentID LEFT OUTER JOIN
                      dbo.TAUserDept AS c ON a.UserID = c.UserID LEFT OUTER JOIN
                      dbo.TAResignStaff AS d ON a.UserID = d.StaffID
' 
GO





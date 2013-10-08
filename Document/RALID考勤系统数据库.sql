--RALID 考勤系统
--建立数据库脚本
/******************************************************************************************
  Database scripts of T&A Tables
  By Curtis 2005/03/15
*******************************************************************************************/

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAAccesslogTemp]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAAccesslogTemp]
GO


CREATE TABLE [dbo].[TAAccesslogTemp] (
	[ReadDate] [varchar] (8) NULL ,
	[ReadTime] [varchar] (6) NULL 
) ON [PRIMARY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TADepartment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TADepartment]
GO


CREATE TABLE [dbo].[TADepartment] (
	[DepartmentID] [varchar] (40) NOT NULL ,
	[DepartmentName] [varchar] (50) NOT NULL ,
	[Descr] [varchar] (100) NULL ,
	[TopDeptID] [varchar] (40) NOT NULL ,
	[PreDeptID] [varchar] (40) NOT NULL ,
	[DeptLevel] [int] NOT NULL ,
	[ISBottom] [bit] NULL ,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TADepartment] WITH NOCHECK ADD 
	CONSTRAINT [PK_TADepartment] PRIMARY KEY  CLUSTERED 
	(
		[DepartmentID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAFunctionList]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAFunctionList]
GO

CREATE TABLE [dbo].[TAFunctionList] (
	[FunctionID] [int] NOT NULL ,
	[FunctionResNo] [int] NULL ,
	[FunctionType] [varchar] (3) NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAFunctionList] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAFunctionList] PRIMARY KEY  CLUSTERED 
	(
		[FunctionID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAModifiedResult]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAModifiedResult]
GO

CREATE TABLE [dbo].[TAModifiedResult] (
	[UserID] [int] NOT NULL ,
	[ShiftDate] [varchar] (8) NOT NULL ,	
	[ShiftID] [varchar] (4) NOT NULL ,
	[OnDutyTime] [varchar] (6) NULL ,	
	[OffDutyTime] [varchar] (6) NULL ,
	[BeLateTime] [int] NULL ,
	[LeaveEarlyTime] [int] NULL ,
	[OTTime] [int] NULL ,
	[ShiftResult] [varchar] (20) NULL ,
	[OtherOnDutyTime] [varchar] (6) NULL ,	
	[OtherOffDutyTime] [varchar] (6) NULL ,
	[TotWorkTime] [int] NULL,
	[Modified] [bit] NULL ,
	[Modifier] [varchar] (20) NOT NULL ,
	[ModifiedTime] [DateTime] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAModifiedResult] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAModifiedResult] PRIMARY KEY  CLUSTERED 
	(
		[UserID],[ShiftDate],[ShiftID],[ModifiedTime]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAOperator]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAOperator]
GO

CREATE TABLE [dbo].[TAOperator] (
	[OperatorID] [varchar] (20) NOT NULL ,
	[Password] [varchar] (20) NULL ,
	[RealName] [varchar] (20) NULL ,
	[UserID] [int] NULL ,
	[RoleID] [varchar] (20) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAOperator] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAOperator] PRIMARY KEY  CLUSTERED 
	(
		[OperatorID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAOperatorDept]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAOperatorDept]
GO

CREATE TABLE [dbo].[TAOperatorDept] (
	[OperatorID] [varchar] (20) NOT NULL ,
	[DepartmentID] [varchar] (40) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAOperatorDept] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAOperatorDept] PRIMARY KEY  CLUSTERED 
	(
		[OperatorID],[DepartmentID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAOptions]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAOptions]
GO

CREATE TABLE [dbo].[TAOptions] (
	[OptionName] [varchar] (20) NOT NULL ,
	[OptionValue] [varchar] (50) NULL ,
	[DefaultValue] [varchar] (50) NULL ,
	[OptionDescr] [varchar] (200) NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAOptions] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAOptions] PRIMARY KEY  CLUSTERED 
	(
		[OptionName]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAReaderList]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAReaderList]
GO

CREATE TABLE [dbo].[TAReaderList] (
	[ReaderID] [varchar] (5) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAReaderList] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAReaderList] PRIMARY KEY  CLUSTERED 
	(
		[ReaderID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAResult]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAResult]
GO

CREATE TABLE [dbo].[TAResult] (
	[UserID] [int] NOT NULL ,
	[ShiftDate] [varchar] (8) NOT NULL ,	
	[ShiftID] [varchar] (4) NOT NULL ,
	[OnDutyTime] [varchar] (6) NULL ,	
	[OffDutyTime] [varchar] (6) NULL ,
	[BeLateTime] [int] NULL ,
	[LeaveEarlyTime] [int] NULL ,
	[OTTime] [int] NULL ,
	[ShiftResult] [varchar] (20) NULL ,
	[OtherOnDutyTime] [varchar] (6) NULL ,	
	[OtherOffDutyTime] [varchar] (6) NULL ,
	[TotWorkTime] [int] NULL,
	[Modified] [bit] NULL ,
	[Modifier] [varchar] (20) NOT NULL ,
	[ModifiedTime] [DateTime] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAResult] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAResult] PRIMARY KEY  CLUSTERED 
	(
		[UserID],[ShiftDate],[ShiftID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TARoles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TARoles]
GO

CREATE TABLE [dbo].[TARoles] (
	[RoleID] [varchar] (20) NOT NULL ,
	[RoleName] [varchar] (50) NOT NULL ,
	[RWPermission] [varchar] (200) NULL ,
	[RPermission] [varchar] (200) NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TARoles] WITH NOCHECK ADD 
	CONSTRAINT [PK_TARoles] PRIMARY KEY  CLUSTERED 
	(
		[RoleID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAShiftArrange]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAShiftArrange]
GO

CREATE TABLE [dbo].[TAShiftArrange] (
	[UserID] [int] NOT NULL ,
	[ShiftID] [varchar] (4) NOT NULL ,
	[ShiftDate] [varchar] (8) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAShiftArrange] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAShiftArrange] PRIMARY KEY  CLUSTERED 
	(
		[UserID],[ShiftID],[ShiftDate]
	)  ON [PRIMARY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAShiftArrangeSelfDef]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAShiftArrangeSelfDef]
GO

CREATE TABLE [dbo].[TAShiftArrangeSelfDef] (
	[UserID] [int] NOT NULL ,
	[ShiftID] [varchar] (4) NOT NULL ,
	[ShiftDate] [varchar] (8) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAShiftArrangeSelfDef] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAShiftArrangeSelfDef] PRIMARY KEY  CLUSTERED 
	(
		[UserID],[ShiftID],[ShiftDate]
	)  ON [PRIMARY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAShifts]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAShifts]
GO

CREATE TABLE [dbo].[TAShifts] (
	[ShiftID] [varchar] (4) NOT NULL ,
	[ShiftName] [varchar] (50) NOT NULL ,
	[StartTime] [varchar] (6) NOT NULL ,
	[AllowLate] [int] NULL ,
	[BeforeStartTime] [int] NULL ,
	[EndTime] [varchar] (6) NOT NULL ,
	[NextDay] [bit] NOT NULL ,
	[AllowEarly] [int] NULL ,
	[AfterEndTime] [int] NULL ,
	[AllowOT] [bit] NOT NULL ,
	[MaxOTTime] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAShifts] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAShifts] PRIMARY KEY  CLUSTERED 
	(
		[ShiftID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAUserDept]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TAUserDept]
GO

CREATE TABLE [dbo].[TAUserDept] (
	[UserID] [int] NOT NULL ,
	[DepartmentID] [varchar] (40) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TAUserDept] WITH NOCHECK ADD 
	CONSTRAINT [PK_TAUserDept] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TASpecialUser]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TASpecialUser]
GO

CREATE TABLE [dbo].[TASpecialUser] (
	[UserID] [int] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TASpecialUser] WITH NOCHECK ADD 
	CONSTRAINT [PK_TASpecialUser] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

--Initialize Role and Operator
INSERT INTO TARoles(ROLEID,ROLENAME,RWPERMISSION,RPERMISSION)
SELECT 'SysAdmin','System Administrator','',''
INSERT INTO TAOPERATOR(OPERATORID,PASSWORD,REALNAME,USERID,ROLEID)
SELECT 'Admin','9MR','Administrator','','SysAdmin'

--Function list
DELETE TAFUNCTIONLIST
INSERT TAFUNCTIONLIST SELECT 1,1315,'DBM'--Department
INSERT TAFUNCTIONLIST SELECT 2,1316,'DBM'--User
INSERT TAFUNCTIONLIST SELECT 3,1317,'DBM'--Check point
INSERT TAFUNCTIONLIST SELECT 4,1318,'T&A'--Shift management
INSERT TAFUNCTIONLIST SELECT 5,1319,'T&A'--shift arrange
INSERT TAFUNCTIONLIST SELECT 6,1320,'T&A'--personal shift
INSERT TAFUNCTIONLIST SELECT 7,1321,'T&A'--Generate result
INSERT TAFUNCTIONLIST SELECT 8,1322,'T&A'--Delete shift
INSERT TAFUNCTIONLIST SELECT 9,1323,'SEC'--Operator
INSERT TAFUNCTIONLIST SELECT 10,1324,'SEC'--role
INSERT TAFUNCTIONLIST SELECT 11,1325,'REP'--Summary report
INSERT TAFUNCTIONLIST SELECT 12,1326,'REP'--General view
INSERT TAFUNCTIONLIST SELECT 13,1327,'OPT'--Options
INSERT TAFUNCTIONLIST SELECT 15,1338,'OPT'--Delete result
INSERT TAFUNCTIONLIST SELECT 16,1339,'OPT'--Delete plan
INSERT TAFUNCTIONLIST SELECT 14,1328,'DBM'--Special user

INSERT INTO TAShifts(ShiftID,ShiftName,StartTime,AllowLate,BeforeStartTime,EndTime,NextDay,AllowEarly,AfterEndTime,AllowOT,MaxOTTime)
VALUES('FREE','FREE',0,0,0,0,0,0,0,0,0)

Print '创建考勤数据库成功'
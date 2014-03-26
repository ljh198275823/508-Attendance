--2014-3-12 
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='CardID' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add CardID nvarchar(50) null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Password' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add Password nvarchar(50) null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='VerifyCode' AND id = OBJECT_ID(N'[dbo].[TADeviceInfo]')) 
BEGIN
	exec ('alter table TADeviceInfo add VerifyCode tinyint null')
	exec ('update TADeviceInfo set VerifyCode=0')
	exec ('alter table TADeviceInfo alter column VerifyCode tinyint not null')
end
go

--2014-3-13
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='IsAdmin' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add IsAdmin bit null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='LastEventDt' AND id = OBJECT_ID(N'[dbo].[TADeviceInfo]')) 
BEGIN
	exec ('alter table TADeviceInfo add LastEventDt datetime null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='FPVersion' AND id = OBJECT_ID(N'[dbo].[TADeviceInfo]')) 
BEGIN
	exec ('alter table TADeviceInfo add FPVersion int null')
end
go

--2014-3-21
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='VerifyCode' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add VerifyCode tinyint null')
	exec ('update TAStaff set VerifyCode=0')
	exec ('alter table TAStaff alter column VerifyCode tinyint not null')
end
go

--2014-3-26 人员信息增加几个唯一值约束
if not exists (SELECT * FROM sysobjects WHERE name = 'Certificate_Uniq' and type='K')
BEGIN
	exec('alter table tastaff add constraint Certificate_Uniq Unique ([Certificate])')
END

if not exists (SELECT * FROM sysobjects WHERE name = 'CardID_Uniq' and type='K')
BEGIN
	exec('alter table tastaff add constraint CardID_Uniq Unique (CardID)')
END
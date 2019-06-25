/*========================================================== 1. 创建数据库 ===========================================================*/
USE [master]
GO

--删除数据库
EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'Agents'
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'Agents')
Begin
DROP DATABASE [GreatWall]
End
GO

--创建数据库
CREATE DATABASE [GreatWall]
GO

/*========================================================== 2. 创建架构 ===========================================================*/
USE [Agents]
GO

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Agents')
DROP SCHEMA [Agents]
GO
CREATE SCHEMA [Agents] AUTHORIZATION [dbo]
GO


IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Distributions')
DROP SCHEMA [Distributions]
GO
CREATE SCHEMA [Distributions] AUTHORIZATION [dbo]
GO


IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Finances')
DROP SCHEMA [Finances]
GO
CREATE SCHEMA [Finances] AUTHORIZATION [dbo]
GO


IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Members')
DROP SCHEMA [Members]
GO
CREATE SCHEMA [Members] AUTHORIZATION [dbo]
GO


IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Sales')
DROP SCHEMA [Sales]
GO
CREATE SCHEMA [Sales] AUTHORIZATION [dbo]
GO


/*==========================================================3. 创建表======================================================================*/
if exists (select 1
            from  sysobjects
           where  id = object_id('Finances.Account')
            and   type = 'U')
   drop table Finances.Account
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Finances.Account (
   AccountId            uniqueidentifier     not null,
   Balance              decimal(18,2)        not null,
   FreezeBalance        decimal(18,2)        null,
   Enabled              bit                  not null,
   Note                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_ACCOUNT primary key (AccountId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Finances.Account') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Finances', 'table', 'Account' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '账户', 
   'schema', 'Finances', 'table', 'Account'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AccountId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'AccountId'

end


execute sp_addextendedproperty 'MS_Description', 
   '账户标识',
   'schema', 'Finances', 'table', 'Account', 'column', 'AccountId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Balance')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'Balance'

end


execute sp_addextendedproperty 'MS_Description', 
   '余额',
   'schema', 'Finances', 'table', 'Account', 'column', 'Balance'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FreezeBalance')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'FreezeBalance'

end


execute sp_addextendedproperty 'MS_Description', 
   '冻结余额',
   'schema', 'Finances', 'table', 'Account', 'column', 'FreezeBalance'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Enabled')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'Enabled'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用',
   'schema', 'Finances', 'table', 'Account', 'column', 'Enabled'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Finances', 'table', 'Account', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Finances', 'table', 'Account', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Finances', 'table', 'Account', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Finances', 'table', 'Account', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Finances', 'table', 'Account', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Finances', 'table', 'Account', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.Account')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'Account', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Finances', 'table', 'Account', 'column', 'Version'
go



if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Finances.AccountDetail') and o.name = 'FK_ACCOUNTD_REFERENCE_ACCOUNT')
alter table Finances.AccountDetail
   drop constraint FK_ACCOUNTD_REFERENCE_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Finances.AccountDetail')
            and   type = 'U')
   drop table Finances.AccountDetail
go

/*==============================================================*/
/* Table: AccountDetail                                         */
/*==============================================================*/
create table Finances.AccountDetail (
   AccountDetailId      uniqueidentifier     not null,
   AccountId            uniqueidentifier     not null,
   TradeType            nvarchar(50)         not null,
   BeforeBalance        decimal(18,2)        not null,
   TradeMoney           decimal(18,2)        not null,
   AfterBalance         decimal(18,2)        not null,
   TradeTime            datetime             not null,
   BusinessId           nvarchar(50)         not null,
   Note                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_ACCOUNTDETAIL primary key (AccountDetailId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Finances.AccountDetail') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Finances', 'table', 'AccountDetail' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '账户明细', 
   'schema', 'Finances', 'table', 'AccountDetail'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AccountDetailId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AccountDetailId'

end


execute sp_addextendedproperty 'MS_Description', 
   '账户明细标识',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AccountDetailId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AccountId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AccountId'

end


execute sp_addextendedproperty 'MS_Description', 
   '账户标识',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AccountId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TradeType')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeType'

end


execute sp_addextendedproperty 'MS_Description', 
   '交易类型',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeType'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BeforeBalance')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'BeforeBalance'

end


execute sp_addextendedproperty 'MS_Description', 
   '交易前余额',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'BeforeBalance'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TradeMoney')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeMoney'

end


execute sp_addextendedproperty 'MS_Description', 
   '交易金额',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeMoney'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AfterBalance')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AfterBalance'

end


execute sp_addextendedproperty 'MS_Description', 
   '交易后余额',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'AfterBalance'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TradeTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '交易时间',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'TradeTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BusinessId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'BusinessId'

end


execute sp_addextendedproperty 'MS_Description', 
   '业务编号',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'BusinessId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Finances.AccountDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Finances', 'table', 'AccountDetail', 'column', 'Version'
go

alter table Finances.AccountDetail
   add constraint FK_ACCOUNTD_REFERENCE_ACCOUNT foreign key (AccountId)
      references Finances.Account (AccountId)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Agents.Agent')
            and   type = 'U')
   drop table Agents.Agent
go

/*==============================================================*/
/* Table: Agent                                                 */
/*==============================================================*/
create table Agents.Agent (
   AgentId              uniqueidentifier     not null,
   Code                 nvarchar(20)         not null,
   Name                 nvarchar(200)        not null,
   ParentId             uniqueidentifier     null,
   AgentPath            nvarchar(200)        null,
   AlipayAccount        nvarchar(200)        null,
   WeChatAccount        nvarchar(200)        null,
   Email                nvarchar(200)        null,
   Mobile               nvarchar(20)         not null,
   Bank                 int                  null,
   BankUser             nvarchar(20)         null,
   BandNumber           nvarchar(50)         null,
   QQ                   nvarchar(12)         null,
   Enabled              bit                  not null,
   CashOutTotal         decimal(18,2)        null,
   Note                 nvarchar(500)        null,
   State                int                  not null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_AGENT primary key (AgentId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Agents.Agent') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Agents', 'table', 'Agent' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '代理', 
   'schema', 'Agents', 'table', 'Agent'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'AgentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理标识',
   'schema', 'Agents', 'table', 'Agent', 'column', 'AgentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Code'

end


execute sp_addextendedproperty 'MS_Description', 
   '编码',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Name'

end


execute sp_addextendedproperty 'MS_Description', 
   '姓名',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ParentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'ParentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '上级代理标识',
   'schema', 'Agents', 'table', 'Agent', 'column', 'ParentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentPath')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'AgentPath'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理路径',
   'schema', 'Agents', 'table', 'Agent', 'column', 'AgentPath'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AlipayAccount')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'AlipayAccount'

end


execute sp_addextendedproperty 'MS_Description', 
   '支付宝帐号',
   'schema', 'Agents', 'table', 'Agent', 'column', 'AlipayAccount'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'WeChatAccount')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'WeChatAccount'

end


execute sp_addextendedproperty 'MS_Description', 
   '个人微信号',
   'schema', 'Agents', 'table', 'Agent', 'column', 'WeChatAccount'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Email')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Email'

end


execute sp_addextendedproperty 'MS_Description', 
   '邮箱',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Email'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Mobile')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Mobile'

end


execute sp_addextendedproperty 'MS_Description', 
   '手机',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Mobile'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Bank')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Bank'

end


execute sp_addextendedproperty 'MS_Description', 
   '开户银行',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Bank'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BankUser')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'BankUser'

end


execute sp_addextendedproperty 'MS_Description', 
   '开户名',
   'schema', 'Agents', 'table', 'Agent', 'column', 'BankUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BandNumber')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'BandNumber'

end


execute sp_addextendedproperty 'MS_Description', 
   '银行卡号',
   'schema', 'Agents', 'table', 'Agent', 'column', 'BandNumber'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'QQ')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'QQ'

end


execute sp_addextendedproperty 'MS_Description', 
   '联系QQ',
   'schema', 'Agents', 'table', 'Agent', 'column', 'QQ'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Enabled')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Enabled'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Enabled'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CashOutTotal')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'CashOutTotal'

end


execute sp_addextendedproperty 'MS_Description', 
   '提现总额',
   'schema', 'Agents', 'table', 'Agent', 'column', 'CashOutTotal'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'State')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'State'

end


execute sp_addextendedproperty 'MS_Description', 
   '状态',
   'schema', 'Agents', 'table', 'Agent', 'column', 'State'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Agents', 'table', 'Agent', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Agents', 'table', 'Agent', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Agents', 'table', 'Agent', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Agents', 'table', 'Agent', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Agents', 'table', 'Agent', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.Agent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'Agent', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Agents', 'table', 'Agent', 'column', 'Version'
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Agents.OutCash') and o.name = 'FK_OUTCASH_REFERENCE_AGENT')
alter table Agents.OutCash
   drop constraint FK_OUTCASH_REFERENCE_AGENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Agents.OutCash')
            and   type = 'U')
   drop table Agents.OutCash
go

/*==============================================================*/
/* Table: OutCash                                               */
/*==============================================================*/
create table Agents.OutCash (
   OutCashId            uniqueidentifier     not null,
   AgentId              uniqueidentifier     not null,
   Money                decimal(18,2)        not null,
   Note                 nvarchar(500)        null,
   PayType              int                  not null,
   CardId               nvarchar(200)        not null,
   State                int                  not null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_OUTCASH primary key (OutCashId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Agents.OutCash') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Agents', 'table', 'OutCash' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '提现', 
   'schema', 'Agents', 'table', 'OutCash'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OutCashId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'OutCashId'

end


execute sp_addextendedproperty 'MS_Description', 
   '账户标识',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'OutCashId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'AgentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理标识',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'AgentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Money')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Money'

end


execute sp_addextendedproperty 'MS_Description', 
   '提现金额',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Money'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PayType')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'PayType'

end


execute sp_addextendedproperty 'MS_Description', 
   '支付类型',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'PayType'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CardId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CardId'

end


execute sp_addextendedproperty 'MS_Description', 
   '用户卡号',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CardId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'State')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'State'

end


execute sp_addextendedproperty 'MS_Description', 
   '状态',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'State'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Agents.OutCash')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Agents', 'table', 'OutCash', 'column', 'Version'
go

alter table Agents.OutCash
   add constraint FK_OUTCASH_REFERENCE_AGENT foreign key (AgentId)
      references Agents.Agent (AgentId)
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Members.Member') and o.name = 'FK_MEMBER_REFERENCE_AGENT')
alter table Members.Member
   drop constraint FK_MEMBER_REFERENCE_AGENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Members.Member')
            and   type = 'U')
   drop table Members.Member
go

/*==============================================================*/
/* Table: Member                                                */
/*==============================================================*/
create table Members.Member (
   MemberId             uniqueidentifier     not null,
   MemberOutId          nvarchar(50)         not null,
   AgentId              uniqueidentifier     null,
   AgentPath            nvarchar(200)        null,
   Name                 nvarchar(200)        null,
   Mobile               nvarchar(20)         null,
   IPAddress            nvarchar(20)         null,
   Type                 int                  not null,
   VipEndTime           datetime             null,
   ClientOS             int                  null,
   ClientCode           nvarchar(100)        null,
   ConsumptionTotal     decimal(18,2)        null,
   FirstTime            datetime             not null,
   RegisterTime         datetime             not null,
   Note                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_MEMBER primary key (MemberId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Members.Member') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Members', 'table', 'Member' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '会员', 
   'schema', 'Members', 'table', 'Member'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MemberId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'MemberId'

end


execute sp_addextendedproperty 'MS_Description', 
   '会员标识',
   'schema', 'Members', 'table', 'Member', 'column', 'MemberId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MemberOutId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'MemberOutId'

end


execute sp_addextendedproperty 'MS_Description', 
   '会员外部标识',
   'schema', 'Members', 'table', 'Member', 'column', 'MemberOutId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'AgentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理标识',
   'schema', 'Members', 'table', 'Member', 'column', 'AgentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentPath')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'AgentPath'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理路径',
   'schema', 'Members', 'table', 'Member', 'column', 'AgentPath'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'Name'

end


execute sp_addextendedproperty 'MS_Description', 
   '姓名',
   'schema', 'Members', 'table', 'Member', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Mobile')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'Mobile'

end


execute sp_addextendedproperty 'MS_Description', 
   '手机',
   'schema', 'Members', 'table', 'Member', 'column', 'Mobile'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IPAddress')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'IPAddress'

end


execute sp_addextendedproperty 'MS_Description', 
   'IP',
   'schema', 'Members', 'table', 'Member', 'column', 'IPAddress'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Type')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'Type'

end


execute sp_addextendedproperty 'MS_Description', 
   '类型',
   'schema', 'Members', 'table', 'Member', 'column', 'Type'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VipEndTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'VipEndTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '会员到期时间',
   'schema', 'Members', 'table', 'Member', 'column', 'VipEndTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ClientOS')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'ClientOS'

end


execute sp_addextendedproperty 'MS_Description', 
   '设备系统',
   'schema', 'Members', 'table', 'Member', 'column', 'ClientOS'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ClientCode')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'ClientCode'

end


execute sp_addextendedproperty 'MS_Description', 
   '设备硬件号',
   'schema', 'Members', 'table', 'Member', 'column', 'ClientCode'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ConsumptionTotal')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'ConsumptionTotal'

end


execute sp_addextendedproperty 'MS_Description', 
   '消费总额',
   'schema', 'Members', 'table', 'Member', 'column', 'ConsumptionTotal'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'FirstTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'FirstTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '首次访问时间',
   'schema', 'Members', 'table', 'Member', 'column', 'FirstTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RegisterTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'RegisterTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '注册时间',
   'schema', 'Members', 'table', 'Member', 'column', 'RegisterTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Members', 'table', 'Member', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Members', 'table', 'Member', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Members', 'table', 'Member', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Members', 'table', 'Member', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Members', 'table', 'Member', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Members', 'table', 'Member', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.Member')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'Member', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Members', 'table', 'Member', 'column', 'Version'
go

alter table Members.Member
   add constraint FK_MEMBER_REFERENCE_AGENT foreign key (AgentId)
      references Agents.Agent (AgentId)
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Members.DownloadLog') and o.name = 'FK_DOWNLOAD_REFERENCE_AGENT')
alter table Members.DownloadLog
   drop constraint FK_DOWNLOAD_REFERENCE_AGENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Members.DownloadLog')
            and   type = 'U')
   drop table Members.DownloadLog
go

/*==============================================================*/
/* Table: DownloadLog                                           */
/*==============================================================*/
create table Members.DownloadLog (
   DownloadLogId        uniqueidentifier     not null,
   AgentId              uniqueidentifier     null,
   IPAddress            nvarchar(20)         null,
   ClientOS             int                  null,
   ClientCode           nvarchar(100)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_DOWNLOADLOG primary key (DownloadLogId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Members.DownloadLog') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Members', 'table', 'DownloadLog' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '下载记录', 
   'schema', 'Members', 'table', 'DownloadLog'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DownloadLogId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'DownloadLogId'

end


execute sp_addextendedproperty 'MS_Description', 
   '下载记录标识',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'DownloadLogId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'AgentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理标识',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'AgentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IPAddress')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'IPAddress'

end


execute sp_addextendedproperty 'MS_Description', 
   'IP',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'IPAddress'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ClientOS')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'ClientOS'

end


execute sp_addextendedproperty 'MS_Description', 
   '设备系统',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'ClientOS'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ClientCode')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'ClientCode'

end


execute sp_addextendedproperty 'MS_Description', 
   '设备硬件号',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'ClientCode'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Members.DownloadLog')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Members', 'table', 'DownloadLog', 'column', 'Version'
go

alter table Members.DownloadLog
   add constraint FK_DOWNLOAD_REFERENCE_AGENT foreign key (AgentId)
      references Agents.Agent (AgentId)
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Sales."Order"') and o.name = 'FK_ORDER_REFERENCE_MEMBER')
alter table Sales."Order"
   drop constraint FK_ORDER_REFERENCE_MEMBER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Sales."Order"')
            and   type = 'U')
   drop table Sales."Order"
go

/*==============================================================*/
/* Table: "Order"                                               */
/*==============================================================*/
create table Sales."Order" (
   OrderId              uniqueidentifier     not null,
   MemberId             uniqueidentifier     not null,
   Money                decimal(18,2)        not null,
   Type                 nvarchar(100)        not null,
   PayType              int                  null,
   State                int                  not null,
   OrderTime            datetime             not null,
   PayTime              datetime             null,
   Extend               nvarchar(max)        null,
   Note                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_ORDER primary key (OrderId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Sales."Order"') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Sales', 'table', 'Order' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '订单', 
   'schema', 'Sales', 'table', 'Order'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OrderId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'OrderId'

end


execute sp_addextendedproperty 'MS_Description', 
   '订单标识',
   'schema', 'Sales', 'table', 'Order', 'column', 'OrderId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MemberId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'MemberId'

end


execute sp_addextendedproperty 'MS_Description', 
   '会员标识',
   'schema', 'Sales', 'table', 'Order', 'column', 'MemberId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Money')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'Money'

end


execute sp_addextendedproperty 'MS_Description', 
   '金额',
   'schema', 'Sales', 'table', 'Order', 'column', 'Money'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Type')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'Type'

end


execute sp_addextendedproperty 'MS_Description', 
   '类型(app,web)',
   'schema', 'Sales', 'table', 'Order', 'column', 'Type'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PayType')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'PayType'

end


execute sp_addextendedproperty 'MS_Description', 
   '支付方式',
   'schema', 'Sales', 'table', 'Order', 'column', 'PayType'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'State')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'State'

end


execute sp_addextendedproperty 'MS_Description', 
   '状态',
   'schema', 'Sales', 'table', 'Order', 'column', 'State'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OrderTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'OrderTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '下单时间',
   'schema', 'Sales', 'table', 'Order', 'column', 'OrderTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PayTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'PayTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '付款时间',
   'schema', 'Sales', 'table', 'Order', 'column', 'PayTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Extend')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'Extend'

end


execute sp_addextendedproperty 'MS_Description', 
   '扩展字段',
   'schema', 'Sales', 'table', 'Order', 'column', 'Extend'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Sales', 'table', 'Order', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Sales', 'table', 'Order', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Sales', 'table', 'Order', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Sales', 'table', 'Order', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Sales', 'table', 'Order', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Sales', 'table', 'Order', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Sales."Order"')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Sales', 'table', 'Order', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Sales', 'table', 'Order', 'column', 'Version'
go

alter table Sales."Order"
   add constraint FK_ORDER_REFERENCE_MEMBER foreign key (MemberId)
      references Members.Member (MemberId)
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Distributions.Commission') and o.name = 'FK_COMMISSI_REFERENCE_AGENT')
alter table Distributions.Commission
   drop constraint FK_COMMISSI_REFERENCE_AGENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Distributions.Commission') and o.name = 'FK_COMMISSI_REFERENCE_ORDER')
alter table Distributions.Commission
   drop constraint FK_COMMISSI_REFERENCE_ORDER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Distributions.Commission')
            and   type = 'U')
   drop table Distributions.Commission
go

/*==============================================================*/
/* Table: Commission                                            */
/*==============================================================*/
create table Distributions.Commission (
   CommissionId         uniqueidentifier     not null,
   AgentId              uniqueidentifier     not null,
   OrderId              uniqueidentifier     not null,
   Type                 int                  not null,
   Money                decimal(18,2)        not null,
   State                int                  not null,
   Note                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_COMMISSION primary key (CommissionId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Distributions.Commission') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Distributions', 'table', 'Commission' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '佣金', 
   'schema', 'Distributions', 'table', 'Commission'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CommissionId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CommissionId'

end


execute sp_addextendedproperty 'MS_Description', 
   '佣金标识',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CommissionId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AgentId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'AgentId'

end


execute sp_addextendedproperty 'MS_Description', 
   '代理标识',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'AgentId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OrderId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'OrderId'

end


execute sp_addextendedproperty 'MS_Description', 
   '订单标识',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'OrderId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Type')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Type'

end


execute sp_addextendedproperty 'MS_Description', 
   '类型',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Type'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Money')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Money'

end


execute sp_addextendedproperty 'MS_Description', 
   '金额',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Money'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'State')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'State'

end


execute sp_addextendedproperty 'MS_Description', 
   '状态',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'State'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Note')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Note'

end


execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Note'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Commission')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Distributions', 'table', 'Commission', 'column', 'Version'
go

alter table Distributions.Commission
   add constraint FK_COMMISSI_REFERENCE_AGENT foreign key (AgentId)
      references Agents.Agent (AgentId)
go

alter table Distributions.Commission
   add constraint FK_COMMISSI_REFERENCE_ORDER foreign key (OrderId)
      references Sales."Order" (OrderId)
go


if exists (select 1
            from  sysobjects
           where  id = object_id('Distributions.DomainType')
            and   type = 'U')
   drop table Distributions.DomainType
go

/*==============================================================*/
/* Table: DomainType                                            */
/*==============================================================*/
create table Distributions.DomainType (
   DomainTypeId         uniqueidentifier     not null,
   Name                 nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_DOMAINTYPE primary key (DomainTypeId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Distributions.DomainType') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Distributions', 'table', 'DomainType' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '域名分类', 
   'schema', 'Distributions', 'table', 'DomainType'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DomainTypeId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'DomainTypeId'

end


execute sp_addextendedproperty 'MS_Description', 
   '域名分类标识',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'DomainTypeId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'Name'

end


execute sp_addextendedproperty 'MS_Description', 
   '名称',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.DomainType')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Distributions', 'table', 'DomainType', 'column', 'Version'
go


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Distributions.Domain') and o.name = 'FK_DOMAIN_REFERENCE_DOMAINTY')
alter table Distributions.Domain
   drop constraint FK_DOMAIN_REFERENCE_DOMAINTY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Distributions.Domain')
            and   type = 'U')
   drop table Distributions.Domain
go

/*==============================================================*/
/* Table: Domain                                                */
/*==============================================================*/
create table Distributions.Domain (
   DomainId             uniqueidentifier     not null,
   DomainTypeId         uniqueidentifier     not null,
   Domain               nvarchar(500)        null,
   CreationTime         datetime             null,
   CreatorId            uniqueidentifier     null,
   LastModificationTime datetime             null,
   LastModifierId       uniqueidentifier     null,
   IsDeleted            bit                  not null,
   Version              timestamp            null,
   constraint PK_DOMAIN primary key (DomainId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Distributions.Domain') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'schema', 'Distributions', 'table', 'Domain' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '域名', 
   'schema', 'Distributions', 'table', 'Domain'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DomainId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'DomainId'

end


execute sp_addextendedproperty 'MS_Description', 
   '域名标识',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'DomainId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DomainTypeId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'DomainTypeId'

end


execute sp_addextendedproperty 'MS_Description', 
   '域名分类标识',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'DomainTypeId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Domain')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'Domain'

end


execute sp_addextendedproperty 'MS_Description', 
   '域名',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'Domain'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'CreationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建时间',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'CreationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreatorId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'CreatorId'

end


execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'CreatorId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModificationTime')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'LastModificationTime'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改时间',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'LastModificationTime'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastModifierId')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'LastModifierId'

end


execute sp_addextendedproperty 'MS_Description', 
   '最后修改人',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'LastModifierId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsDeleted')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'IsDeleted'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否删除',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'IsDeleted'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('Distributions.Domain')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Version')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'schema', 'Distributions', 'table', 'Domain', 'column', 'Version'

end


execute sp_addextendedproperty 'MS_Description', 
   '版本号',
   'schema', 'Distributions', 'table', 'Domain', 'column', 'Version'
go

alter table Distributions.Domain
   add constraint FK_DOMAIN_REFERENCE_DOMAINTY foreign key (DomainTypeId)
      references Distributions.DomainType (DomainTypeId)
go

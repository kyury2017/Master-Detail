USE [MasterDetails1]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO [user2]
GO
USE [MasterDetails1]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_datawriter] TO [user2]
GO
USE [MasterDetails1]
GO
ALTER ROLE [Users] ADD MEMBER [user2]
GO

USE [MasterDetails1]
GO
CREATE ROLE [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[MasterAdd] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[MasterChange] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[DetailChange] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[ErrorAdd] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[DetailAdd] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[MasterDelete] TO [Users]
GO
use [MasterDetails1]
GO
GRANT SELECT ON [dbo].[MastersView] TO [Users]
GO
use [MasterDetails1]
GO
GRANT EXECUTE ON [dbo].[DetailDelete] TO [Users]
GO
use [MasterDetails1]
GO
GRANT SELECT ON [dbo].[DetailsView] TO [Users]
GO

CREATE TABLE [dbo].[tblStaffLogins]
(
	[Password] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(50) NULL
)

INSERT INTO tblStaffLogins(UserName, Password) VALUES ('Portway', 'swim');
INSERT INTO tblStaffLogins(UserName, Password) VALUES ('Admin', 'warhammer');

CREATE TABLE [dbo].[tblMembers]
(
	[MemberName] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [MemberClub] VARCHAR(50) NULL,
    [MemberType] VARCHAR(50) NULL,
    [MemberAge] VARCHAR(50) NULL,
    [MemberTime] DATETIME NULL,
    [MemberGender] VARCHAR(50) NULL,
    [Stroke] VARCHAR(50) NULL
)

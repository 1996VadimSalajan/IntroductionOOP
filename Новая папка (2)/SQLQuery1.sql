CREATE TABLE [dbo].[Users](
	[IdUser] int IDENTITY(1,1) NOT NULL,
	[FirstName] varchar(120) NULL,
	[LastName] varchar(120) NULL,
	[Email] varchar(50) NOT NULL,
	[PasswordUser] varchar(40) NOT NULL,
	[IDNP] bigint NULL,
	[Photo] nvarchar(max) NULL,
	[DateCreated] date NOT NULL,
	[BirthDate] date NULL,
	[Age] int check(Age>0) NULL,
	[Gender] varchar(20) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED([IdUser]),
);
CREATE TABLE [dbo].[Adress](
	[IdAdress] int NOT NULL,
	[Village] varchar(40) NULL,
	[City] varchar(40) NULL,
	[Country] varchar(40) NULL,
	[IdUser] int NOT NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED ([IdAdress]),
 Foreign key (IdUser) References Users (IdUser));
  CREATE TABLE [dbo].[Groups](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[AcademicYear] nvarchar(50) NOT NULL,
	[Name] nvarchar(50) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([GroupId]));
 CREATE TABLE [dbo].[Teachers](
	[IdTeacher] int NOT NULL,
	[EntryTime] datetime NOT NULL,
	[ExitTime] datetime NOT NULL,
	[Active] nvarchar(50) NOT NULL,
	[Degree] varchar(10) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED([IdTeacher]),
 Foreign key (IdTeacher) References Users(IdUser));
 CREATE TABLE [dbo].[YearOfStudy](
	[IdYear] int NOT NULL,
	[Semester1] date NOT NULL,
	[Semester2] date NOT NULL,
 CONSTRAINT [PK_YearOfStudy] PRIMARY KEY CLUSTERED([IdYear]));
 CREATE TABLE [dbo].[Students](
	[IdStudent] int NOT NULL,
	[EntryTime] datetime NOT NULL,
	[ExitTime] datetime NOT NULL,
	[Active] nvarchar(50) NOT NULL,
	[Class] varchar(10) NULL,
	[IdUser] int NOT NULL,
	[GroupId] int NOT NULL,
	[IdYear] int NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED([IdStudent]),
  Foreign key (GroupId) References Groups(GroupId),
  Foreign key (IdYear) References YearOfStudy(IdYear),
  Foreign key (IdUser) References Users(IdUser),
  );
  CREATE TABLE [dbo].[Events](
	[IdEvent] int NOT NULL,
	[EventName] varchar(100) NOT NULL,
	[Createby] int NOT NULL,
 CONSTRAINT [PK_Eveniment] PRIMARY KEY CLUSTERED ([IdEvent]),
  Foreign key (Createby) References Users (IdUser));
 CREATE TABLE dbo.[Subscribes](
	[IdEvent] int NOT NULL,
	[IdStudent] int NOT NULL,
 CONSTRAINT [PK_EvenimentStudent] PRIMARY KEY CLUSTERED([IdEvent],[IdStudent]),
  Foreign key (IdEvent) References Events(IdEvent),
  Foreign key (IdStudent) References Students(IdStudent)); 
 CREATE TABLE [dbo].[Courses](
	[IdCourse] int NOT NULL,
	[NameCourse] varchar(100) NOT NULL,
	[GroupId] int NOT NULL,
	[DateCreateCourse] datetime NOT NULL,
	[MainTeacher] int NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([IdCourse]),
  Foreign key (GroupId) References Groups (GroupId),
  Foreign key (MainTeacher) References Teachers(IdTeacher),
 );
 CREATE TABLE [dbo].[Marks](
	[IdNote] int IDENTITY(1,1) NOT NULL,
	[IdCourse] int NOT NULL,
	[IdStudent] int NOT NULL,
	[Value] int NULL,
 CONSTRAINT [PK_StudentCourse] PRIMARY KEY CLUSTERED([IdNote]),
   Foreign key (IdStudent) References Students(IdStudent),
   Foreign key (IdCourse) References Courses(IdCourse),
 );

 


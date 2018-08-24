
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/21/2018 12:14:14
-- Generated from EDMX file: C:\Users\vadim.salajan\source\repos\Database\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PasswordUser] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Adresses'
CREATE TABLE [dbo].[Adresses] (
    [IdAdress] int  NOT NULL,
    [Village] varchar(40)  NULL,
    [City] varchar(40)  NULL,
    [Country] varchar(40)  NULL,
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [IdCourse] int  NOT NULL,
    [NameCourse] varchar(100)  NOT NULL,
    [GroupId] int  NOT NULL,
    [DateCreateCourse] datetime  NOT NULL,
    [MainTeacher] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [IdEvent] int  NOT NULL,
    [EventName] varchar(100)  NOT NULL,
    [Createby] int  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [GroupId] int IDENTITY(1,1) NOT NULL,
    [AcademicYear] nvarchar(50)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Marks'
CREATE TABLE [dbo].[Marks] (
    [IdNote] int IDENTITY(1,1) NOT NULL,
    [IdCourse] int  NOT NULL,
    [IdStudent] int  NOT NULL,
    [Value] int  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [IdStudent] int  NOT NULL,
    [EntryTime] datetime  NOT NULL,
    [ExitTime] datetime  NOT NULL,
    [Active] nvarchar(50)  NOT NULL,
    [Class] varchar(10)  NULL,
    [IdUser] int  NOT NULL,
    [GroupId] int  NOT NULL,
    [IdYear] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Teachers'
CREATE TABLE [dbo].[Teachers] (
    [IdTeacher] int  NOT NULL,
    [EntryTime] datetime  NOT NULL,
    [ExitTime] datetime  NOT NULL,
    [Active] nvarchar(50)  NOT NULL,
    [Degree] varchar(10)  NULL
);
GO

-- Creating table 'User1Set'
CREATE TABLE [dbo].[User1Set] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(120)  NULL,
    [LastName] varchar(120)  NULL,
    [Email] varchar(50)  NOT NULL,
    [PasswordUser] varchar(40)  NOT NULL,
    [IDNP] bigint  NULL,
    [Photo] nvarchar(max)  NULL,
    [DateCreated] datetime  NOT NULL,
    [BirthDate] datetime  NULL,
    [Age] int  NULL,
    [Gender] varchar(20)  NOT NULL
);
GO

-- Creating table 'YearOfStudies'
CREATE TABLE [dbo].[YearOfStudies] (
    [IdYear] int  NOT NULL,
    [Semester1] datetime  NOT NULL,
    [Semester2] datetime  NOT NULL
);
GO

-- Creating table 'NewUsers'
CREATE TABLE [dbo].[NewUsers] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(120)  NULL,
    [LastName] varchar(120)  NULL,
    [Email] varchar(50)  NOT NULL,
    [IDNP] bigint  NULL,
    [BirthDate] datetime  NULL,
    [Age] int  NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [AddressId] int IDENTITY(1,1) NOT NULL,
    [Village] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [Country] nvarchar(max)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Cours'
CREATE TABLE [dbo].[Cours] (
    [CoursId] int IDENTITY(1,1) NOT NULL,
    [NameCourse] nvarchar(50)  NOT NULL,
    [GroupId] int  NOT NULL,
    [DateCreateCourse] datetime  NOT NULL,
    [TeacherId] int  NOT NULL
);
GO

-- Creating table 'Event1Set'
CREATE TABLE [dbo].[Event1Set] (
    [EventId] int IDENTITY(1,1) NOT NULL,
    [EventName] nvarchar(200)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'EventsStudents'
CREATE TABLE [dbo].[EventsStudents] (
    [EventId] int  NOT NULL,
    [StudentId] int  NOT NULL
);
GO

-- Creating table 'Group1Set'
CREATE TABLE [dbo].[Group1Set] (
    [GroupId] int IDENTITY(1,1) NOT NULL,
    [AcademicYear] nvarchar(max)  NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Mark1Set'
CREATE TABLE [dbo].[Mark1Set] (
    [MarkId] int IDENTITY(1,1) NOT NULL,
    [CoursId] int  NOT NULL,
    [StudentId] int  NOT NULL,
    [Value] int  NULL
);
GO

-- Creating table 'Student1Set'
CREATE TABLE [dbo].[Student1Set] (
    [StudentId] int IDENTITY(1,1) NOT NULL,
    [EntryTime] datetime  NOT NULL,
    [ExitTime] datetime  NOT NULL,
    [Active] nvarchar(3)  NOT NULL,
    [Class] nvarchar(max)  NULL,
    [UserId] int  NOT NULL,
    [GroupId] int  NOT NULL,
    [YearOfStudyId] int  NOT NULL
);
GO

-- Creating table 'Teacher1Set'
CREATE TABLE [dbo].[Teacher1Set] (
    [TeacherId] int  NOT NULL,
    [EntryTime] datetime  NOT NULL,
    [ExitTime] datetime  NOT NULL,
    [Active] nvarchar(3)  NOT NULL,
    [Degree] nvarchar(max)  NULL
);
GO

-- Creating table 'User2Set'
CREATE TABLE [dbo].[User2Set] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [PasswordUser] nvarchar(50)  NOT NULL,
    [IDNP] bigint  NOT NULL,
    [Photo] nvarchar(400)  NULL,
    [DateCreated] datetime  NULL,
    [BirthDate] datetime  NULL,
    [Age] int  NULL,
    [Gender] nvarchar(1)  NOT NULL
);
GO

-- Creating table 'YearOfStudy1Set'
CREATE TABLE [dbo].[YearOfStudy1Set] (
    [YearOfStudyId] int IDENTITY(1,1) NOT NULL,
    [BegginingYear] datetime  NOT NULL,
    [EndYear] datetime  NOT NULL
);
GO

-- Creating table 'Subscribes'
CREATE TABLE [dbo].[Subscribes] (
    [Events_IdEvent] int  NOT NULL,
    [Students_IdStudent] int  NOT NULL
);
GO

-- Creating table 'StudentEvents'
CREATE TABLE [dbo].[StudentEvents] (
    [Events_EventId] int  NOT NULL,
    [Students_StudentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId], [Email] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([UserId], [Email] ASC);
GO

-- Creating primary key on [IdAdress] in table 'Adresses'
ALTER TABLE [dbo].[Adresses]
ADD CONSTRAINT [PK_Adresses]
    PRIMARY KEY CLUSTERED ([IdAdress] ASC);
GO

-- Creating primary key on [IdCourse] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([IdCourse] ASC);
GO

-- Creating primary key on [IdEvent] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([IdEvent] ASC);
GO

-- Creating primary key on [GroupId] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([GroupId] ASC);
GO

-- Creating primary key on [IdNote] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [PK_Marks]
    PRIMARY KEY CLUSTERED ([IdNote] ASC);
GO

-- Creating primary key on [IdStudent] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([IdStudent] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [IdTeacher] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [PK_Teachers]
    PRIMARY KEY CLUSTERED ([IdTeacher] ASC);
GO

-- Creating primary key on [IdUser] in table 'User1Set'
ALTER TABLE [dbo].[User1Set]
ADD CONSTRAINT [PK_User1Set]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdYear] in table 'YearOfStudies'
ALTER TABLE [dbo].[YearOfStudies]
ADD CONSTRAINT [PK_YearOfStudies]
    PRIMARY KEY CLUSTERED ([IdYear] ASC);
GO

-- Creating primary key on [IdUser], [Email] in table 'NewUsers'
ALTER TABLE [dbo].[NewUsers]
ADD CONSTRAINT [PK_NewUsers]
    PRIMARY KEY CLUSTERED ([IdUser], [Email] ASC);
GO

-- Creating primary key on [AddressId] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([AddressId] ASC);
GO

-- Creating primary key on [CoursId] in table 'Cours'
ALTER TABLE [dbo].[Cours]
ADD CONSTRAINT [PK_Cours]
    PRIMARY KEY CLUSTERED ([CoursId] ASC);
GO

-- Creating primary key on [EventId] in table 'Event1Set'
ALTER TABLE [dbo].[Event1Set]
ADD CONSTRAINT [PK_Event1Set]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [EventId], [StudentId] in table 'EventsStudents'
ALTER TABLE [dbo].[EventsStudents]
ADD CONSTRAINT [PK_EventsStudents]
    PRIMARY KEY CLUSTERED ([EventId], [StudentId] ASC);
GO

-- Creating primary key on [GroupId] in table 'Group1Set'
ALTER TABLE [dbo].[Group1Set]
ADD CONSTRAINT [PK_Group1Set]
    PRIMARY KEY CLUSTERED ([GroupId] ASC);
GO

-- Creating primary key on [MarkId] in table 'Mark1Set'
ALTER TABLE [dbo].[Mark1Set]
ADD CONSTRAINT [PK_Mark1Set]
    PRIMARY KEY CLUSTERED ([MarkId] ASC);
GO

-- Creating primary key on [StudentId] in table 'Student1Set'
ALTER TABLE [dbo].[Student1Set]
ADD CONSTRAINT [PK_Student1Set]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [TeacherId] in table 'Teacher1Set'
ALTER TABLE [dbo].[Teacher1Set]
ADD CONSTRAINT [PK_Teacher1Set]
    PRIMARY KEY CLUSTERED ([TeacherId] ASC);
GO

-- Creating primary key on [UserId] in table 'User2Set'
ALTER TABLE [dbo].[User2Set]
ADD CONSTRAINT [PK_User2Set]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [YearOfStudyId] in table 'YearOfStudy1Set'
ALTER TABLE [dbo].[YearOfStudy1Set]
ADD CONSTRAINT [PK_YearOfStudy1Set]
    PRIMARY KEY CLUSTERED ([YearOfStudyId] ASC);
GO

-- Creating primary key on [Events_IdEvent], [Students_IdStudent] in table 'Subscribes'
ALTER TABLE [dbo].[Subscribes]
ADD CONSTRAINT [PK_Subscribes]
    PRIMARY KEY CLUSTERED ([Events_IdEvent], [Students_IdStudent] ASC);
GO

-- Creating primary key on [Events_EventId], [Students_StudentId] in table 'StudentEvents'
ALTER TABLE [dbo].[StudentEvents]
ADD CONSTRAINT [PK_StudentEvents]
    PRIMARY KEY CLUSTERED ([Events_EventId], [Students_StudentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdUser] in table 'Adresses'
ALTER TABLE [dbo].[Adresses]
ADD CONSTRAINT [FK_Adress_Users]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User1Set]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Adress_Users'
CREATE INDEX [IX_FK_Adress_Users]
ON [dbo].[Adresses]
    ([IdUser]);
GO

-- Creating foreign key on [IdStudent] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK__StudentCo__IdStu__51EF2864]
    FOREIGN KEY ([IdStudent])
    REFERENCES [dbo].[Courses]
        ([IdCourse])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__StudentCo__IdStu__51EF2864'
CREATE INDEX [IX_FK__StudentCo__IdStu__51EF2864]
ON [dbo].[Marks]
    ([IdStudent]);
GO

-- Creating foreign key on [GroupId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Courses_Group]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([GroupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Courses_Group'
CREATE INDEX [IX_FK_Courses_Group]
ON [dbo].[Courses]
    ([GroupId]);
GO

-- Creating foreign key on [MainTeacher] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Courses_Teachers]
    FOREIGN KEY ([MainTeacher])
    REFERENCES [dbo].[Teachers]
        ([IdTeacher])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Courses_Teachers'
CREATE INDEX [IX_FK_Courses_Teachers]
ON [dbo].[Courses]
    ([MainTeacher]);
GO

-- Creating foreign key on [Createby] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Eveniments_Users]
    FOREIGN KEY ([Createby])
    REFERENCES [dbo].[User1Set]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Eveniments_Users'
CREATE INDEX [IX_FK_Eveniments_Users]
ON [dbo].[Events]
    ([Createby]);
GO

-- Creating foreign key on [Events_IdEvent] in table 'Subscribes'
ALTER TABLE [dbo].[Subscribes]
ADD CONSTRAINT [FK_Subscribes_Event]
    FOREIGN KEY ([Events_IdEvent])
    REFERENCES [dbo].[Events]
        ([IdEvent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Students_IdStudent] in table 'Subscribes'
ALTER TABLE [dbo].[Subscribes]
ADD CONSTRAINT [FK_Subscribes_Student]
    FOREIGN KEY ([Students_IdStudent])
    REFERENCES [dbo].[Students]
        ([IdStudent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Subscribes_Student'
CREATE INDEX [IX_FK_Subscribes_Student]
ON [dbo].[Subscribes]
    ([Students_IdStudent]);
GO

-- Creating foreign key on [GroupId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Students_Groups]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([GroupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Students_Groups'
CREATE INDEX [IX_FK_Students_Groups]
ON [dbo].[Students]
    ([GroupId]);
GO

-- Creating foreign key on [IdStudent] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK__StudentCo__IdStu__52E34C9D]
    FOREIGN KEY ([IdStudent])
    REFERENCES [dbo].[Students]
        ([IdStudent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__StudentCo__IdStu__52E34C9D'
CREATE INDEX [IX_FK__StudentCo__IdStu__52E34C9D]
ON [dbo].[Marks]
    ([IdStudent]);
GO

-- Creating foreign key on [IdUser] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Students_Users]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User1Set]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Students_Users'
CREATE INDEX [IX_FK_Students_Users]
ON [dbo].[Students]
    ([IdUser]);
GO

-- Creating foreign key on [IdYear] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Students_YearOfStudy]
    FOREIGN KEY ([IdYear])
    REFERENCES [dbo].[YearOfStudies]
        ([IdYear])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Students_YearOfStudy'
CREATE INDEX [IX_FK_Students_YearOfStudy]
ON [dbo].[Students]
    ([IdYear]);
GO

-- Creating foreign key on [UserId] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_dbo_Addresses_dbo_Users_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User2Set]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Addresses_dbo_Users_UserId'
CREATE INDEX [IX_FK_dbo_Addresses_dbo_Users_UserId]
ON [dbo].[Addresses]
    ([UserId]);
GO

-- Creating foreign key on [GroupId] in table 'Cours'
ALTER TABLE [dbo].[Cours]
ADD CONSTRAINT [FK_dbo_Cours_dbo_Groups_GroupId]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Group1Set]
        ([GroupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Cours_dbo_Groups_GroupId'
CREATE INDEX [IX_FK_dbo_Cours_dbo_Groups_GroupId]
ON [dbo].[Cours]
    ([GroupId]);
GO

-- Creating foreign key on [TeacherId] in table 'Cours'
ALTER TABLE [dbo].[Cours]
ADD CONSTRAINT [FK_dbo_Cours_dbo_Teachers_TeacherId]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[Teacher1Set]
        ([TeacherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Cours_dbo_Teachers_TeacherId'
CREATE INDEX [IX_FK_dbo_Cours_dbo_Teachers_TeacherId]
ON [dbo].[Cours]
    ([TeacherId]);
GO

-- Creating foreign key on [CoursId] in table 'Mark1Set'
ALTER TABLE [dbo].[Mark1Set]
ADD CONSTRAINT [FK_dbo_Marks_dbo_Cours_CoursId]
    FOREIGN KEY ([CoursId])
    REFERENCES [dbo].[Cours]
        ([CoursId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Marks_dbo_Cours_CoursId'
CREATE INDEX [IX_FK_dbo_Marks_dbo_Cours_CoursId]
ON [dbo].[Mark1Set]
    ([CoursId]);
GO

-- Creating foreign key on [UserId] in table 'Event1Set'
ALTER TABLE [dbo].[Event1Set]
ADD CONSTRAINT [FK_dbo_Events_dbo_Users_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User2Set]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Events_dbo_Users_UserId'
CREATE INDEX [IX_FK_dbo_Events_dbo_Users_UserId]
ON [dbo].[Event1Set]
    ([UserId]);
GO

-- Creating foreign key on [StudentId] in table 'EventsStudents'
ALTER TABLE [dbo].[EventsStudents]
ADD CONSTRAINT [FK_dbo_EventsStudents_dbo_Events_StudentId]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Event1Set]
        ([EventId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_EventsStudents_dbo_Events_StudentId'
CREATE INDEX [IX_FK_dbo_EventsStudents_dbo_Events_StudentId]
ON [dbo].[EventsStudents]
    ([StudentId]);
GO

-- Creating foreign key on [Events_EventId] in table 'StudentEvents'
ALTER TABLE [dbo].[StudentEvents]
ADD CONSTRAINT [FK_StudentEvents_Event1]
    FOREIGN KEY ([Events_EventId])
    REFERENCES [dbo].[Event1Set]
        ([EventId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Students_StudentId] in table 'StudentEvents'
ALTER TABLE [dbo].[StudentEvents]
ADD CONSTRAINT [FK_StudentEvents_Student1]
    FOREIGN KEY ([Students_StudentId])
    REFERENCES [dbo].[Student1Set]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentEvents_Student1'
CREATE INDEX [IX_FK_StudentEvents_Student1]
ON [dbo].[StudentEvents]
    ([Students_StudentId]);
GO

-- Creating foreign key on [StudentId] in table 'EventsStudents'
ALTER TABLE [dbo].[EventsStudents]
ADD CONSTRAINT [FK_dbo_EventsStudents_dbo_Students_StudentId]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student1Set]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_EventsStudents_dbo_Students_StudentId'
CREATE INDEX [IX_FK_dbo_EventsStudents_dbo_Students_StudentId]
ON [dbo].[EventsStudents]
    ([StudentId]);
GO

-- Creating foreign key on [GroupId] in table 'Student1Set'
ALTER TABLE [dbo].[Student1Set]
ADD CONSTRAINT [FK_dbo_Students_dbo_Groups_GroupId]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Group1Set]
        ([GroupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Students_dbo_Groups_GroupId'
CREATE INDEX [IX_FK_dbo_Students_dbo_Groups_GroupId]
ON [dbo].[Student1Set]
    ([GroupId]);
GO

-- Creating foreign key on [StudentId] in table 'Mark1Set'
ALTER TABLE [dbo].[Mark1Set]
ADD CONSTRAINT [FK_dbo_Marks_dbo_Students_StudentId]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student1Set]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Marks_dbo_Students_StudentId'
CREATE INDEX [IX_FK_dbo_Marks_dbo_Students_StudentId]
ON [dbo].[Mark1Set]
    ([StudentId]);
GO

-- Creating foreign key on [UserId] in table 'Student1Set'
ALTER TABLE [dbo].[Student1Set]
ADD CONSTRAINT [FK_dbo_Students_dbo_Users_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User2Set]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Students_dbo_Users_UserId'
CREATE INDEX [IX_FK_dbo_Students_dbo_Users_UserId]
ON [dbo].[Student1Set]
    ([UserId]);
GO

-- Creating foreign key on [YearOfStudyId] in table 'Student1Set'
ALTER TABLE [dbo].[Student1Set]
ADD CONSTRAINT [FK_Students_YearOfStudies]
    FOREIGN KEY ([YearOfStudyId])
    REFERENCES [dbo].[YearOfStudy1Set]
        ([YearOfStudyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Students_YearOfStudies'
CREATE INDEX [IX_FK_Students_YearOfStudies]
ON [dbo].[Student1Set]
    ([YearOfStudyId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
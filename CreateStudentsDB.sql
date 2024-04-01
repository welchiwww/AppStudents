CREATE DATABASE StudentsDB;

USE StudentsDB;

CREATE TABLE PersonalInfo (
    StudentID INT not null,
    FirstName VARCHAR(50) not null,
    LastName VARCHAR(50) not null,
    DateOfBirth DATE,
	ModifiedDate DATETIME,
	CONSTRAINT PK_PersonalInfo PRIMARY KEY (StudentID)
);
	
CREATE TABLE ContactInfo (
    InfoID INT not null,
	StudentID INT not null,
    Email VARCHAR(100),
    PhoneNumber VARCHAR(15) not null, 
    Address VARCHAR(255),
	CONSTRAINT PK_ContactInfo PRIMARY KEY(InfoID),
    CONSTRAINT FK_ContackInfo_PersonalInfo FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID)
);

CREATE TABLE Course (
    CourseID INT not null,
    CourseName VARCHAR(100) not null,
    CourseDescription TEXT,
	CONSTRAINT PK_Course PRIMARY KEY(CourseID)
);

CREATE TABLE Enrollment (
    EnrollmentID INT,
	StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,
    CONSTRAINT PK_Enrollment PRIMARY KEY (EnrollmentID),
    CONSTRAINT FK_Enrollment_PersonalInfo FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID),
    CONSTRAINT FK_Enrollment_Course FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);

CREATE TABLE Attendance (
    AttendanceID INT,
	StudentID INT,
    CourseID INT,
    AttendanceDate DATE,
    Status VARCHAR(20),
    CONSTRAINT PK_Attendance PRIMARY KEY (AttendanceID),
    CONSTRAINT FK_Attendance_PersonalInfo FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID),
    CONSTRAINT FK_Attendance_Course FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);

CREATE TABLE Assignment (
    AssignmentID INT,
    CourseID INT,
    AssignmentName VARCHAR(100),
    DueDate DATE,
	CONSTRAINT PK_Assignment PRIMARY KEY(AssignmentID),
    CONSTRAINT FK_Assignment_Course FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);

CREATE TABLE AssignmentSubmission (
    AssignmentSubmissionID INT,
	StudentID INT,
    AssignmentID INT,
    SubmissionDate DATE,
    Grade INT,
    CONSTRAINT PK_AssignmentSubmission PRIMARY KEY (AssignmentSUbmissionID),
    CONSTRAINT FK_AssignmentSubmission_PersonalIfno FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID),
    CONSTRAINT FK_AssignmentSubmission_Assignment FOREIGN KEY (AssignmentID) REFERENCES Assignment(AssignmentID),
	CONSTRAINT CHK_AssignmentSubmission CHECK (Grade >=1 AND Grade <=5)
);

CREATE TABLE Exam (
    ExamID INT,
    CourseID INT,
    ExamName VARCHAR(100),
    ExamDate DATE,
	CONSTRAINT PK_Exam PRIMARY KEY(ExamID),
    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);

CREATE TABLE ExamResult (
    ExamResultID INT,
	StudentID INT,
    ExamID INT,
    Result INT,
    CONSTRAINT PK_ExamResult PRIMARY KEY (ExamResultID),
    CONSTRAINT FK_ExamResult_PersonalInfo FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID),
    CONSTRAINT FK_ExamResult_Exam FOREIGN KEY (ExamID) REFERENCES Exam(ExamID),
	CONSTRAINT CHK_ExamResult CHECK(Result >= 1 AND Result <= 5)
);

CREATE TABLE Payment (
    PaymentID INT,
	StudentID INT,
    Amount FLOAT,
    PaymentDate DATE,
	CONSTRAINT PK_Payment PRIMARY KEY(PaymentID),
    CONSTRAINT FK_Payment_PersonalInfo FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID)
);

CREATE TABLE Accounts (
	ID_user INT,
	user_login varchar(15),
	user_password varchar(15)
)
/*
alter table Attendance
DROP constraint PK_Attendance
alter table Attendance
DROP constraint FK_Attendance_PersonalInfo
alter table Attendance
DROP constraint FK_Attendance_Course

DROP TABLE Attendance
*/
--DROP TABLE AssignmentSubmission

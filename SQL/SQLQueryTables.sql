create table Students(
	StudentId varchar(10) primary key,
	FirstName varchar(25),
	LastName varchar(25),
)

create table Semesters(
	SemesterId int identity(1,1) primary key,
	SemesterName varchar(25),
	StartDate datetime,
	EndDate datetime,
)

create table Teachers(
	TeacherId varchar(10) primary key,
	FirstName varchar(50),
	LastName varchar(50)
)

create table Courses(
	CourseId int identity(1,1) primary key,
	TeacherId varchar(10) foreign key references Teachers(TeacherId),
	CourseName varchar(50),
)

create table StudentCourses(
	StudentCourseId int identity(1,1) primary key,
	StudentId varchar(10) foreign key references Students(StudentId),
	SemesterId int foreign key references Semesters(SemesterId),
	CourseId int foreign key references Courses(CourseId),
)

create table Exams(
	ExamId int identity(1,1) primary key,
	CourseId int foreign key references Courses(CourseId),
	ExamName varchar(100),
	ExamDate datetime,
)

create table Topics(
	TopicId int identity(1,1) primary key,
	TopicName varchar(100),
)

create table Questions(
	QuestionId int identity(1,1) primary key,
	TopicId int foreign key references Topics(TopicId),
	ExamId int foreign key references Exams(ExamId),
	QuestionText varchar(200)
)

create table Answers(
	AnswerId int identity(1,1) primary key,
	QuestionId int foreign key references Questions(QuestionId),
	AnswerText varchar(200),
	IsCorrect bit,
)

create table StudentAnswers(
	StudentAnswerId int identity(1,1) primary key,
	StudentId varchar(10) foreign key references Students(StudentId),
	ExamId int foreign key references Exams(ExamId),
	QuestionId int foreign key references Questions(QuestionId),
	AnswerId int foreign key references Answers(AnswerId),
)

---

create table TopicReview(
	ReviewId int identity(1, 1) primary key,
	StudentId varchar(10) foreign key references Students(StudentId),
	TopicId int foreign key references Topics(TopicId),
	NextReviewDate datetime,
	ReviewInterval int,
)

create table ReviewHistory(
	ReviewId int foreign key references TopicReview(ReviewId),
	ReviewDate datetime,
	Success bit
)


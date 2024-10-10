CREATE TABLE STUDENT (
    StudentId BIGINT PRIMARY KEY IDENTITY,
    StudentName VARCHAR(50) NOT NULL
);
CREATE TABLE SUBJECT (
    SubjectId BIGINT PRIMARY KEY IDENTITY,
    SubjectName VARCHAR(50) NOT NULL,
    SubjectCode VARCHAR(10) NOT NULL
);

CREATE TABLE EXAM (
    ExamId BIGINT PRIMARY KEY IDENTITY,
    MinMark INT NOT NULL,
    MaxMark INT NOT NULL
);

CREATE TABLE MARKS (
    MarkId BIGINT PRIMARY KEY IDENTITY,
    ExamId BIGINT,
    SubjectId BIGINT,
    StudentId BIGINT,
    Mark INT NOT NULL,
    CONSTRAINT FK_ExamId FOREIGN KEY (ExamId) REFERENCES EXAM(ExamId),
    CONSTRAINT FK_SubjectId FOREIGN KEY (SubjectId) REFERENCES SUBJECT(SubjectId),
    CONSTRAINT FK_StudentId FOREIGN KEY (StudentId) REFERENCES STUDENT(StudentId)
);


INSERT INTO STUDENT (StudentName) VALUES ('JIMMY');
INSERT INTO STUDENT (StudentName) VALUES ('JaMES');
INSERT INTO STUDENT (StudentName) VALUES ('BobBY');
INSERT INTO STUDENT (StudentName) VALUES ('Diya');
INSERT INTO STUDENT (StudentName) VALUES ('Jene');


INSERT INTO SUBJECT (SubjectName, SubjectCode) VALUES ('Mathes', 'MATH101');
INSERT INTO SUBJECT (SubjectName, SubjectCode) VALUES ('Java', 'JAVA102');
INSERT INTO SUBJECT (SubjectName, SubjectCode) VALUES ('Compiler', 'COMP103');

INSERT INTO EXAM (ExamName,MinMark, MaxMark) VALUES ('SEM1',40, 100);
INSERT INTO EXAM (ExamName,MinMark, MaxMark) VALUES ('SEM2',30, 90);


INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 1, 1, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 2, 1, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 3, 1, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 1, 1, 85);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 2, 1, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 3, 1, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 1, 2, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 2, 2, 85);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 3, 2, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 1, 2, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 2, 2, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 3, 2, 85);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 1, 3, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 2, 3, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 3, 3, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 1, 3, 85);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 2, 3, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 3, 3, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 1, 4, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 2, 4, 55);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 3, 4, 60);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 1, 4, 70);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 2, 4, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 3, 4, 55);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 1, 5, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 2, 5, 65);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (1, 3, 5, 80);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 1, 5, 50);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 2, 5, 90);
INSERT INTO MARKS (ExamId, SubjectId, StudentId, Mark) VALUES (2, 3, 5, 45);



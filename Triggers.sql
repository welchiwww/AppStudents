-- �������� ��������
CREATE TRIGGER UpdatePersonalInfoModifiedDate
ON PersonalInfo
AFTER UPDATE
AS
BEGIN
    -- ���������� ���� ��������� �� ������� ���� � �����
    UPDATE PersonalInfo
    SET ModifiedDate = GETDATE()
    FROM PersonalInfo
    INNER JOIN inserted ON PersonalInfo.StudentID = inserted.StudentID;
END;

--��������������� ��������
CREATE PROCEDURE GetAbsentStudents
AS
BEGIN
    SELECT 
        p.StudentID, 
        p.FirstName, 
        p.LastName, 
        c.CourseName, 
        a.AttendanceDate
    FROM 
        PersonalInfo p
    JOIN 
        Attendance a ON p.StudentID = a.StudentID
    JOIN 
        Course c ON a.CourseID = c.CourseID
    WHERE 
        a.Status = '������������'
    ORDER BY 
        p.LastName, p.FirstName;
END;

--�� �������
CREATE PROCEDURE GetFailedStudents
AS
BEGIN
    SELECT 
        p.StudentID, 
        p.FirstName, 
        p.LastName, 
        e.ExamName,
        er.Result
    FROM 
        PersonalInfo p
    JOIN 
        ExamResult er ON p.StudentID = er.StudentID
    JOIN 
        Exam e ON er.ExamID = e.ExamID
    WHERE 
        er.Result < 3 -- ������������, ��� ����������� ���� ��� ����� �������� ����� 3
    ORDER BY 
        p.LastName, p.FirstName;
END;


exec GetFailedStudents;
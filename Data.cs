using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudents_DB
{
    class Data
    {
        public static Dictionary<string, string> DictionaryData = new Dictionary<string, string>()
        {
            {"AssignmentID","ID задания"},
            {"CourseID","ID курса"},
            {"AssignmentName","Название задания"},
            {"DueDate","Крайнее число сдачи"},
            {"AssignmentSubmissionID","ID сдачи задания"},
            {"StudentID","ID студента"},
            {"SubmissionDate","Дата сдачи"},
            {"Grade","Оценка"},
            {"AttendanceID","ID посещения"},
            {"AttendanceDate","Дата посещения"},
            {"Status","Посещение"},
            {"InfoID","ID информации студента"},
            {"Email","Электронная почта"},
            {"PhoneNumber","Номер телефона"},
            {"Address","Адрес"},
            {"CourseName","Название курса"},
            {"CourseDescription","Описание курса"},
            {"EnrollmentID","ID зачисления"},
            {"EnrollmentDate","Дата зачисления"},
            {"ExamID","ID экзамена"},
            {"ExamName","Название экзамена"},
            {"ExamDate","Дата экзамена"},
            {"ExamResultID","ID результата экзамена"},
            {"Result","Результат экзамена"},
            {"PaymentID","ID оплаты"},
            {"Amount","Сумма"},
            {"PaymentDate","Дата платежа"},
            {"FirstName","Имя"},
            {"LastName","Фамилия"},
            {"DateOfBirth","Дата рождения"},
            {"ModifiedDate", "Последнее изменение"}
        };
    }
}

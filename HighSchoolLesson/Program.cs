using HighSchoolLesson.DataAccess;
using HighSchoolLesson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<SubjectsStudents>();
            using(var context = new HighContext())
            {
                /*var mentor = new Mentor
                {
                    FullName = "Смирнов Иван",
                    Stage = 13
                };
                var math = new Subject
                {
                    Name = "Математика",
                    Mentor = mentor
                };
                var english = new Subject
                {
                    Name = "Английский язык",
                    Mentor = mentor
                };


                var firstStudent = new Student
                {
                    FullName = "Чёрный Александр",
                    GroupName = "103A"
                };

                var secondStudent = new Student
                {
                    FullName = "Крутая Екатерина",
                    GroupName = "103A"
                };

                var firstSubjectStudent = new SubjectsStudents
                {
                    Subject = math,
                    Student = firstStudent
                };
                var secondSubjectStudent = new SubjectsStudents
                {
                    Subject = math,
                    Student = secondStudent
                };
                var thirdSubjectStudent = new SubjectsStudents
                {
                    Subject = english,
                    Student = firstStudent
                };
                var fourthSubjectStudent = new SubjectsStudents
                {
                    Subject = english,
                    Student = secondStudent
                };

                //context.Add(mentor);
                //context.Add(firstStudent);
                //context.Add(secondStudent);
                //context.Add(math);
                //context.Add(english);
                context.Add(firstSubjectStudent);
                context.Add(secondStudent);
                context.Add(thirdSubjectStudent);
                context.Add(fourthSubjectStudent);
                context.SaveChanges();*/

                /* Три типа загрузки:
                 * Eager, Explicit, Lazy
                 * Жадная скачивает все связи через Include, а не только конкретную сущность
                 * Явная скачивает только конкретную сущность
                 * Ленивая может заранее сделать дополнительный запрос в одном контексте
                 */

                // Жадная: НЕ используй, когда не нужно всё подряд
                // Это ОДИН запрос
                //var result = context.SubjectsStudents
                //    .Include(subjectStudent => subjectStudent.Student)
                //    .Include(subjectStudent => subjectStudent.Subject) 
                //    .ThenInclude(subject => subject.Mentor)
                //    .ToList();

                //// Явная
                //var result = context.SubjectsStudents.ToList();
                //// Это ВТОРОЙ запрос, нельзя делать вне using
                //context.Entry(result.FirstOrDefault())
                //    .Reference(x => x.Student)
                //    .Load();

                // Ленивая нельзя достучатся до объектов вне контекста
                result = context.SubjectsStudents.ToList();
                Console.WriteLine(result.FirstOrDefault().Student.FullName);
            }
            // Здесь НЕ работает
            //Console.WriteLine(result.FirstOrDefault().Student.FullName);
        }
    }
}

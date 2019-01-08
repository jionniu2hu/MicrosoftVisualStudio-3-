using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //构建学生数据
            var students = new List<Student>
            {
                new Student{Name="卢本伟",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="蜡笔小新",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="马云",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="罗老师",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="南宫问题",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="小邋遢",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="葫芦娃",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{Name="葫芦小金刚",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            //将学生数据加入实体集

            students.ForEach(st => context.Students.Add(st));
            context.SaveChanges();


            //构建课程数据
            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="化学",Credits=3},
                new Course{CourseID=4022,Title="经济学",Credits=3},
                new Course{CourseID=4041,Title="经济学",Credits=3},
                new Course{CourseID=1045,Title="微积分学",Credits=4},
                new Course{CourseID=3141,Title="三角法",Credits=4},
                new Course{CourseID=2021,Title="作文",Credits=3},
                new Course{CourseID=2042,Title="文艺",Credits=4},
                new Course{CourseID=6060,Title="体育",Credits=4}
            };
            //将课程数据加入实体集
            //保存实体集
            courses.ForEach(st => context.Courses.Add(st));
            context.SaveChanges();



            //构建注册数据
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.D},
                new Enrollment{StudentID=4,CourseID=1050,Grade=Grade.B},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045,Grade=Grade.D},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
                new Enrollment{StudentID=8,CourseID=1045,Grade=Grade.D},
                new Enrollment{StudentID=8,CourseID=3141,Grade=Grade.A},
            };

            //将注册数据加入实体集
            enrollments.ForEach(st => context.Enrollments.Add(st));
            context.SaveChanges();
        }
    }
}
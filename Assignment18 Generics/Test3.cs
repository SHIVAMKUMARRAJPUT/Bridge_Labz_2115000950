using System;
using System.Collections.Generic;

public abstract class CourseType { }
public class ExamCourse : CourseType { }
public class AssignmentCourse : CourseType { }

public abstract class CourseBase
{
    public string CourseName;
    public string Department;

    protected CourseBase(string courseName, string department)
    {
        CourseName = courseName;
        Department = department;
    }

    public abstract void DisplayCourseInfo();
}

public class Course<T> : CourseBase where T : CourseType
{
    public T CourseEvaluationType;

    public Course(string courseName, string department, T evaluationType) : base(courseName, department)
    {
        CourseEvaluationType = evaluationType;
    }

    public override void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Department: {Department}, Evaluation Type: {CourseEvaluationType.GetType().Name}");
    }
}

public class University
{
    private List<CourseBase> courses = new List<CourseBase>();

    public void AddCourse(CourseBase course)
    {
        if (course == null)
            throw new ArgumentNullException(nameof(course), "Course cannot be null");

        courses.Add(course);
    }

    public void DisplayAllCourses()
    {
        foreach (var course in courses)
        {
            course.DisplayCourseInfo();
        }
    }
}

class Test3
{
    public static void Print()
    {
        var university = new University();
        var mathCourse = new Course<ExamCourse>("Advanced Mathematics", "Science", new ExamCourse());
        var literatureCourse = new Course<AssignmentCourse>("World Literature", "Arts", new AssignmentCourse());

        university.AddCourse(mathCourse);
        university.AddCourse(literatureCourse);

        university.DisplayAllCourses();
    }
}
Day-6-SQL Queries

question-1

You are working on a database for a school’s student management system. The system contains a table named courses that stores information about the courses offered at the school and the students enrolled in them.

You have been tasked to generate a report that shows the following information for each course:

The total number of students enrolled.
The total fees collected for each course.
The course with the maximum number of enrollments.
Write SQL queries to accomplish the following tasks: Find the total number of students enrolled in each course: The result should display the course_name and the total count of students enrolled in that course.
Calculate the total fees collected for each course: The result should display the course_name and the sum of the course_fee collected.
Determine the course with the maximum number of enrollments: Display the course_name and the number of students enrolled for the course with the highest enrollment

Answers:-

CREATE TABLE courses (
  course_id INT PRIMARY KEY,
  course_name VARCHAR(50) NOT NULL,
  student_name VARCHAR(50) NOT NULL,
  course_fee DECIMAL(10, 2) NOT NULL
);

INSERT INTO courses (course_id, course_name, student_name, course_fee) VALUES
  (1, 'JAVA', 'John', 100.00),
  (2, 'MATHS', 'JAMES', 100.00),
  (3, 'CSE', 'JIYA', 150.00),
  (4, 'PYTHON', 'MIYA', 150.00),
  (5, 'DBMS', 'DIYA', 200.00);

1. SELECT 
  course_name, 
  COUNT(student_name) AS total_students
FROM 
  courses
GROUP BY 
  course_name;

2.  SELECT 
  course_name, 
  SUM(course_fee) AS total_fees
FROM 
  courses
GROUP BY 
  course_name;

3. SELECT 
  course_name, 
  COUNT(student_name) AS total_students
FROM 
  courses
GROUP BY 
  course_name
HAVING 
  COUNT(student_name) = (
    SELECT 
      TOP 1 COUNT(student_name) 
    FROM 
      courses 
    GROUP BY 
      course_name 
    ORDER BY 
      COUNT(student_name) DESC
  );
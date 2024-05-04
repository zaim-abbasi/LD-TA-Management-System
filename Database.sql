-- create database DB_Final_Project;
-- use DB_Final_Project;

                                                    -- Section and Students Table Creation
-- Section Table
CREATE TABLE Section (
    section_id INT PRIMARY KEY,
    Name VARCHAR(50)
);
-- Student Table
CREATE TABLE Student (
    Student_id INT PRIMARY KEY,
    Name VARCHAR(255),
    Email VARCHAR(255),
    Phone VARCHAR(20),
    Address VARCHAR(255),
    Department VARCHAR(100),
    Section_id INT,
    Password VARCHAR(255),
    prevTA_id INT,
    FOREIGN KEY (Section_id) REFERENCES Section(section_id),
);

                                                          -- Insert for Section and Students
/*
-- Insert data into Section table
INSERT INTO Section (section_id, Name) VALUES
(1, 'A'),
(2, 'B');
-- Insert data into Student table
INSERT INTO Student (Student_id, Name, Email, Phone, Address, Department, Section_id, Password) VALUES
(1, 'Ali Khan', 'ali.khan@gmail.com', '0300-1234567', '123 Main Street, Lahore', 'Computer Science', 1, 'ali123'),
(2, 'Fatima Ahmed', 'fatima.ahmed@yahoo.com', '0312-9876543', '456 Park Avenue, Karachi', 'Engineering', 1, 'fatima456'),
(3, 'Hassan Ali', 'hassan.ali@hotmail.com', '0333-5555555', '789 Street Road, Islamabad', 'Business Administration', 1, 'hassan789'),
(4, 'Ayesha Khan', 'ayesha.khan@gmail.com', '0345-1112223', '321 Garden Lane, Lahore', 'Computer Science', 1, 'ayesha321'),
(5, 'Ahmed Malik', 'ahmed.malik@yahoo.com', '0321-4447778', '567 Sky Tower, Islamabad', 'Engineering', 1, 'ahmed567'),
(6, 'Sana Shah', 'sana.shah@gmail.com', '0300-8889991', '987 River View, Karachi', 'Business Administration', 2, 'sana987'),
(7, 'Usman Ahmed', 'usman.ahmed@yahoo.com', '0311-3334445', '654 Hilltop Drive, Lahore', 'Computer Science', 2, 'usman654'),
(8, 'Nadia Khan', 'nadia.khan@hotmail.com', '0332-2223336', '789 Ocean View, Islamabad', 'Engineering', 2, 'nadia789'),
(9, 'Hamza Ali', 'hamza.ali@gmail.com', '0344-5556667', '432 Lake Road, Karachi', 'Business Administration', 2, 'hamza432'),
(10, 'Mariam Malik', 'mariam.malik@yahoo.com', '0320-7778889', '876 Sunset Boulevard, Lahore', 'Computer Science', 2, 'mariam876'),
(11, 'Zaim Abbasi', 'zaim@gmail.com', '123-456-7890', '789 Elm Street', 'Engineering', 1, '123');
*/

									    	-- Application Form Table Creation
CREATE TABLE ApplicationForm (
    application_id INT PRIMARY KEY IDENTITY,
    student_id INT,
    Name VARCHAR(255) NOT NULL,
    Department VARCHAR(100) NOT NULL,
    CGPA DECIMAL(3, 2) NOT NULL,
    course_id INT NOT NULL,
    position VARCHAR(2) NOT NULL,
    Lab_grade DECIMAL(3, 2),
    course_grade DECIMAL(3, 2) NOT NULL,
    pastExperience TEXT,
    FOREIGN KEY (student_id) REFERENCES Student(student_id)
);

SELECT * FROM ApplicationForm;













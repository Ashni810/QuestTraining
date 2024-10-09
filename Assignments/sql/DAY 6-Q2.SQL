Q2)
 You are tasked with creating a system to track patients and the appointments they make with doctors. Each patient has basic information like their name, age, gender, and contact details, while appointments include the appointment date, time, reason for the visit, and the doctor they will meet.

Tasks: Create a patients table with the following details:

id: A unique identifier for each patient (make it an auto-incrementing IDENTITY column).
first_name: The first name of the patient (cannot be NULL).
last_name: The last name of the patient (cannot be NULL). gender: The gender of the patient (only 'M', 'F', or 'Other' allowed).
age: The age of the patient (must be a positive integer and less than 120).
phone_number: The patient's phone number.
email: The patient's email address (must be unique).
created_at: The date and time the patient was registered (default to the current date and time).
Create an appointments table with the following details:

id: A unique identifier for each appointment (make it an auto-incrementing IDENTITY column).
patient_id: The ID of the patient who booked the appointment.
appointment_date: The date of the appointment (cannot be in the past).
appointment_time: The time of the appointment.
reason_for_visit: A description of why the patient is visiting (cannot be NULL).
doctor_name: The name of the doctor (cannot be NULL).
created_at: The date and time the appointment was created (default to the current date and time). Insert data:
Insert at least 5 patients and 5 appointments into the respective tables. Make sure to follow the constraints for age, appointment_date, reason_for_visit, and doctor_name.

CREATE TABLE patients (
  id INT IDENTITY(1,1) PRIMARY KEY,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  gender CHAR(1) CHECK (gender IN ('M', 'F', 'O')),
  age INT CHECK (age > 0 AND age < 120),
  phone_number BIGINT,
  email VARCHAR(100) UNIQUE NOT NULL,
  created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE appointments (
  id INT IDENTITY(1,1) PRIMARY KEY,
  patient_id INT NOT NULL,
  appointment_date DATE NOT NULL CHECK (appointment_date >= GETDATE()),
  appointment_time TIME NOT NULL,
  reason_for_visit VARCHAR(200) NOT NULL,
  doctor_name VARCHAR(100) NOT NULL,
  created_at DATETIME DEFAULT GETDATE(),
  FOREIGN KEY (patient_id) REFERENCES patients(id)
);

INSERT INTO patients (first_name, last_name, gender, age, phone_number, email)
VALUES
  ('John', 'Jacob', 'M', 30, 8301866133, 'john.jacob@example.com'),
  ('James', 'Kuriyan', 'F', 35, 9876543210, 'james.kuriyan@example.com'),
  ('Baby', 'Jimmy', 'M', 20, 8304804567, 'baby.jimmy@example.com'),
  ('Aleena', 'Francis', 'F', 35, 9497046614, 'aleena.francis@example.com'),
  ('Miya', 'TKP', 'M', 55, 9744752904, 'miya.tkp@example.com');


INSERT INTO appointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name)
VALUES
  (1, '2024-08-01', '09:00:00', 'Check-up', 'Dr. Smith'),
  (2, '2024-09-05', '10:00:00', 'Sick visit', 'Dr. Soniya'),
  (3, '2024-08-10', '11:00:00', 'Follow-up', 'Dr. Will'),
  (4, '2024-09-15', '12:00:00', 'New patient visit', 'Dr.Rose'),
  (5, '2024-08-20', '13:00:00', 'Emergency visit', 'Dr. David');

USE HospitalDB;

CREATE TABLE Appointment
(
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    PatientName VARCHAR(100),
    DoctorName VARCHAR(100),
    AppointmentDate DATE,
    AppointmentTime TIME,
    Status VARCHAR(50)
);
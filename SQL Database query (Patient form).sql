CREATE DATABASE HospitalDB;
GO

USE HospitalDB;

CREATE TABLE Patients
(
    PatientID INT PRIMARY KEY,
    FullName VARCHAR(100),
    Gender VARCHAR(20),
    Age INT,
    BloodGroup VARCHAR(10),
    Disease VARCHAR(100),
    Contact VARCHAR(20),
    Address VARCHAR(200),
    DoctorAssigned VARCHAR(100)
);
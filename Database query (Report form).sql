USE HospitalDB;

CREATE TABLE Reports
(
    ReportID INT PRIMARY KEY,
    TotalPatients INT,
    TotalDoctors INT,
    AppointmentsPerDay INT,
    RevenueStatistics DECIMAL(10,2),
    ReportDate DATE
);
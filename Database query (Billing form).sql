USE HospitalDB;

CREATE TABLE Billing
(
    BillID INT PRIMARY KEY,
    PatientID INT,
    PatientName VARCHAR(100),
    ConsultationCharges DECIMAL(10,2),
    MedicineCharges DECIMAL(10,2),
    LabTestCharges DECIMAL(10,2),
    TaxAmount DECIMAL(10,2),
    FinalAmount DECIMAL(10,2),
    PaymentStatus VARCHAR(20)
);
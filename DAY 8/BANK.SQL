--- Create the Customers table

CREATE TABLE Customers (
  CustomerID INT PRIMARY KEY IDENTITY(1,1),
  Name VARCHAR(50) NOT NULL,
  Address VARCHAR(100) NOT NULL,
  Phone BIGINT NOT NULL,
  Email VARCHAR(50) NOT NULL UNIQUE
);

-- Create the Accounts table
CREATE TABLE Accounts (
  AccountID INT PRIMARY KEY IDENTITY(1,1),
  CustomerID INT NOT NULL,
  AccountNo   VARCHAR(50) NOT NULL,
  AccountType VARCHAR(20) NOT NULL,
  Balance DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
  AccountStatus VARCHAR(20) NOT NULL DEFAULT 'Active',
  CONSTRAINT FK_Accounts_Customers FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Create the Transactions table
CREATE TABLE Transactions (
  TransactionID INT PRIMARY KEY IDENTITY(1,1),
  AccountID INT NOT NULL,
  TransactionDate DATETIME NOT NULL DEFAULT GETDATE(),
  TransactionType VARCHAR(20) NOT NULL,
  Amount DECIMAL(10, 2) NOT NULL,
  Description VARCHAR(100) NOT NULL,
  CONSTRAINT FK_Transactions_Accounts FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);
--insert values to customer table--
INSERT INTO Customers (Name, Address, Phone, Email)
VALUES ('James Will', '123 Main St', '7234567890', 'james@yahoo.com');

INSERT INTO Customers (Name, Address, Phone, Email)
VALUES ('Dane Smith', '456 Elm St', '9876543210', 'danesmith@gmail.com');

INSERT INTO Customers (Name, Address, Phone, Email)
VALUES ('Daisy Jake', '789 Oak St', '8551234567', 'daisy@gmail.com');

--insert values to account table--
INSERT INTO Accounts (CustomerID, AccountNo,AccountType, Balance)
VALUES (1, '423-154-1012','Checking', 100.00);

INSERT INTO Accounts (CustomerID,AccountNo,AccountType, Balance)
VALUES (1, '321-456-1023','Savings', 500.00);

INSERT INTO Accounts (CustomerID,AccountNo,AccountType, Balance)
VALUES (2, '789-123-1014','Checking', 200.00);

INSERT INTO Accounts (CustomerID,AccountNo,AccountType, Balance)
VALUES (3, '547-023-1045','Savings', 300.00);

--insert values to transaction table--
INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (1, '2022-01-01', 'Deposit', 100.00, 'Cash deposit');

INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (1, '2022-01-05', 'Withdrawal', 50.00, 'Cash withdrawal');

INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (2, '2022-01-10', 'Deposit', 200.00, 'Cash deposit');

INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (3, '2022-01-15', 'Transfer', 100.00, 'Transfer from savings');

--creating new record on customers table--
INSERT INTO Customers (Name, Address, Phone, Email)
VALUES ('Alice Brown', '123 villa St', '8301861234', 'alicebrown@example.com');

--inserting a new record into the Accounts table with the corresponding CustomerID--
INSERT INTO Accounts (CustomerID,AccountNo, AccountType, Balance)
VALUES (4, '103-786-1086','Current', 0.00);

--changing the account type from current to savings of the customer--
UPDATE Accounts
SET AccountType = 'Current'
WHERE AccountID = 3;

-- To view the balance --
SELECT Balance
FROM Accounts
WHERE AccountID = 5;

SELECT Balance
FROM Accounts
WHERE AccountID = 4;

--Updating the Balance column in the Accounts table--
UPDATE Accounts
SET Balance = Balance + 10000.00
WHERE AccountID = 5;

UPDATE Accounts
SET Balance = Balance - 50.00
WHERE AccountID = 5;

--Inserting a new record into the Transactions table with the corresponding AccountID and TransactionType as Withdrawal--
--withdraw-
INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (5, GETDATE(), 'Withdrawal', 50.00, 'Cash withdrawal');

--DEPOSIT--
--Inserting a new record into the Transactions table with the corresponding AccountID and TransactionType as DEPOSIT--
INSERT INTO Transactions (AccountID, TransactionDate, TransactionType, Amount, Description)
VALUES (3, GETDATE(), 'Deposit', 50.00, 'Cash Deposit');

--delete
DELETE FROM Customers
where CustomerID =2;

--view all Transaction History of a Customer based on account id--

SELECT *
FROM Transactions
WHERE AccountID = 1 ;



--view customers transcation history  based on less than 1000--
SELECT *
FROM Transactions
WHERE Amount < 1000 ;


--view using joins View All Transactions
SELECT 
    transactions.transaction_id,
    transactions.transaction_type,
    transactions.amount,
    accounts.account_number,
    customers.name AS customer_name,
    accounts.account_type,
    accounts.balance
FROM 
    transactions 
INNER JOIN 
    accounts  ON transactions.account_id = accounts.account_id
INNER JOIN 
    customers ON accounts.customer_id = customers.customer_id;
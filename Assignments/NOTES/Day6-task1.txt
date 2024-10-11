Q1. Different type of DataBase

Relational databases. 
NoSQL databases. 
Cloud databases. 
Columnar databases. 
Wide column databases.
Object-oriented databases. 
Key-value databases. 
Hierarchical databases.

Q2) Difference between Rdbms and nonRdbms(NOSQL)

The main difference between relational database management systems (RDBMS) and non-relational databases (NoSQL) is how data is organized and the type of data they store: 
 
RDBMS
Stores structured data in tables with rows and columns. Each row represents a record, and each column represents a field. RDBMS databases are good for projects with predictable data structure, size, and access frequency. They also offer security features like user authentication and access control. 
 
NoSQL
Stores unstructured data in a variety of data models, such as documents or key-value stores. NoSQL databases are good for applications that require large data volumes, low latency, and flexible data models. They are also best for rapid application development.

Q3) TOP DB USED BY COMPANYIES ?

Database (DB) Systems Used by Companies

There are various database systems used by companies, each with its strengths and weaknesses. Here are some of the most popular ones:

1. Relational Databases
MySQL: Widely used for web applications, especially for Content Management Systems (CMS) like WordPress and Joomla.
PostgreSQL: Known for its reliability and ability to handle large volumes of data, used by companies like Apple and Instagram.

Microsoft SQL Server: A popular choice for enterprise applications, used by companies like Microsoft and Accenture.

2. NoSQL Databases

MongoDB: A popular choice for big data and real-time web applications, used by companies like LinkedIn and eBay.
Cassandra: Designed for handling large amounts of distributed data, used by companies like Netflix and Twitter.
Redis: An in-memory data store, used by companies like GitHub and Pinterest.

3. Cloud-based Databases
Amazon Aurora: A MySQL-compatible database service, used by companies like Amazon and Airbnb.
Google Cloud SQL: A managed database service, used by companies like Google and Spotify.
Microsoft Azure Database Services: A cloud-based database service, used by companies like Microsoft and Dell.

4. Graph Databases
Neo4j: Used for storing and querying graph data structures, used by companies like Walmart and eBay.
Amazon Neptune: A graph database service, used by companies like Amazon and Siemens.

5. Time-series Databases
InfluxDB: Used for storing and querying time-series data, used by companies like Google and IBM.
OpenTSDB: A distributed time-series database, used by companies like Bloomberg and Yahoo!.


Q4) What is a Primary Key?
    
In relational database management systems, a primary key and foreign key are two essential concepts that help establish relationships between tables and ensure data integrity.

Primary Key (PK)
A primary key is a column or set of columns in a table that uniquely identifies each row in the table. It is used to enforce uniqueness and ensure that no two rows have the same values. A primary key is typically defined when creating a table, and it is usually denoted by the keyword PRIMARY KEY.

Characteristics of a Primary Key:

Uniqueness: Each value in the primary key column(s) must be unique.
Non-nullability: Primary key columns cannot contain null values.
Immutability: Primary key values should not be changed once they are inserted.

Q5) What is a Foreingn Key?

A foreign key is a column or set of columns in a table that references the primary key of another table. It establishes a relationship between two tables, allowing you to link data between them. A foreign key is typically defined when creating a table, and it is usually denoted by the keyword FOREIGN KEY.

Characteristics of a Foreign Key:

References: A foreign key references the primary key of another table.
Matching data type: The data type of the foreign key column(s) must match the data type of the referenced primary key column(s).


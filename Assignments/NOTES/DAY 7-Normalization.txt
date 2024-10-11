In database normalization, the goal is to organize the data in a way that minimizes data redundancy and dependency, making it more efficient and scalable.

Here are some of the most common forms of database normalization:

1. First Normal Form (1NF)

In 1NF, each table cell must contain a single value. This means that each column must have a unique name, and there can be no repeating groups or arrays.

Example: A table with a column "Phone Numbers" that contains multiple phone numbers separated by commas would not be in 1NF. Instead, each phone number should be in a separate row.

2. Second Normal Form (2NF)

In 2NF, each non-key attribute in a table must depend on the entire primary key. This means that if a table has a composite primary key, each non-key attribute must depend on all the columns that make up the primary key.

Example: A table with a composite primary key "Order ID" and "Product ID" would not be in 2NF if it had a column "Product Name" that only depends on "Product ID".

3. Third Normal Form (3NF)

In 3NF, if a table is in 2NF, and a non-key attribute depends on another non-key attribute, then it should be moved to a separate table.

Example: A table with columns "Customer ID", "Customer Name", and "Address" would not be in 3NF if the "Address" column depends on the "Customer Name" column.

4. Boyce-Codd Normal Form (BCNF)

BCNF is a higher level of normalization that ensures that a table is in 3NF and there are no transitive dependencies.

Example: A table with columns "Student ID", "Course ID", and "Grade" would not be in BCNF if the "Grade" column depends on the "Course ID" column, which in turn depends on the "Student ID" column.
This is a simple Entity Framework Code-First console application that creates a Student database and adds one student record. The project uses EF Core with SQLite and demonstrates the basic Code-First approach as covered in the course materials.

The application:
- Creates a Student model with basic properties
- Uses SchoolContext (DbContext) to connect to the database
- Creates the database automatically using EnsureCreated()
- Adds one student (Hasan olcc) to the database
- Displays confirmation messages

Output when running:
Database created successfully!
Student added: Hasan Aolcc
All done!

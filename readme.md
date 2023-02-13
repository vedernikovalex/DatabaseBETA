SIMPLE CRUD DATABASE APPLICATION

Allows to preform simple CRUD operations on specific database
Main functionalities are preformed by UnitOfWork and Repository design patterns
Visual representation of app was made by Windows Form by .NET in Visual Studio 2022

Database is performing by default on Isolation level "Read Uncommitted"
Database is accessing by default "localhost" database source and "technicka_kontrola" database name

These settings are changable, locate /DatabaseBeta/App.config file and open in any text editor
 - databaseSource -> "yourDatabaseSource"
 - databaseName -> "yourDatabaseName"
 - isolationLevel -> IsolationLevel

Isolation levels in App.config file examples (case sensitive):
    Unspecified
    Chaos
    ReadUncommitted
    ReadCommitted
    RepeatableRead
    Serializable
    Snapshot

To run application, locate /DatabaseBeta/bin/Debug/net6.0-windows/DatabaseBETA.exe
 - by default, sqlconnection is set to login via WindowsAuthentication because of common User access option absence
 - to get access of app, insert anything into login and password forms and press continue


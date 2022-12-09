# CITGameTracker
I have also performed unit testing located in TrackerLibrary. The file is called UnitTesting.cs. I tested different methods to see if I was getting the response that I 
wanted. Beyond that, I have included the Application Design document. It provides description to what the project is, along with a UML diagram. I also included 
a PDF that shows a flow diagram of how the application flows.

The purpose of this application is to allow users to keep track of teams, team members, games, and at the end who the winner is.

When this project is run, right away the team Member form pops up. One must complete all fields of the form otherwise a pop-up box will appear. 
It will indicate that form fields are blank. Once create member is created, 
I have it save to a specific folder on my machine. There a CSV file is automatically created and my values are place there prompty.
I could repeat this process as many times as necessary and the CVS file will automatically populate itself.

To have another screen popup, simply uncomment line 23 in Program.cs. The Winner Form will pop up. The setup is quite similar. 
One must complete all fields of the form. Otherwise, once again a popup box will appear indicating there has been an error. 
Once again, I have it save to a specific folder on my machine. There a CSV file is automatically created and my values are place there prompty. 
I could repeat this process as many times as necessary and the CVS file will automatically populate itself. 
This way an entire record of winners and team members can be present.

There is also a folder called DataAccess. 
This basically contains the different classes and interfaces I used to set up the connection so that these CSV files can be created. 
IDataConnection is an interface that GlobalConfig ends up using. This is a composition relationship as GlobalConfig has list of IDataConnections. 
If I were to expand this process, I would work on implementing some sort of database like SQL rather than a flat file. 
TextConnection inherits from IDataConnection as it implements its specific methods.
TextConnectorProcessor actually performs the saving of the file and defines the filepath.

The project is not finished product yet. I have not finished implementing each different UI page.
I have yet to put all the pieces together to make it one full, working application. However, I believe that I have a solid foundation. 


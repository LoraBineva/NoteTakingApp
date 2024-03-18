# NoteTakingApp
Description:
This is a notetaking app that I created using SQL (SSMS) and C# (Winforms). It contains 4 winforms. 
- The first one is a menu which links to the other forms via buttons.
- The second one inserts your notes in the database so that you could view them later. NT: When the user wants to write a second one, they first have to clear the two textboxes. 
- The third one shows your notes. By selecting the title of the note, you get its content as well as the date and time when it was written.
- The fourth one alllows you to delete notes from your database. Ones the notes are deleted they can't be recovered. 

Installation:
All of the code is available on Github and it is to be used in Visual Studio. In addition, the user has to create they own database on their computer with the following fields:
- A table with the name Notes which contains:
- Title varchar(MAX)
- Text varchar(MAX)
- Date varchar(MAX)
  
In addition the user has to change the reference to the database in ALL 3 forms (except the 1st, menu one) to the reference of their own databse. This is to be found in the Form_Load method.
Specific Line of Code:  sql = new SqlConnection(@"**(User's own server)**; Initial Catalog=**(Name of the databse)**; Integrated Security=True;");  

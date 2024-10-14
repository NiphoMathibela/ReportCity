ReadMe

NB: Make sure you have the latest version of .NET installed.

Setting Up The DB

1. Install XAMPP Control Panel if not already installed, the link can be found below https://www.apachefriends.org/download.html
----------------------------------------------------------------------------------------

2. Once the control Panel is installed open the file named "report_city.sql" using Visual Studio Code or any Text Editor.

3. Copy everything in the file to your clipboard.

4. Open the Xampp control app, and click "Start" on "Apache" and "MySQL"

5. On the MySQL module in Xampp control click the "Admin" button you will then be taken to the "PHPMyAdmin" home page.

6. Create a database called "report_city" using "PHPMyAdmin".

7. Once the database has been created select the database and paste the data you copied earlier from the "report_city.sql" file in the SQL tab. Make sure that you have selected the database in PHPMyAdmin before pasting the data in the SQL tab!

7.1 The following link "https://www.youtube.com/watch?v=ueWpNe0PG34" is for a video with a detailed description on how to use Xampp and create a database in PHPMyAdmin.

8. After pasting the data, run the SQL query in the database. The query will create all neccessary tables and add the appropriate data.

8.1. Ensure that you edit the issues table and set the "ReportId" to Auto Increment.

9. Once the database has been created and data has been added, you can now open the C# solution in Visual Studio Code. You can open Visual Studio code and open the project folder in Visual Studio. You can then proceed to run the project in Vusual Studio Code.







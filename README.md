# 7sala-task
This is a small web app

TASK GIVEN:
Create a web application.
The application sections are :
 - back end: Uses .NET Core API, using Entity Framework with code first approach to create SQL server table for some Products with name, price, image and short description.
 - function to List some of the previous products as featured and some as best sellers.
 - CRUD operations for categories
 - SPA application contains the same or our section inside the 7sala mobile app all load from the back-end.

Front-end:
 - containing Reusable components
 - using Bootstrap
 - custom CSS
 - the listing include paging and sorting

A unit test application for testing API calls

WHAT DID I COMPLETE HERE:

 - Created .NET Core Web API appication that recieves GET, PUT, DELETE requests (Controller layer with Product controller class). Web API sends the information about Products in JSON format. 
 - Project is based on MVC pattern, so in Model directory a class SingleProduct is a base for DBContext (that is to be used for database migration with Entity Framework).  
 - For the simplicity I have kept everything in the same project solution (which helped me with dealing with cross origin request problems and application layer connection). 
 - In wwwroot directory we can find the front-end/ View part of the MVC. index.html with following custom CSS, Bootstrap, JavaScript and JQuery folers and files.
 - Single page website recieves JSON data and displays them by clicking on product link in the navigation bar.
 
 WHAT TO IMPROVE AND COMPLETE:
 
 Obviously there are parts that have not been finished yet. Besides that while researching and working on the task, I have realised some imporovements that can be made in the very architecture and layaring of the solution. I will list some here:
  - Front-end should have been developed seperately. This would make development of the design much easier plus using Visual Studio Code or Sublime text as editors for front end has some perks and shortcuts that make a differenct while working. Another thing I would definatelly use is a framework like React. It handles JavaScript part very well and helps writing reusable HTML and CSS because of it's components. Unfortunately, I did not have time time to do so.
  - Complete the database migration with entity framework
  - Complete the requested functionality in making a list of best seller and featured products with listing and paging
  - Add image component to JSON within the .NET API
  
  
  
 

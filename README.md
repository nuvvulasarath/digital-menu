What I have Done:
1) Downloaded and installed Mongo DB Server and installed MongoDB Compass
2) Creaed a free cluster with the help of MongoDB Atlas (created an account) 
3) Opened the cluster in the local instance of MongoDB Compass by using the connection string provided 
4) Created "Sample" Database and "Digital Menu" collection using GUI of MongoDB Compass
5) Prepared Sample Dishes JSON and Imported into the collection that is created in the previous step
6) Created an ASP .Net WEB API project and named it as "DigitalMenuApplication"
7) Added the MongoDB Driver for C# to the solution using NuGet Package Manager. 
8) Created a Data Model class inside Models folder with all relevant properties.
9) Added connection string key and value inside app settings section of Web.config file.
10) Created a controller class (DishController) inside controllers folder.
11) Implemented Action methods for Adding / updating a Dish, geting a specific dish information and getting all dishes information.
12) Tested all 3 endpoints with the help of postman client.


Advantages of MongoDB over SQL:
1) No Predefined schema needed 
2) Can store different types of data in same collection
3) Can perform async operations on collection documents
4) Don't have to worry about rapid data growth

Disadvantages of Mongo DB over SQL:
1) There is no default transaction support, we need to handle this ourself 
2) There is no support for joins


Advantages of Having Digital Menu:
1) Accuracy of Items Availability
2) Saves lot of time and effort for Hotel staff
3) Customers will have real time information infront of them so their overall experience will be smooth which is benificial to the Hotel Management.


Problems encountered while implementing the above application: 
1) As i am a beginner in Mongo DB, took some time in creating cluster in order to create database and collection.
2) Took some time to map auto generated document id property to C# model Id property. 
3) As I was testing the end points at some point I noticed API is not able to connect to Mongo DB Database because the IP Address that is specified in Atlas account Network Access Tab is different. So i added the setting "access from everywhere" (default IP address) just for the sake of running the application. I understand that we should never do that in real time applications.

# TransfareDataBetweenDifferentDataBases
Migrate data between different databases as well as between different tables
# Use EntityFramework DataBaseFirst 
## Steps :

1- Conect to Database use EntityFramework DatabaseFirst you need two DBContext The First you can name DB1 Or source and second can name DB2 ,
in this App I am Name DB1 and DB2.

2- When connecting to the database, you can choose the table whose data you want to migrate, and there is no need to choose all the tables in the database.


3- ConectionString Found in App.config File but I am Change ConectionString in Constractor Class (DB1 , DB2) and remove from App.config .

###Notes :

In this way, you can migrate data with more than one database and more than one table.
I am sure that it is not the ideal solution, but it was perfect for me in the problem I faced.
Thank you...any comments ^_^ .

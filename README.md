# ASP.NET_Calculator

Description of the program code/architecture:

This is a regular calculator, based on ASP.NET MVC.
It has a model (CalcModel) that represents operation of calculation, controller for processing requests and a view for displaying data
The main work is distributed between the HttpGet method (Calculate) and view (Index.cshtml)
View contains input field and buttons for digits and operators. Also view contains some javascript code for filling input field by pressing the buttons clearing the input field.

Description to the user:

In order to use my calculator there is should be a working server.
If this condition is met, then user can go to URL "https://<localhost adress for local server>/Home/Calculate"

![alt text](https://github.com/[VladAveryanov]/[ASP.NET_Calculator]/blob/[master]/asp.net_calc.png?raw=true)

To enter a number user should press a button for number
To make operation user should press a button for operation
To perform calculation user should press a button "Calculate"

~~~
WidgetsDrawing application v1.0.0 by Omer Emre Pelit
~~~

~~~
Project implements a widget drawing console application with scalable architecture:

-Separate command (write) and query (read) handlers for maintainability. (CQRS)
 Alternatively widget service could be implemented as well.

-Simplified widget creation with the Factory Pattern.

-Decoupled storage management with the Repository Pattern.

-Also, validation validates the widget properties are correct or not.
~~~

~~~
Layers:
-Command,Query handlers and controllers implemented in Application layer for business logic.
-Entities and repositories handled in 'Data' layer.
-WidgetFactory implemented in 'Infrastructure' layer.
-Unit and integration tests implemented in 'Tests' class library project
~~~

~~~
How to run?
-Build the solution and run the project. It will run once, give the results and stop.
~~~

~~~
How to execute tests?
 run "dotnet test" in the terminal.
~~~

~~~
What else would I implement if I had more time?
I would;
1. Add mapper function in application layer, with the data transfer objects.
2. Implement detailed logging for debugging purposes.
3. Add a database layer for persistence.
4. Add a REST api for Front-End requests and external use.
5. Create a micro front-end project either with ReactJS or Angular.
~~~
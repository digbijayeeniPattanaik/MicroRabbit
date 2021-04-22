# RabbitMQ


- Installed Erlang and RabbitMQ as an administrator account


- Enable the administrator dashboard or the managment UI. 
- Run the below command in RabbitMQ command prompt
rabbitmq-plugins enable rabbitmq_management

Since it was failing tried the below.


Check the RabbitMQ service status
A) Check if the RabbitMQ service is installed and running by opening the Task Manager.

If it's not, do the following:

- Open a command-line console (run as Administrator) and change your directory to the RabbitMQ batch scripts folder.
Run - CMD and go to C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.14\sbin
In the above path rabbitmq-service.bat is available

- Execute the following commands to remove the currently running service, install a new one, and start it:
  - rabbitmq-service.bat remove
  - rabbitmq-service.bat install
  - rabbitmq-service.bat start

- Go to http://localhost:15672
Username & password both as guest

Stacks used
- .net Core
- EntityFramework.Core
- MediatR
- RabbitMQ
- Swagger

Additional information - 
- https://www.programmingwithwolfgang.com/rabbitmq-in-an-asp-net-core-3-1-microservice/
- https://codeopinion.com/why-use-mediatr-3-reasons-why-and-1-reason-not/
- https://www.udemy.com/course/getting-started-net-core-microservices-rabbitmq/


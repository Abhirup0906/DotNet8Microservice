This is a Sample ASP .Net 8 based Microservice framework. The design pattern considered for this application are mentioned below. 

    SOLID: Every class and packages are desinged adhereing SOLID principles. 
  
    CQRS: Database operations are build using CQRS pattern where Command & Query uses different DB connections. Incase of different read and write DB it will help. 
  
    Streaming: API is designed in for steaming of data. The data will stream directly from the database. 
  
    Clean Architecture: Uses clean architecture design principles. Any new implementation like 3rd party API/Storage/NoSQL/Event Sourcing etc. will have sepearete code base and will integrate with Orchestrator. 
  
    Orchestrator: It uses orchestrator pattern to merge different infrastructure operations. 

    Asynchronous: Endpoints are totally asynchronous so it will perform better. 

    
  
  

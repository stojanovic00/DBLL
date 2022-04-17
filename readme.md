## Database Loader and Linker (DBLL)

This project is extendable prototype for smaller projects where all files are stored locally using csv,json,xml... and you can
allow that all lists are loaded in RAM on startup of a program. 

Inside "ClassDiagram" folder is class diagram of prototype.

Inside "School" folder is Visual Studio project that contains base code generated from class diagram from which some classes could be directly used for real project.

Inside "CSVserializationExample" folder is example of serialization using CSV that can be used for implementation of a project. Interesting part of this serialization is that it covers serialization of an object that contains a list of other objects as its field but during serialzation only ids of nested objects are stored, no whole objects. During deserialization program links real objects to stored ids. 

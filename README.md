# Hotel Management System

Language - C#, framework - Entity Framework
Simple hotel management system with three roles - administrator, manager and receptionist.

Using this system, you can simply add new reservations, services, rooms, etc. 

Roles
- administrator - if the user is with this role, it has a fully access to the system. It can edit/delete other users, add new room information or edit it. Also, it can take a backup to the database or restore. 
- manager - it has almost the same rights but it cannot "work" with users, cannot work with the database.
- receptionist - this is the role with the least rights. The receptionist can only create reservations, view the statistics and the reports. 

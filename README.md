# Legend of the 5 Rings Database (LOT5RDB) #

## What is LOT5RDB

Legend of the 5 Rings is a table top role playing game that takes place in an Easter Medieval Fantasy RPG that takes place
in a world called Rokugan. This web app is intended to be a tool for playing this game as well as Gamemastering. The first
phase of this app will be purely reference of Items, equipment, and skills in the game. 

### EquipmentDbContext Commands

To add a new migration use the following command

### ``dotnet ef migrations add <Migration Name> -p LOT5RDB.Data -s LOT5RDB --context EquipmentDbContext -o Migrations\EquipmentDb -v``

Update Database

### ``dotnet ef database update -p LOT5RDB.Data -s LOT5RDB --context DescriptionsDbContext -v``

### DescriptionDbContext Commands

To add a new migration use the following command 

### ``dotnet ef migrations add <Migration Name> -p LOT5RDB.Data -s LOT5RDB --context DescriptionsDbContext -o Migrations\DescriptionsDb -v``

Update Database

### ``dotnet ef database update -p LOT5RDB.Data -s LOT5RDB --context DescriptionsDbContext -v``
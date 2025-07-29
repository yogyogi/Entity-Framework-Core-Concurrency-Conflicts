# Entity Framework Core Concurrency Conflicts

<img src="https://www.yogihosting.com/wp-content/uploads/2025/07/concurrency-conflicts-entity-framework-core.png" alt="Entity Framework Core Concurrency Conflicts"  title="Entity Framework Core Concurrency Conflicts">

Multiple users trying to update an entity data at the same time can lead to inconsistencies and data corruption. In this repository we are going to implement Optimistic concurrency in CRUD Operations. Tutorial <a href="https://www.yogihosting.com/concurrency-conflicts-entity-framework-core/" target="_blank">link</a>

## Version
.NET 9.0

## Instruction
To create database change the connection string in the `appsettings.json` file and then perform migration - `PM> add-migration Migration1` `PM> Update-Database`

## What is covered
The following things are implemented in this repository:

- [x] How to implement Optimistic concurrency in Entity Framework Core
- [x] CRUD Operations
- [x] Create Records
- [x] Read Records
- [x] Update Records with Concurrency Conflicts resolution
- [x] Delete Records with Concurrency Conflicts resolution 

## Support

Your support of every $5 will be a great reward for me to carry on my work. Thank you !

<a href="https://www.buymeacoffee.com/YogYogi" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" width="200"  style="height: 60px !important;width: 200px !important;" ></a>
<a href="https://www.paypal.com/paypalme/yogihosting" target="_blank"><img src="https://raw.githubusercontent.com/yogyogi/yogyogi/main/paypal.png" alt="Paypal Me" width="300"></a>


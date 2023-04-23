# Hotel Reservations Manager

# Описание:

- Създадено като проект за ИТ Кариера модул 13 от Стоил Стоилов, Станимир Райков и Александър Костадинов. Разработено на ASP. NET 6 MVC Web App.

# Възможности: 

- Приложението служи за записване и запазване на хотелски стаи за различни клиенти. Всеки работник(User) в хотела, след вход или регистрация в системата, може да добавя клиенти, както и да прави резервации. При правенето на резервация се изисква Room ID и User ID, както и дата на настаняване и дата на напускане. Може и да се отбележи дали резержацията ще има включена закуска или ще бъде all inclusive. Накрая се записва дължимата сума. Всеки User може да изтрива или променя дадени клиенти и резервации. User- ите се контролират от админски профил, който може да добавя, редактира и изтрива стаи.

# Структура:

- Трислойна MVC архитектура

 Data layer:

- Code First database
- MSSQL Server Database
- Entity Framework Core
- Migrations

Controller Layer:

- Асинхронна структура
- CRUD Operations
- User authentication 

Presentation Layer:

- ASP. NET 6
- Razor pages
- Data validation

Проблеми:

- Изникнаха проблеми със User authorization системата, които не бяхме способни да разрешим на време.
- Проблем с правенето на резервация, който изникна във финалния етап от разработката на приложението.




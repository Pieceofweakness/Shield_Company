# Shield_Company
Автоматизированная информационная система для страховой компании "ЩИТ"


1.	Установите .NET 8.0 SDK: https://dotnet.microsoft.com/download
2.	Проверьте установку: dotnet --version
3.	Установите Git: https://git-scm.com/downloads
4.	Проверьте установку: git --version
5.	Установите PostgreSQL Server и pgAdmin4
6.	В pgAdmin или через командную строку создайте базу данных с помощью команды: CREATE DATABASE Shield_Company
7.	Запустите SQL-скрипт из Приложения А в pgAdmin. Скрипт сам создаст таблицы.
8.	Запустите SQL-скрипт из Приложения Б в pgAdmin. Скрипт добавит тестовые данные в таблицы.
9.	В файле DatabaseAdapter.cs укажите параметры своей БД (хост, порт, имя БД, логин, пароль).
10.	Откройте командную строку (cmd)
11.	Выполните: git clone https://github.com/Pieceofweakness/Shield_Company
12.	Перейдите в каталог с файлом проекта: cd Shield_Company\Shiled
13.	Выполните: dotnet build
14.	Выполните: dotnet run 

# Movie Catalog

Projekt zaliczeniowy MVC – Katalog kolekcji filmów.

## Spis treści

1. Opis projektu
2. Funkcjonalności
3. Uruchomienie aplikacji

## Opis projektu

Aplikacja internetowa wykonana w technologii ASP.NET Core MVC umożliwiająca zarządzanie katalogiem filmów. Dane przechowywane są w bazie danych SQL Server z wykorzystaniem Entity Framework Core.

## Funkcjonalności

* wyświetlanie listy filmów
* dodawanie nowych filmów
* edycja filmów
* usuwanie filmów
* wyświetlanie szczegółów filmu
* wyszukiwanie filmów po tytule
* walidacja danych formularzy

Model filmu zawiera:

* tytuł
* reżysera
* ocenę

Dodatkowo zaimplementowano model Review powiązany z filmem.

## Uruchomienie aplikacji

### Wymagania

* Visual Studio 2022
* .NET 8 SDK
* SQL Server LocalDB

### Uruchomienie

1. Otwórz projekt w Visual Studio.
2. Otwórz Konsolę Menedżera Pakietów NuGet.
3. Wykonaj polecenie Update-Database.
4. Uruchom aplikację klawiszem F5.
5. Przejdź do zakładki Movies.

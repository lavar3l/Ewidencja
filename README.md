# Ewidencja sprzętu komputerowego


Program bazodanowy umożliwiający ewidencję sprzętu komputerowego przez zewnętrzny serwis. Aplikacja zawiera cztery moduły: trzy moduły umożliwiające dodawanie, edytowanie i usuwanie danych firm, pracowników oraz komputerów, a także moduł umożliwiający generowanie raportów.

Program umożliwia ewidencję podstawowych parametrów komputerów, a także powiązanie ich z konkretną firmą oraz odpowiedzialnym pracownikiem.

# Przed uruchomieniem

Przed uruchomieniem programu warto upewnić się, że w pliku konfiguracyjnym znajdują się poprawne dane serwera SQL oraz czy została zainstalowana przykładowa baza danych.

## Baza danych

Aplikacja operuje na bazie danych Microsoft SQL Server. Działanie programu zostało przetestowane z wykorzystaniem Microsoft SQL Server 2019 Developer.

### Połączenie z serwerem SQL
Połączenie z serwerem SQL można skonfigurować w dołączonym do aplikacji pliku konfiguracyjnym **App.config**. W tym celu zależy zmodyfikować pole `connectionString`w sekcji `connectionStrings` wpisując pożądany adres bazy danych w polu `Data source` oraz dane logowania.

Przykładowy fragment konfiguracji (połączenie z lokalnym serwerem Microsoft SQL przy użyciu uwierzytelniania systemu Windows):

      <connectionStrings>
        <add name="InventoryDB" connectionString="Data Source=localhost;Initial Catalog=Inventory;Trusted_Connection=True;" />
      </connectionStrings>

Przykładowy fragment konfiguracji (połączenie z lokalnym serwerem Microsoft SQL z wykorzystaniem loginu i hasła):

    <configuration>
      <connectionStrings>
        <add name="InventoryDB" connectionString="Data Source=localhost;Initial Catalog=Inventory;User ID=<your login>;Password=<your password>" />
      </connectionStrings>
    </configuration>


**Uwaga! Nie należy modyfikować wartości zawierających nazwę bazy danych (`InventoryDB`, `Inventory`).**



### Przykładowa baza danych

Pliki projektu zawierają skrypt `create_db.sql`, który umożliwia wygenerowanie bazy danych wypełnionej przykładowymi danymi. W celu załadowania przykładowej bazy danych, należy uruchomić ten skrypt na serwerze Microsoft SQL.

## Kompilacja aplikacji

W archiwum ZIP zawarte są pliki źródłowe oraz projekt środowiska Visual Studio 2019 przy użyciu którego można skompilować program.

Program został napisany w języku C# (.NET 5.0).

Kompilacja programu została przetestowana przy użyciu środowiska Visual Studio 2019 Enterprise w 64-bitowym systemie Windows 10 (20H2).

# Uruchomienie programu
Jeżeli na komputerze uruchamiana jest skompilowana wersja programu, może być konieczne zainstalowanie środowiska .NET 5.0 ([link do pobrania](https://dotnet.microsoft.com/download/dotnet/5.0)).

Działanie programu zostało przetestowane na komputerze działającym pod kontrolą systemu Windows 10 (20H2) w wersji 64-bitowej.

Po uruchomieniu programu otworzy się główne okno, które umożliwia uruchomienie dowolnego modułu programu ("Firmy", "Pracownicy", "Komputery", "Raporty".



# PaycardEditor

Intrukcja uruchomienia aplikacji desktopowej zarządzania kartami płatniczymi "Paycard 3dit0r"

    <-----Opcja bez instalacji aplikacji poprzez plik instalacyjny Setup----->
    
1. Aplikację należy uruchomić w oprogramowaniu VisualStudio 2022 z zainstalowanym pakietem "Programowanie aplikacji klasycznych dla platformy .NET" oraz posiadać zainstalowany MS SQL Server minimum wersja 2014.
2. Przed uruchomieniem aplikacji należy odpowiednio dostosować nazwę serwera SQL w pliku appsettings.json w Projekcie PaycardEditor.WinForms. Domyślnie ustawiono nazwę serwera jako "localhost". Jeśli po instalacji MS SQL Server nie zmienialiśmy nazwy serwera to wszystko powinno zadziałać.
3. Ustawiamy projekt "PaycardEditor.WinForms" jako projekt startowy klikając w jego nazwę prawym przyciskiem myszy i wybierając opcję "Ustaw jako projekt startowy".
4. Klikamy przycisk Play z zielonym trójkątem i nazwą projektu aby uruchomić aplikację.
5. Po uruchomieniu aplikacji wchodzimy w ustawienia klikając w przycisk znajdujący się w lewym górnym rogu ekranu głównego.
6. Aby utworzyć lub zaktualizować strukturę bazy danych potrzebnej do aplikacji należy kliknąć w przycisk "Utwórz/zaktualizuj bazę danych". Jeśli wszystko przebiegnie pomyślnie dostaniemy informację zwrotną z aplikacji.
7. Po utworzeniu bazy możemy swobodnie korzystać z aplikacji edytora kart płatniczych. 

OBJECTIVE:
    • Person – abstract classin yaradin. Id, FirstName, LastName propertyleri olacag. GetFullName() virtual metodu olsun.
    • Employee – Person-dan miras alan classdir. Salary propertysi olacag,CalculateBonus() virtual, default 10% bonus elave edecek salarya.
    • IWorkable interfeysin implement etsin  WorkOnProject(Project project) metodu olacag
    • Manager – Employee-dən miras alacag
    • Teams arrayini ozunde saxlayacag Employee tipinde array olacaq.Əlavə olaraq AddToTeam(Employee emp) metodu olacaq.Project – record type olaraq yaradın. Id, Name, StartDate, EndDate, Status (string istifadə edin)
    • ConfidentialProject – sealed class, Project-dən inherit etsin və əlavə  SecurityLevel propertysi olacag.
    • CalculateDuration(Project project) – layihə müddətini günlərlə qaytarsın
    • PrintEmployeeInfo(Employee e) – employee məlumatını konsola yazsın(CalculateDuration və PrintEmployeeInfo metodları üçün ayrıca static Utilities class yaradılmalıdır. Bu metodlar heç bir instance-a bağlı olmadan istifadə olunmalıdır)
    • Employee tipinde  array yaradin.Ternary operator ilə bonus səviyyəsini High/Low kimi göstərin


NOTES:
    • Interface shouldn't be in Models folder !

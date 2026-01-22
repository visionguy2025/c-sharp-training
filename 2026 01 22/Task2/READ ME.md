##### OBJECTIVE INSTRUCTIONS #####
    Book --> Guid Id,string Title,string Author,int Year,bool IsAvailable(kitab hal-hazırda icarədədir, yoxsa boşdur)
    User --> Guid Id,string Name,List<Book> BorrowedBooks
    Library --> List<Book> Books,List<User> Users
    əgər istifadəçi mövcud deyilsə və ya kitab tapılmırsa BookNotFoundException,UserNotFoundException,BorrowBook metodunda kitab artıq icarədədirsə, InvalidOperationException atin
    Librarryde olan metodlar
    public void AddBook(Book book)
    public void RemoveBook(Guid bookId)
    public void RegisterUser(User user)
    public void BorrowBook(Guid userId, Guid bookId)
    public void ReturnBook(Guid userId, Guid bookId)
    public List<Book> SearchBooks(string keyword)
    public void ListAllBooks()
    public void ListBorrowedBooks()
    1. Kitab əlavə et
    2. İstifadəçi qeydiyyat
    3. Kitab icarəyə götür
    4. Kitab qaytar
    5. Bütün kitabları göstər
    6. Axtarış
    0. Çıxış

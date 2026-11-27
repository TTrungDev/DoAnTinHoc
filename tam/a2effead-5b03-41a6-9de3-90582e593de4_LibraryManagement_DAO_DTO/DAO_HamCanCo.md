# Danh sách hàm DAO (hợp đồng giữa Trung, Triệu, Triết)

- Mọi DAO là singleton: `XxxDAO.Instance.TênHàm(...)` (riêng `ReaderDAO` đang là `ReaderDAO.Instation`, giữ nguyên để không vỡ giao diện).
- Thêm/sửa/xóa trả `bool`; tìm kiếm trả `List<DTO>`; không có dữ liệu trả danh sách rỗng hoặc `null` (với hàm `Xxx?`).
- Hàm **có sẵn** (đã code): `CategoryDAO.LoadCategoryList`, `ReaderDAO.LoadReaderList`. Còn lại là khung, Triệu điền thân hàm.
- Cột SP đề xuất là tên stored procedure Trung sẽ viết bên Database.

## AccountDAO (Tài khoản, đăng nhập, đăng ký)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `Account? Login(string username, string passwordHash)` | Đăng nhập: trả về tài khoản (kèm FullName) hoặc null nếu sai tên/mật khẩu | USP_Login |
| `bool Register(Reader reader, string username, string passwordHash)` | Đăng ký độc giả mới: tạo Users + Accounts (Role = Reader) trong 1 transaction | USP_Register |
| `List<Account> LoadAccountList()` | Lấy toàn bộ tài khoản (JOIN Users để có FullName) | USP_GetAccounts |
| `bool AddAccount(Account account)` | Tạo tài khoản cho 1 User đã có (account.UserID) | USP_AddAccount |
| `bool UpdateRole(int accountId, string role)` | Đổi vai trò (Admin, Librarian, Reader) | USP_UpdateAccountRole |
| `bool ChangePassword(int accountId, string newPasswordHash)` | Đổi mật khẩu (nhận vào hash, không nhận mật khẩu gốc) | USP_ChangePassword |
| `bool DeleteAccount(int accountId)` | Xóa tài khoản | USP_DeleteAccount |
| `bool IsUsernameExists(string username)` | Kiểm tra tên đăng nhập đã tồn tại chưa | USP_IsUsernameExists |

## CategoryDAO (Thể loại sách)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Category> LoadCategoryList()` | Lấy toàn bộ thể loại (**đã có**) | USP_GetCategories |
| `List<Category> SearchCategories(string keyword)` | Tìm thể loại theo tên (LIKE) | USP_SearchCategories |
| `bool AddCategory(Category category)` | Thêm thể loại | USP_AddCategory |
| `bool UpdateCategory(Category category)` | Sửa thể loại theo category.ID | USP_UpdateCategory |
| `bool DeleteCategory(int categoryId)` | Xóa thể loại; trả false nếu còn sách thuộc thể loại này | USP_DeleteCategory |
| `bool IsNameExists(string name)` | Kiểm tra trùng tên thể loại | USP_IsCategoryNameExists |

## AuthorDAO (Tác giả)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Author> LoadAuthorList()` | Lấy toàn bộ tác giả | USP_GetAuthors |
| `List<Author> SearchAuthors(string keyword)` | Tìm tác giả theo tên (LIKE) | USP_SearchAuthors |
| `bool AddAuthor(Author author)` | Thêm tác giả | USP_AddAuthor |
| `bool UpdateAuthor(Author author)` | Sửa tác giả theo author.ID | USP_UpdateAuthor |
| `bool DeleteAuthor(int authorId)` | Xóa tác giả; trả false nếu còn sách của tác giả này | USP_DeleteAuthor |

## PublisherDAO (Nhà xuất bản)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Publisher> LoadPublisherList()` | Lấy toàn bộ nhà xuất bản | USP_GetPublishers |
| `List<Publisher> SearchPublishers(string keyword)` | Tìm NXB theo tên (LIKE) | USP_SearchPublishers |
| `bool AddPublisher(Publisher publisher)` | Thêm NXB | USP_AddPublisher |
| `bool UpdatePublisher(Publisher publisher)` | Sửa NXB theo publisher.ID | USP_UpdatePublisher |
| `bool DeletePublisher(int publisherId)` | Xóa NXB; trả false nếu còn sách của NXB này | USP_DeletePublisher |
| `bool IsNameExists(string name)` | Kiểm tra trùng tên NXB | USP_IsPublisherNameExists |

## BookDAO (Sách, tìm kiếm, lọc, sắp xếp)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Book> LoadBookList()` | Lấy toàn bộ sách (JOIN để có CategoryName, AuthorName, PublisherName) | USP_GetBooks |
| `List<Book> SearchBooks(string keyword, string criteria, int? categoryId, string sortBy, bool ascending)` | Tìm/lọc/sắp xếp. criteria: ID | Title | Author | Publisher | Category (rỗng = tìm mọi cột). categoryId null = không lọc. sortBy: Title | PublishYear | Quantity | USP_SearchBooks |
| `Book? GetBookById(int bookId)` | Lấy 1 cuốn sách, không có thì null | USP_GetBookById |
| `bool AddBook(Book book)` | Thêm sách (Available ban đầu = Quantity) | USP_AddBook |
| `bool UpdateBook(Book book)` | Sửa sách theo book.ID | USP_UpdateBook |
| `bool DeleteBook(int bookId)` | Xóa sách; trả false nếu sách đã có trong phiếu mượn | USP_DeleteBook |
| `List<Book> LoadBooksBorrowedByReader(int readerId)` | Các sách độc giả đã mượn (có Description), làm dữ liệu cho AI đề xuất | USP_GetBooksBorrowedByReader |

## ReaderDAO (Độc giả và nạp quỹ)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Reader> LoadReaderList(object[] find = null)` | Lấy độc giả, lọc theo tên (**đã có**) | USP_GetReadersByFullName |
| `Reader? GetReaderById(int readerId)` | Lấy 1 độc giả, không có thì null | USP_GetReaderById |
| `List<Reader> SearchReaders(string keyword)` | Tìm theo tên, SĐT hoặc email (LIKE) | USP_SearchReaders |
| `bool AddReader(Reader reader)` | Thêm độc giả (Users) | USP_AddReader |
| `bool UpdateReader(Reader reader)` | Sửa độc giả theo reader.ID (không sửa Balance) | USP_UpdateReader |
| `bool DeleteReader(int readerId)` | Xóa độc giả; trả false nếu còn sách chưa trả hoặc đã có phiếu mượn | USP_DeleteReader |
| `bool IsEmailExists(string email, int? excludeReaderId = null)` | Kiểm tra trùng email (bỏ qua chính độc giả đang sửa) | USP_IsEmailExists |
| `decimal GetBalance(int readerId)` | Số dư quỹ hiện tại | USP_GetBalance |
| `bool Deposit(int readerId, decimal amount, int staffId)` | Nạp quỹ (amount > 0): cộng Balance và ghi WalletTransactions (Deposit) trong 1 transaction | USP_Deposit |
| `List<WalletTransaction> LoadWalletHistory(int readerId)` | Lịch sử nạp quỹ và phạt của độc giả, mới nhất trước | USP_GetWalletHistory |

## BorrowRecordDAO (Phiếu mượn sách)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `int CreateBorrowRecord(BorrowRecord record)` | Lập phiếu mượn: thêm BorrowRecords + BorrowDetails (record.Details) và trừ Books.Available trong 1 transaction. Trả BorrowID mới, thất bại trả 0 | USP_CreateBorrowRecord |
| `List<BorrowRecord> LoadBorrowRecordList()` | Danh sách phiếu mượn (có ReaderName, IssuedByName), mới nhất trước | USP_GetBorrowRecords |
| `List<BorrowRecord> LoadBorrowRecordsByReader(int readerId)` | Phiếu mượn của 1 độc giả (dùng cho lịch sử của độc giả) | USP_GetBorrowRecordsByReader |
| `List<BorrowDetail> LoadBorrowDetails(int borrowId)` | Các cuốn trong 1 phiếu (có BookTitle) | USP_GetBorrowDetails |
| `int CountBooksBorrowing(int readerId)` | Tổng số cuốn độc giả đang mượn chưa trả (kiểm tra MaxBooksPerReader) | USP_CountBooksBorrowing |
| `bool HasOverdue(int readerId)` | Độc giả có sách quá hạn chưa trả không (nếu có thì không cho mượn) | USP_HasOverdue |
| `int GetAvailable(int bookId)` | Số cuốn còn trong kho của 1 sách | USP_GetAvailable |

## ReturnRecordDAO (Trả sách và tính phạt)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<BorrowDetail> LoadUnreturnedDetails(int readerId)` | Các cuốn độc giả đang mượn chưa trả (có BookTitle, BorrowDate, DueDate) | USP_GetUnreturnedDetails |
| `List<BorrowDetail> LoadUnreturnedDetailsByBorrowId(int borrowId)` | Các cuốn chưa trả của 1 phiếu (tìm theo mã phiếu) | USP_GetUnreturnedDetailsByBorrowId |
| `decimal CalculateFine(DateTime dueDate, DateTime returnDate)` | Tiền phạt = số ngày trễ x FinePerDay (lấy từ Settings). Không trễ trả 0 | (dùng SettingDAO.GetFinePerDay) |
| `bool ReturnBooks(List<int> detailIds, DateTime returnDate, int staffId, out string message)` | Trả các cuốn đã chọn trong 1 transaction: ghi ReturnDate và FineAmount, cộng lại Available, trừ phạt vào Balance, ghi WalletTransactions (Fine). Thất bại thì message nêu lý do | USP_ReturnBooks |

## OverdueDAO (Sách quá hạn)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<OverdueItem> LoadOverdueList()` | Sách quá hạn chưa trả: DaysLate = hôm nay - DueDate, FineAmount = DaysLate x FinePerDay. Tính bằng query, không lưu cứng | USP_GetOverdueList |
| `List<OverdueItem> SearchOverdue(string keyword)` | Tìm trong danh sách quá hạn theo tên độc giả hoặc tên sách | USP_SearchOverdue |

## StatisticalDAO (Thống kê, báo cáo)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `BorrowSummary GetSummary(DateTime fromDate, DateTime toDate)` | Tổng phiếu mượn, đã trả, chưa trả, tổng phạt trong khoảng ngày | USP_GetBorrowSummary |
| `List<BorrowStat> GetBorrowReturnByDate(DateTime fromDate, DateTime toDate)` | Số lượt mượn, trả và tiền phạt theo từng ngày | USP_GetBorrowReturnByDate |
| `List<TopBook> GetTopBorrowedBooks(int top, DateTime fromDate, DateTime toDate)` | Top sách được mượn nhiều nhất trong khoảng ngày | USP_GetTopBorrowedBooks |

## SettingDAO (Cấu hình hệ thống do Admin chỉnh)

| Hàm | Mô tả | SP đề xuất |
|---|---|---|
| `List<Setting> LoadSettingList()` | Lấy toàn bộ cấu hình | USP_GetSettings |
| `string GetValue(string key)` | Giá trị của 1 cấu hình, không có thì trả chuỗi rỗng | USP_GetSettingValue |
| `bool UpdateSetting(string key, string value)` | Cập nhật giá trị cấu hình | USP_UpdateSetting |
| `decimal GetFinePerDay()` | Tiền phạt mỗi ngày trễ (khóa FinePerDay) | (dùng GetValue) |
| `int GetMaxBorrowDays()` | Số ngày mượn tối đa (khóa MaxBorrowDays) | (dùng GetValue) |
| `int GetMaxBooksPerReader()` | Số sách tối đa mỗi độc giả mượn cùng lúc (khóa MaxBooksPerReader) | (dùng GetValue) |

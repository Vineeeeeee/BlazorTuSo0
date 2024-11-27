
using BlazorTuSo0.Data;

namespace BlazorTuSo0.services;

public interface IBookStoreService{

    public Task<List<Book>> GetBooks();
    public Task<Book?> GetBookById(int id);
    public Task<bool> DeleteBook(int id);
    public Task<bool> AddBook(Book book); 
}
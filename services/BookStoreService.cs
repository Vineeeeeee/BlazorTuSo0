using BlazorTuSo0.Data;
using Microsoft.EntityFrameworkCore;

using BlazorTuSo0.services;

public class BookStoreService : IBookStoreService
{
    private readonly BookStoreContext _context;
    public BookStoreService(BookStoreContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }


    public async Task<Book?> GetBookById(int id)
    {
        return await _context.Books.FindAsync(id) ?? throw new InvalidOperationException($"Book with id {id} not found.");
    }
    public async Task<bool> AddBook(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

}
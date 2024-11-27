using BlazorTuSo0.Data;
using BlazorTuSo0.services;
using Microsoft.AspNetCore.Components;
namespace BlazorTuSo0.Components.Pages.BookList;

public class Booklistbase : ComponentBase
{
[Inject]
public IBookStoreService? BookStoreService { get; set; }

public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();

protected override async Task OnInitializedAsync()
{
    if (BookStoreService != null)
    {
        Books = await BookStoreService.GetBooks();
    }
}
}


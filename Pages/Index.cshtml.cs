using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages
{
    public class IndexModel : PageModel
    {
        public List<Todo> Todos { get; set; }
        [BindProperty]
        public Todo NewTodo { get; set; }

        [BindProperty]
        public bool Done { get; set; }

        public void OnGet()
        {
            Todos = Manager.GetAll();
        }
        public IActionResult OnPostAdd()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Manager.Add(NewTodo);
            return RedirectToPage();
        }

        public IActionResult OnPostDone(int id)
        {
            var todo = Manager.GetById(id);
            if (todo != null)
            {
                todo.Done = true;
                Manager.update(todo);
            }
            return RedirectToPage();
        }


    }
}

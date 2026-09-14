using ToDo.Models;

namespace ToDo.Data
{
    public static  class Manager
    {
        public static List<Todo> todos = new List<Todo>();
        public static int counter = 1;


        static Manager()
        {
            todos.Add(new Todo
            {
                Id = counter++,
                Description = "Träna",
                Date = new DateTime(2026, 5, 2),
                Responsible = "Bakr",
                Done = false,
            });

            todos.Add(new Todo
            {
                Id = counter++,
                Description = "Handla mat",
                Date = new DateTime(2026, 5, 3),
                Responsible = "Bakr",
                Done = false,
            });

        }
        public static List<Todo> GetAll()
        {
            return todos;
        }

        public static void Add(Todo item)
        {
            item.Id = counter++;
            todos.Add(item);
        }

        public static Todo? GetById(int id)
        {
            return todos.FirstOrDefault(x => x.Id == id);
        }

        public static void update(Todo updated)
        {
            var old = GetById(updated.Id);
            if (old != null)
            {
                old.Description = updated.Description;
                old.Date = updated.Date;
                old.Responsible = updated.Responsible;
                old.Done = updated.Done;
            }
        }

        public static void delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                todos.Remove(item);
            }
        }



    }
}

using System;
namespace TurboAz
{
    public class ModelsCRUD
    {
        private readonly YourDbContext _context;

        public ModelsCRUD(YourDbContext context)
        {
            _context = context;
        }

        // Create a new model
        public void CreateModel(Model model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
        }

        public IQueryable<Model> GetAllModels()
        {
            return _context.Models.Include(m => m.Brand); 

        public Model GetModelById(int id)
        {
            return _context.Models.Include(m => m.Brand).FirstOrDefault(m => m.Id == id);
        }

        public void UpdateModel(Model updatedModel)
        {
            _context.Entry(updatedModel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteModel(int id)
        {
            var model = _context.Models.Find(id);
            if (model != null)
            {
                _context.Models.Remove(model);
                _context.SaveChanges();
            }
        }
    }
}


using System;
namespace TurboAz
{
    public class BrandsCRUD
    {
        public static void CreateBrand(string name)
        {
            using (var context = new YourDbContext())
            {
                var newBrand = new Brand { Name = name };
                context.Brands.Add(newBrand);
                context.SaveChanges();
            }
        }

        public static void ReadAllBrands()
        {
            using (var context = new YourDbContext())
            {
                var allBrands = context.Brands.ToList();
                Console.WriteLine("All Brands:");
                foreach (var brand in allBrands)
                {
                    Console.WriteLine($"Id: {brand.Id}, Name: {brand.Name}");
                }
            }
        }

        public static void UpdateBrand(int id, string newName)
        {
            using (var context = new YourDbContext())
            {
                var brandToUpdate = context.Brands.FirstOrDefault(b => b.Id == id);
                if (brandToUpdate != null)
                {
                    brandToUpdate.Name = newName;
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteBrand(int id)
        {
            using (var context = new YourDbContext())
            {
                var brandToDelete = context.Brands.FirstOrDefault(b => b.Id == id);
                if (brandToDelete != null)
                {
                    context.Brands.Remove(brandToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}


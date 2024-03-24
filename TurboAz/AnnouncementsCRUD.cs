using System;
namespace TurboAz
{
    public class AnnouncementsCRUD
    {
        public static void CreateAnnouncement(int modelId, string category, string gear, string fuelType, string transmission, int march, decimal price, int year)
        {
            using (var context = new YourDbContext())
            {
                var newAnnouncement = new Announcement
                {
                    ModelId = modelId,
                    Category = category,
                    Gear = gear,
                    FuelType = fuelType,
                    Transmission = transmission,
                    March = march,
                    Price = price,
                    Year = year
                };
                context.Announcements.Add(newAnnouncement);
                context.SaveChanges();
            }
        }

        public static void ReadAllAnnouncements()
        {
            using (var context = new YourDbContext())
            {
                var allAnnouncements = context.Announcements.Include(a => a.Model).ToList();
                Console.WriteLine("All Announcements:");
                foreach (var announcement in allAnnouncements)
                {
                    Console.WriteLine($"Id: {announcement.Id}, Model: {announcement.Model.Name}, Category: {announcement.Category}, Gear: {announcement.Gear}, FuelType: {announcement.FuelType}, Transmission: {announcement.Transmission}, March: {announcement.March}, Price: {announcement.Price}, Year: {announcement.Year}");
                }
            }
        }

        public static void UpdateAnnouncement(int id, string category, string gear, string fuelType, string transmission, int march, decimal price, int year)
        {
            using (var context = new YourDbContext())
            {
                var announcementToUpdate = context.Announcements.FirstOrDefault(a => a.Id == id);
                if (announcementToUpdate != null)
                {
                    announcementToUpdate.Category = category;
                    announcementToUpdate.Gear = gear;
                    announcementToUpdate.FuelType = fuelType;
                    announcementToUpdate.Transmission = transmission;
                    announcementToUpdate.March = march;
                    announcementToUpdate.Price = price;
                    announcementToUpdate.Year = year;
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteAnnouncement(int id)
        {
            using (var context = new YourDbContext())
            {
                var announcementToDelete = context.Announcements.FirstOrDefault(a => a.Id == id);
                if (announcementToDelete != null)
                {
                    context.Announcements.Remove(announcementToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}



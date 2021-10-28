using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies is null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id=1,Name="Apple Pie",Price=12.95M,ShortDescription="Our famous apple pie!",LongDescription="Icing carrot cake jelly-o cheescake, sweet roll marzipan",ImageUrl="",ImageThumbnailUrl="/images/applepiethumb.jpg",IsPieOfTheWeek=false},
                new Pie {Id=2,Name="BlueBerry Cheese cake",Price=18.95M,ShortDescription="You'll love it!",LongDescription="Icing carrot cake jelly-o cheescake, sweet roll marzipan",ImageUrl="",ImageThumbnailUrl="/images/Blueberrycheesecakethumb.jpg",IsPieOfTheWeek=false},
                new Pie {Id=3,Name="Cheese cake",Price=18.95M,ShortDescription="Plain cheese cake, plain pleasure!",LongDescription="Icing carrot cake jelly-o cheescake, sweet roll marzipan",ImageUrl="",ImageThumbnailUrl="/images/cheese-cakethumb.jpg",IsPieOfTheWeek=false},
                new Pie {Id=4,Name="Cherry Pie",Price=15.95M,ShortDescription="A summer classic!",LongDescription="Icing carrot cake jelly-o cheescake, sweet roll marzipan",ImageUrl="",ImageThumbnailUrl="/images/cherrypiethumb.jpg",IsPieOfTheWeek=false}
             };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}

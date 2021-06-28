using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy {CandyId=1, Name="Assorted Hard Candy", Price = 4.95M, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. ",
              Category = _categoryRepository.GetAllCategories.ToList()[0],
            ImageUrl ="https://i5.walmartimages.com/asr/f5f4d533-c37c-4624-b49d-66b5b8dc5bf1_1.5bf80a6e8c76410ec2c3ae8668e10416.jpeg?odnWidth=612&odnHeight=612&odnBg=ffffff", 
                IsInStock=true, IsOnSale=false, ImageThumbnailUrl="https://thumbs.dreamstime.com/b/candy-19828121.jpg"  },
             new Candy {CandyId=2, Name="Chocolate Candy", Price = 5.95M, Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book. It usually begins with: ",
              Category = _categoryRepository.GetAllCategories.ToList()[1],
            ImageUrl ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_ttWqm3zjTNesWPIFdwGHPIrwcAaX93msvUifQ6wIto13stDO4XvfAro1a_4&usqp=CAc",
                IsInStock=true, IsOnSale=false, ImageThumbnailUrl="https://thumbs.dreamstime.com/b/candy-19828121.jpg"  },
              new Candy {CandyId=3, Name="Fruit Candy", Price = 6.95M, Description="Colombina Filled hard ",
              Category = _categoryRepository.GetAllCategories.ToList()[2],
            ImageUrl ="https://i5.walmartimages.com/asr/036292ff-d908-4129-8a46-9c9b3b624285_1.b4cd1dc88cacb3526f986ad6adaade9c.jpeg",
                IsInStock=true, IsOnSale=true, ImageThumbnailUrl="https://thumbs.dreamstime.com/b/candy-19828121.jpg"  },
        };

    public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            throw new NotImplementedException();
        }
    }
   
}

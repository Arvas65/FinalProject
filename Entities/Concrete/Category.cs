using System;
using Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Kalmasın classlar
    public class Category : IEntity
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}

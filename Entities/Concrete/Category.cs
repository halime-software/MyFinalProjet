﻿using Entities.Asbtract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    public class Category:IEntitiy
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
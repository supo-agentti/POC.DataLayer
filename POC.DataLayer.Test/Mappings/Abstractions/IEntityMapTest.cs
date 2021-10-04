﻿using POC.DataLayer.Data.Enums;
using POC.DataLayer.Data.Models;

namespace POC.DataLayer.Data.Test.Unit.Mappings.Abstractions
{
    public interface IEntityMapTest
    {
        public void ToExternal(long id, string name, string color, Taste tasteIntl, int tasteExt);

        public void ToExternal_Null();

        public void ToModel(long id, string name, string color, Taste tasteIntl, int tasteExt);

        public void ToModel_Null();

        public void UpdateExternal(long id, string name, string color, int taste);

        public void UpdateExternal_Null(FruitEntity ext, FruitEntity update);
    }
}
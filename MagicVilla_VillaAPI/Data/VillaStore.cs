﻿using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1,Name="Pool View",Sqft=100,Occupancy=4},
            new VillaDTO{Id=2,Name="Beach VIew",Sqft=100,Occupancy=3}
        };
    }
}
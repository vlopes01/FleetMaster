using FleetMaster.DAL.Entities;
using FleetMaster.DAL.SQL.Model;
using FleetMaster.DAL.SQL.Processors;
using FleetMaster.Entities.AuxiliarEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FleetMaster.DAL
{
    public class LocationDAL
    {
        public static IEnumerable<Location> Get()
        {
            return Convert(SQLProcessor_Location.Get());   
        }

        public static DataOperationResultAdd Add(String name, String description, Guid userId)
        {
            return SQLProcessor_Location.Add(name, description, userId);  
        }

        public static DataOperationResult Update(Guid locationId, String name, String description, Guid userId)
        {
            return SQLProcessor_Location.Update(locationId, name, description, userId);   
        }

        public static DataOperationResult Delete(Guid locationId, Guid userId)
        {
            return SQLProcessor_Location.Delete(locationId, userId);
        }

        #region Conversion

        public static IEnumerable<Location> Convert(IEnumerable<DB_Location> itemsToConvert)
        {
            if (itemsToConvert != null && itemsToConvert.Count() > 0)
            {
                List<Location> itemsToReturn = new List<Location>();

                foreach (DB_Location itemToConvert in itemsToConvert)
                {
                    itemsToReturn.Add(Convert(itemToConvert));
                }

                return itemsToReturn;
            }
            else
            {
                return null;
            }
        }

        public static Location Convert(DB_Location itemToConvert)
        {
            if (itemToConvert != null && itemToConvert is DB_Location)
            {
                Location itemToReturn = new Location();
                itemToReturn.Id = itemToConvert.Id;
                itemToReturn.Description = itemToConvert.Description;
                itemToReturn.Name = itemToConvert.Name;
                return itemToReturn;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}

using FleetMaster.DAL.Entities;
using FleetMaster.DAL.SQL.Model;
using FleetMaster.DAL.SQL.Processors;
using FleetMaster.Entities.AuxiliarEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetMaster.DAL
{
    public class GroupDAL
    {
        public static IEnumerable<Group> Get()
        {
            return Convert(SQLProcessor_Group.Get());
        }

        public static DataOperationResultAdd Add(String name, String description, Guid userId)
        {
            return SQLProcessor_Group.Add(name, description, userId);
        }

        public static DataOperationResult Update(Guid groupId, String name, String description, Guid userId)
        {
            return SQLProcessor_Group.Update(groupId, name, description, userId);
        }

        public static DataOperationResult Delete(Guid groupId, Guid userId)
        {
            return SQLProcessor_Group.Delete(groupId,userId);
        }   


        #region Conversion

        public static IEnumerable<Group> Convert(IEnumerable<DB_Group> itemsToConvert)
        {
            if (itemsToConvert != null && itemsToConvert.Count() > 0)
            {
                List<Group> itemsToReturn = new List<Group>();

                foreach (DB_Group itemToConvert in itemsToConvert)
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

        public static Group Convert(DB_Group itemToConvert)
        {
            if (itemToConvert != null && itemToConvert is DB_Group)
            {
                Group itemToReturn = new Group();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IItemCarried
    {
        Response GetAllItems(ItemCarriedRequestAPI requestAPI);
        Response GetItemById(ItemCarriedRequestAPI requestAPI);
        Response GetItemByName(ItemCarriedRequestAPI requestAPI);
        Response AddItem(ItemCarriedRequestAPI requestAPI);
        Response UpdateItem(ItemCarriedRequestAPI requestAPI);
        Response UpdateItemStatus(ItemCarriedRequestAPI requestAPI);
        //UpdateK
        Response GetItemJoinByGroupMember(ItemCarriedRequestAPI requestAPI);
        //Response AddJoinItem(ItemCarriedRequestAPI requestAPI);
    }
}

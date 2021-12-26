
using RegistrationWebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using RBSCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marshal.Controllers.Utils.Data
{
    public abstract class RepositoryBase
    {
        //    public DateTime createdOn = DateTime.Now.ToIndianDateTime();
        //    public DateTime updatedOn = DateTime.Now.ToIndianDateTime();


        //    protected void Validate(dynamic dynamicObjectData)
        //    {

        //        if (dynamicObjectData.Code == -400)
        //        {
        //            throw new NotFoundException(dynamicObjectData.Info);
        //        }
        //        else if (dynamicObjectData.Code == -100)
        //        {
        //            throw new DuplicateDataException(dynamicObjectData.Info);
        //        }
        //        else if (dynamicObjectData.Code == -300)
        //        {
        //            throw new FYcloseException(dynamicObjectData.Info);
        //        }
        //        else if (dynamicObjectData.Code == -401)
        //        {
        //            throw new UnauthorizedAccessException();
        //        }
        //        else if (dynamicObjectData.Code == -201)
        //        {
        //            throw new UsedDataException(dynamicObjectData.Info);
        //        }

        //    }
        //    protected void NotFoundValidate(dynamic dynamicObjectData)
        //    {
        //        if (dynamicObjectData == null)
        //        {
        //            throw new NotFoundException(Constants.NO_DATA);
        //        }
        //    }
        //    protected void CompIDValidate(int? CompID)
        //    {
        //        if (CompID == null)
        //        {
        //            throw new UnauthorizedAccessException();
        //        }
        //    }

        //}

        //public class DDl
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //}

        //public class LedgerDDL
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int IsBankCount { get; set; }
        //}
    }
}

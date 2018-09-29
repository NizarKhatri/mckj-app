using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MCKJ.Common
{
    public class SqlCache1
    {
        private ArrayList cv = new ArrayList();
        public SqlCache1()
        {
        }

        public SqlCache1(ArrayList criteriaValue)
        {
            cv = criteriaValue;
        }

        //public string Get

        //public string InsertBillItemOption = "INSERT INTO tblBillItemOptions (ItemId, ItemOptionName, PricePerPiece) VALUES (" + CreateParamters(cv) + ")";

        //private string CreateParamters(ArrayList cv)
        //{
        //    string value = string.Empty;

        //    for (int counter = 0; counter < cv.Count; counter++)
        //    {
        //        value += "'" + cv[counter] + "'";
        //    }
        //    return value;
        //}
    }
}

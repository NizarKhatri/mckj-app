using System;
using System.Collections;

namespace MCKJ.Common
{
	/// <summary>
	/// Summary description for SQLCache.
	/// </summary>
	public class SQLCache
	{
        ArrayList cv = new ArrayList();

		public SQLCache()
		{
		}

		public SQLCache(ArrayList criteriaValues)
		{
			this.cv = criteriaValues;
		}

        public string GetSQL(string Name)
        {
            string s = string.Empty;

            switch (Name)
            {
                case "Add_BillItemOption":
                    {
                        s = "INSERT INTO tblBillItemOptions (ItemId, ItemCode, OptionText, PricePerPiece) VALUES (" + CreateParamters(cv) + ")";
                    } break;

                case "Update_BillItemOption":
                    {
                        s = "UPDATE tblBillItemOptions set ItemCode = '" + cv[1] + "', OptionText = '" + cv[2] + "', PricePerPiece = '" + cv[3] + "' WHERE ItemOptionId = '" + cv[0] + "'";
                    } break;

                case "GetBillItemOptions":
                    {
                        s = "SELECT BIO.ItemOptionId as [ID], BIO.ItemCode as [Item Code], I.ItemName as Category, BIO.OptionText as [Name], BIO.PricePerPiece [Price] from tblBillItemOptions BIO " +
                            "INNER JOIN tblBillItem I ON BIO.ItemId = I.ItemID WHERE I.ItemId = '" + cv[0] + "'";
                    } break;

                case "GetItemCode":
                    {
                        s = "EXEC GetItemCode '" + cv[0] + "'";
                    } break;

                case "GetTransactionIdByBillType":
                    {
                        s = "SELECT ISNULL(Max(TransactionNo),'') FROM tblBill where BillItemId = '" + cv[0] + "'";
                    } break;

                case "GetMemberInfo":
                    {
                        s = "SELECT FM.MemberName, FM.FatherName, FM.Mobile, F.Sign, F.ResidentAddress FROM tblFamilyMember FM INNER JOIN tblFamily F on F.FCardNo = FM.FCardNo WHERE FM.LeaderRelation = 'Head of Family' AND FM.FCardNo like '%" + cv[0] + "%'";
                    } break;

                case "GetItemOptionsByOptionId":
                    {
                        s = "SELECT ItemCode, PricePerPiece from tblBillItemOptions WHERE ItemOptionId = '" + cv[0] + "'";
                    } break;

                case "GetMemberInfoByRegNo":
                    {
                        s = "SELECT DISTINCT HB.Mr as MemberName, HB.FName as FatherName, HB.Orakh as Sign, HB.ContactNo as Mobile, HB.FCardNo as CardNo,  F.ResidentAddress as ResidentAddress from tblHallBooking HB INNER JOIN tblFamily F on HB.FCardNo = F.FCardNo " +
                            "WHERE SerialNo = '" + cv[0] + "'";
                    } break;

                case "Insert_tblBill":
                    {
                        s = "BEGIN TRANSACTION [Tran1] " + Environment.NewLine +
                            "BEGIN TRY " + Environment.NewLine +
                            "Declare @newID int" +
                            " Select @newID=ISNULL(max(BillId),0)+1 from tblBill" +
                            " INSERT INTO tblBill (BillID, BillItemId, TransactionNo, RegNo, EntryDate, TotalItems, TotalQuantity, GrandTotal, CardNo, Name, RelativeName, " + Environment.NewLine +
                            " Orakh, CellNo, RAddress, AdvanceAmount, AdvSlipNo, AdvanceDate,EventID,IsPaid,LeaseRenewalFund) VALUES (@newID,'" + cv[0] + "', '" + cv[1] + "', '" + cv[2] + "', '" + cv[3] + "', " + Environment.NewLine +
                            " '" + cv[4] + "', '" + cv[5] + "', '" + cv[6] + "', '" + cv[8] + "', '" + cv[9] + "', '" + cv[10] + "', " + Environment.NewLine +
                            " '" + cv[11] + "', '" + cv[12] + "', '" + cv[13] + "', '" + cv[14] + "', '" + cv[15] + "', '" + cv[16] + "'," + cv[17] + "," + cv[7] + ",'" + cv[18] + "')" + Environment.NewLine;
                            //" DECLARE @newID int" + Environment.NewLine +
                            //"SET @newID = SCOPE_IDENTITY()" + Environment.NewLine +
                            //" Select @newID=ISNULL(max(BillId),0)+1 from tblBill" + Environment.NewLine +
                            //" SELECT @newID as NewID" + Environment.NewLine;

                    } break;

                case "Update_tblBill":
                    {
                        s = "BEGIN TRANSACTION [Tran1] " + Environment.NewLine +
                            "BEGIN TRY " + Environment.NewLine +
                            "UPDATE tblBill SET BillItemId = " + cv[0] + ", TransactionNo = '" + cv[1] + "', RegNo = '" + cv[2] + "', " + Environment.NewLine +
                            "EntryDate = '" + cv[3] + "', TotalItems = '" + cv[4] + "', TotalQuantity = '" + cv[5] + "', GrandTotal = '" + cv[6] + "', " + Environment.NewLine +
                            "CardNo = '" + cv[8] + "', Name = '" + cv[9] + "', RelativeName = '" + cv[10] + "', " + Environment.NewLine +
                            "Orakh = '" + cv[11] + "', CellNo = '" + cv[12] + "', RAddress = '" + cv[13] + "', AdvanceAmount = '" + cv[14] + "', " +
                            "AdvSlipNo = '" + cv[15] + "', AdvanceDate = '" + cv[16] + "', EventID = " + cv[17] + ", IsPaid = " + cv[7] + ", LeaseRenewalFund = '" + cv[19] + "' WHERE BillID = " + cv[18] + Environment.NewLine +
                            "DECLARE @newID int" + Environment.NewLine +
                            "SET @newID = " + cv[18] + Environment.NewLine;
                    } break;

                case "Insert_tblBillDetail":
                    {
                        s = "INSERT INTO tblBillDetail (BillId, ItemCode, Description, Quantity, Price, Total) VALUES (@newID, '" + cv[0] + "', '" + cv[1] + "', '" + cv[2] + "', '" + cv[3] + "', '" + cv[4] + "')" + Environment.NewLine;
                    } break;

                case "Update_tblBillDetail":
                    {
                        s = "DELETE FROM tblBillDetail WHERE BillId = " + cv[18] + Environment.NewLine;
                    } break;

                case "Insert_tblBillDetailEndRegion":
                    {
                        s = "COMMIT TRANSACTION [Tran1] " + Environment.NewLine +
                            "END TRY " + Environment.NewLine +
                            "BEGIN CATCH " + Environment.NewLine +
                            "ROLLBACK TRANSACTION [Tran1] " + Environment.NewLine +
                            "END CATCH";
                    } break;

                case "Insert_tblBill_Coffin":
                    {
                        s = "BEGIN TRANSACTION [Tran1] " + Environment.NewLine +
                            "BEGIN TRY " + Environment.NewLine +
                            "Declare @newID int" +
                            " Select @newID=ISNULL(max(BillId),0)+1 from tblBill" +
                            " INSERT INTO tblBill (BillID, BillItemId, TransactionNo, RegNo, EntryDate, TotalItems, TotalQuantity, GrandTotal, CardNo, Name, RelativeName, " + Environment.NewLine +
                            " Orakh, CellNo, Age, ReasonOfDeath, TimeOfDeath, ApplicantName, IsPaid) VALUES (@newID,'" + cv[0] + "', '" + cv[1] + "', '" + cv[2] + "', '" + cv[3] + "', " + Environment.NewLine +
                            " '" + cv[4] + "', '" + cv[5] + "', '" + cv[6] + "', '" + cv[8] + "', '" + cv[9] + "', '" + cv[10] + "', " + Environment.NewLine +
                            " '" + cv[11] + "', '" + cv[12] + "', '" + cv[13] + "', " + Environment.NewLine +
                            " '" + cv[14] + "', '" + cv[15] + "', '" + cv[16] + "'," + cv[7] + ")" + Environment.NewLine;
                            //"DECLARE @newID int" + Environment.NewLine +
                            //"SET @newID = SCOPE_IDENTITY()" + Environment.NewLine +
                            //"Select @newID=ISNULL(max(BillId),0)+1 from tblBill" + 
                            //"SELECT @newID as NewID" + Environment.NewLine;

                    } break;

                case "GetBillDetail":
                    {
                        s = "SELECT DISTINCT tb.BillId, tb.TransactionNo, tb.CardNo, tb.Name [MemberName], tb.RelativeName, tb.Orakh, tb.CellNo,";
                        s += " tb.GrandTotal - tb.AdvanceAmount + tb.LeaseRenewalFund as [NetAmount],Events.Events,IsPaid,LeaseRenewalFund";
                        s += " from tblBill tb";
                        s += " INNER JOIN tblBillDetail tbd ON tb.BillId = tbd.BillId";
                        s += " LEFT JOIN tblEvents Events on tb.EventID = Events.ID";
                        s += " WHERE tb.BillItemID = '" + cv[0] + "' ORDER BY tb.BillId desc";

                    } break;

                case "GetBillForBinding":
                    {
                        s = "SELECT DISTINCT tb.* from tblBill tb WHERE tb.BillItemID = '" + cv[0] + "' AND tb.TransactionNo = '" + cv[1] + "'";
                    } break;

                case "GetBillDetailForBinding":
                    {
                        s = "SELECT tb.*, tbd.* from tblBill tb INNER JOIN tblBillDetail tbd ON tb.BillId = tbd.BillId WHERE tb.BillID = '" + cv[0] + "'";
                    } break;

                case "GetAdvanceAmountForHallBooking":
                    {
                        s = "SELECT Amount, Date from tblAdvance WHERE ReceiptNo = " + cv[0] + " AND FCardNo = '" + cv[1] + "'";
                    } break;

                case "Update_HallBooking":
                    {
                        s = "UPDATE tblHallBooking SET Event = 0 where SerialNo = " + cv[0];
                    } break;

                case "Insert_StaffNIC":
                    {
                        s = "INSERT INTO tblStaffNIC (Name, FatherName, DOB, Designation, CNIC, ContactNo, Address, Image, IsActive) VALUES (@Name, @FatherName, @DOB, @Designation, @CNIC, @ContactNo, @Address, @Image, @IsActive)";
                    } break;

                case "GetStaffMembers":
                    {
                        s = "SELECT Id, Name, FatherName, Designation, ContactNo from tblStaffNIC WHERE IsActive = 1";
                    } break;

                case "GetStaffMemberInformation":
                    {
                        s = "SELECT Name, FatherName, DOB, Designation, CNIC, ContactNo, Address, Image from tblStaffNIC where Id = " + cv[0];
                    } break;

                case "Delete_Staff":
                    {
                        s = "UPDATE tblStaffNIC SET IsActive = 0 WHERE Id = " + cv[0];
                    } break;

                case "Update_StaffNIC":
                    {
                        s = "UPDATE tblStaffNIC SET Name = @Name, FatherName = @FatherName, DOB = @DOB, Designation = @Designation, CNIC = @CNIC, ContactNo = @ContactNo, Address = @Address, Image = @Image, IsActive = @IsActive " + Environment.NewLine +
                            "WHERE Id = @Id";
                    } break;
                case "GetHallBooking":
                    {
                        s = "Select Serialno,FCardNo,Mr,Orakh,tblEvents.Events,Dated EventDate,Day,FromTime,ToTime,Hall1,Hall2,Hall3,Hall4,Hall5,ContactNo";
                        s += " From tblhallbooking";
                        s += " Left Join tblEvents on tblhallbooking.Event=tblEvents.ID";
                        s += " Order by Serialno desc";
                    } break;
                case "GetNICTableDataById":
                    {
                        s = "EXEC GetNICTableDataById " + cv[0];
                    } break;
                //case "GetCardRenewalFee":
                //    {
                //        s = "select top 1 * ";
                //        s += " from tblFamilyCardRenewalFee";
                //        s += " order by EnhanceDate desc";
                //    } break;
                //case "CheckHallBooking":
                //    {
                //        s = "Select Serialno,FCardNo,Mr,Orakh,tblEvents.Events,Dated EventDate,Day,FromTime,ToTime,Hall1,Hall2,Hall3,Hall4,Hall5,ContactNo";
                //        s += " From tblhallbooking";
                //        s += " Left Join tblEvents on tblhallbooking.Event=tblEvents.ID";
                //        s += " Order by Serialno desc";
                //    } break;

            }

            return s;
        }

        private string CreateParamters(ArrayList cv)
        {
            string value = string.Empty;

            for (int counter = 0; counter < cv.Count; counter++)
            {
                value += "'" + cv[counter] + "',";
            }

            if (value.EndsWith(","))
            {
                value = value.TrimEnd(',');
            }

            return value;
        }

        private string RemoveSingleQuote(string toClean)
        {
            if (toClean == null)
                return "";
            else
                return toClean.Replace("'", "");
        }
	}
}

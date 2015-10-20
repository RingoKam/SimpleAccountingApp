using System;
using System.Collections.Generic;
using System.Dynamic;
using AccountingApp.Data;
using AccountingApp.Model;
using AccountingApp.Model.GeneralLedgerType;

namespace AccoutingApp.BLL
{
    //CRUD 
    public class GLManager 
    {
        //TODO: dependency injection here 
        //public static mger = new GeneralLedger_Mock();

        //Add, Add a journal entry that will now be stored in DB 
        public Response<Entry> CreateJournal(Entry newEntry)
        {
            var mger = new GeneralLedger_Mock();

            var response = new Response<Entry>();
            try
            {
                if (BusinessLogicValidations.DebitCreditValid(newEntry))
                {
                    mger.CreateEntry(newEntry);
                    response.Attachment = newEntry;
                    response.Message = "Posted!";
                    response.Success = true;
                }

            }
            catch (Exception ex)
            {
                response.Message = "Oh no! Post failed" + ex.Message;
                response.Success = false;
            }
            return response; 
        } 

        //Read
        public Response<List<Entry>> GetEntry(DateTime start, DateTime end)
        {
            var mger = new GeneralLedger_Mock();
            var response = new Response<List<Entry>>();

            try
            {
                response.Attachment = mger.LoadEntry(start, end);
                response.Message = "Successful pull!";
                response.Success = true; 
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Attachment = null;
                response.Message = "Pull failed!" + ex.Message;
            }
            return response;
        }

        //update
        public void UpdateEntry(Entry updatedEntry)
        {
            var mger = new GeneralLedger_Mock();
            mger.UpdateEntry(updatedEntry);
        }

        //delete
        public void RemoveEntry(Entry deleteEntry)
        {
            var mger = new GeneralLedger_Mock();
            mger.RemoveEntry(deleteEntry);
        }
    }
}
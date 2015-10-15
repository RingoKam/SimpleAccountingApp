using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.InteropServices;
using AccountingApp.Data;
using AccountingApp.Model;
using AccountingApp.Model.ChartofAccount;
using AccountingApp.Model.Interface;

namespace AccoutingApp.BLL
{
    public class AccountManager
    {
        //TODO: implement injection here 
        IChartOfAccount repo = new ChartOfAccount_Mock();

        //Add
        public Response<Account> AddAccount(Account newAccount)
        {
            var response = new Response<Account>();
            try
            {
                repo.CreateAccount(newAccount);
                response.Attachment = newAccount;
                response.Message = "Add account success!";
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = "Add account failure" + ex.Message;
                response.Attachment = newAccount;
                response.Success = false;
            }
            return response;
        }

        //TODO: implement removal 
        public Response<Account> RemoveAccount()
        {
            var response = new Response<Account>();
            try
            {
                repo.RemoveAccount();
                //response.Attachment = ;
                response.Message = "Add account success!";
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = "Add account failure" + ex.Message;
                //response.Attachment = ;
                response.Success = false;
            }
            return response;
        }

        public Response<List<Account>> GetAllAccount()
        {
            var response = new Response<List<Account>>();

            try
            {
                response.Attachment = repo.LoadAccount();
                response.Success = true;
                response.Message = "Retrieve Account Success!";
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = "Add account failure" + ex.Message;
                response.Success = false;
                response.Attachment = null; 
            }
            return response; 
        }

        public Response<Account> EditAccount(Account updatedAccount)
        {
            var response = new Response<Account>(); 
            try
            {
                repo.UpdateAccount(updatedAccount);
                response.Success = true;
                response.Attachment = updatedAccount;
                response.Message = "Account edit was a success"; 
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Attachment = updatedAccount;
                response.Message = "Account edit failed!" + ex.Message; 
            }
            return response; 
        } 
    }
}